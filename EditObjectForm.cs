using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DateBase
{
    public partial class EditObjectForm : Form
    {
        public EditObjectForm()
        {
            InitializeComponent();
        }

        private void EditObjectForm_Load(object sender, EventArgs e)
        {
            tbObjectName.Text = Control.currentObject.Name;
            tbObjectDescription.Text = Control.currentObject.Description;
            lblFilename.Text = Control.currentObject.File.Name;
            pbOverview.BackgroundImage = Image.FromFile(Control.currentObject.File.Name);

            CompleteForm.dgvExistingUsers(this);
            CompleteForm.dgvExistingCollections(this);
            CompleteForm.dgvExistingCategories(this);

            Control.tempUsers = Control.currentObject.Users.ToList();
            Control.tempCategories = Control.currentObject.Categories.ToList();
            Control.tempCollections = Control.currentObject.Collections.ToList();

            CompleteForm.dgvObjectUsers(this);
            CompleteForm.dgvObjectCollections(this);
            CompleteForm.dgvObjectCategories(this);  
        }

        private void EditObjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Проверки на наличие изменений объекта
            if (tbObjectName.Text == Control.currentObject.Name &&
                tbObjectDescription.Text == Control.currentObject.Description &&
                (Control.tempCategories.Except(Control.currentObject.Categories)).Count() == 0 &&
                (Control.currentObject.Categories.Except(Control.tempCategories)).Count() == 0 &&
                (Control.tempUsers.Except(Control.currentObject.Users)).Count() == 0 &&
                (Control.currentObject.Users.Except(Control.tempUsers)).Count() == 0 &&
                (Control.tempCollections.Except(Control.currentObject.Collections)).Count() == 0 &&
                (Control.currentObject.Collections.Except(Control.tempCollections)).Count() == 0)
            {
                Control.Exclamation("Изменения не были внесены.", "Редактирование объекта");
                return;
            }
            if (tbObjectName.Text == string.Empty)
            {
                Control.Exclamation("Поле с названием объекта не заполнено.", "Название объекта");
                return;
            }
            if (tbObjectDescription.Text == string.Empty)
            {
                Control.Exclamation("Поле с описанием объекта не заполнено.", "Описание объекта");
                return;
            }

            Object changingObject = new Object();
            changingObject = Control.container.Objects.Find(Control.currentObject.Id);

            changingObject.Name = tbObjectName.Text;
            changingObject.Description = tbObjectDescription.Text;
            changingObject.Users = Control.tempUsers.ToList();
            changingObject.Categories = Control.tempCategories.ToList();
            changingObject.Collections = Control.tempCollections.ToList();

            // Обновляем информацию о коллекции, если отредактированный объект относится к какой-нибудь коллекции
            foreach (Collection collection in Control.currentUser.Collections)
            {
                Collection changingCollecton = new Collection();
                changingCollecton = Control.container.Collections.Find(collection.Id);
                changingCollecton.Users.Clear();
                changingCollecton.Categories.Clear();
                foreach (Object obj in collection.Objects)
                {
                    foreach (User user in obj.Users)
                    {
                        changingCollecton.Users.Add(user);
                    }
                    foreach (Category category in obj.Categories)
                    {
                        changingCollecton.Categories.Add(category);
                    }
                }
                changingCollecton.Users.Distinct();
                changingCollecton.Categories.Distinct();
            }

            // Если после редактирования объекта остались коллекции без объектов, удаляем их тоже
            foreach (Collection collection in Control.currentUser.Collections)
            {
                if (collection.Objects.Count == 0)
                {
                    Control.Exclamation(string.Format("Коллекция \"{0}\" удаляется, так как в ней больше нет объектов.", collection.Name), "Удаление коллекции");
                    Control.DeleteCollection(collection, true);
                }
            }
            Control.container.SaveChanges();

            Control.ForgetAllTempInfo();
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
            Control.Information("Все изменения успешно сохранены.", "Редактирование объекта");
            this.Close();
        }

        private void btnFileChoice_Click(object sender, EventArgs e)
        {
            Control.Exclamation("Вы не можете изменить файл объекта.", "Изменение файла объекта");
        }

        private void btnCreateNewCategory_Click(object sender, EventArgs e)
        {
            if (tbCreateNewCategory.Text == string.Empty)
            {
                Control.Exclamation("Поле категории не заполнено.", "Категория объекта");
                return;
            }
            if (Control.container.Categories.ToList().Exists(x => x.Name == tbCreateNewCategory.Text))
            {
                if (Control.tempCategories.Exists(x => x.Name == tbCreateNewCategory.Text))
                {
                    Control.Exclamation(string.Format("Категория \"{0}\" уже существует (и она уже добавлена в список категорий объекта).", tbCreateNewCategory.Text), "Категория объекта");
                    tbCreateNewCategory.Clear();
                    return;
                }
                else
                {
                    Control.tempCategories.Add(Control.container.Categories.Find(Control.container.Categories.
                        Where(x => x.Name == tbCreateNewCategory.Text).First().Id));
                    Control.Exclamation(string.Format("Категория \"{0}\" уже существует (тем не менее она добавляется в список категорий объекта).", tbCreateNewCategory.Text), "Категория объекта");
                    CompleteForm.dgvObjectCategories(this);
                    tbCreateNewCategory.Clear();
                    return;
                }
            }

            Category newCategory = new Category();
            newCategory.Name = tbCreateNewCategory.Text;

            Control.container.Categories.Add(newCategory);
            Control.container.SaveChanges();

            Control.tempCategories.Add(Control.container.Categories.Find(Control.container.Categories.
                Where(x => x.Name == tbCreateNewCategory.Text).First().Id));

            Control.Information(string.Format("Категория \"{0}\" успешно создана (и добавлена в список категорий объекта).", tbCreateNewCategory.Text), "Категория объекта");

            CompleteForm.dgvExistingCategories(this);
            CompleteForm.dgvObjectCategories(this);
            tbCreateNewCategory.Clear();
        }

        #region AddDeleteCategories
        private void btnAddCategoryToObject_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Control.FindID(dgvExistingCategories);
                Category category = Control.container.Categories.Find(id);
                if (!Control.tempCategories.Exists(x => x.Id == id))
                    Control.tempCategories.Add(category);
                else
                    Control.Exclamation(string.Format("Объект уже содержит категорию \"{0}\".", category.Name), "Список категорий объекта");
                CompleteForm.dgvObjectCategories(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите категорию, чтобы добавить ее в список категорий объекта.", "Список категорий объекта");
            }
        }

        private void btnAddAllCategoriesToObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCategories.Count == Control.container.Categories.ToList().Count)
            {
                Control.Exclamation("К объекту уже добавлены все категории.", "Список категорий объекта");
                return;
            }
            Control.tempCategories = Control.container.Categories.ToList();
            CompleteForm.dgvObjectCategories(this);
        }

        private void btnDeleteCategoryFromObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCategories.Count == 0)
            {
                Control.Exclamation("Объект не содержит ни одной категории.", "Список категорий объекта");
                return;
            }
            try
            {
                int id = Control.FindID(dgvObjectCategories);
                Control.tempCategories.Remove(Control.container.Categories.Find(id));
                CompleteForm.dgvObjectCategories(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите категорию, чтобы удалить ее из списка категорий объекта.", "Список категорий объекта");
            }
        }

        private void btnDeleteAllCategoreisFromObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCategories.Count == 0)
            {
                Control.Exclamation("Объект не содержит ни одной категории.", "Список категорий объекта");
                return;
            }
            Control.tempCategories.Clear();
            CompleteForm.dgvObjectCategories(this);
        }
        #endregion

        #region AddDeleteUsers
        private void btnAddAuthorToObject_Click(object sender, EventArgs e)
        {
            int id = Control.FindID(dgvExistingUsers);
            if (id == Control.currentUser.Id)
            {
                Control.Exclamation("Вы являетесь создателем объекта по умолчанию.", "Список создателей объекта");
                return;
            }
            try
            {
                if (!Control.tempUsers.Exists(x => x.Id == id))
                    Control.tempUsers.Add(Control.container.Users.Find(id));
                else
                    MessageBox.Show(string.Format("Пользователь \"{0}\" уже назначен как автор объекта.", id),
                    "Список авторов объекта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CompleteForm.dgvObjectUsers(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пользователя, чтобы назначить его автором объекта.",
                    "Список авторов объекта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteAuthorFromObject_Click(object sender, EventArgs e)
        {
            int id = Control.FindID(dgvObjectAuthors);
            if (id == Control.currentUser.Id)
            {
                Control.Exclamation("Вы не можете удалить себя из списка создателей объекта.", "Список создателей объекта");
                return;
            }
            try
            {
                Control.tempUsers.Remove(Control.container.Users.Find(id));
                CompleteForm.dgvObjectUsers(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите автора, чтобы удалить его из списка авторов объекта.", "Список создателей объекта");
            }
        }

        private void btnAddAllAuthorsToObject_Click(object sender, EventArgs e)
        {
            if (Control.tempUsers.Count == Control.container.Users.ToList().Count)
            {
                MessageBox.Show("Авторами объекта уже являются все пользователи.",
                    "Список авторов объекта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Control.tempUsers = Control.container.Users.ToList();
            CompleteForm.dgvObjectUsers(this);
        }

        private void btnDeleteAllAuthorsFromObject_Click(object sender, EventArgs e)
        {
            if (Control.tempUsers.Count == 1) // Текущий пользователь не удаляется из списка создателей объекта
            {
                Control.Exclamation("Все пользователи (кроме Вас) уже удалены из списка создателей объекта.", "Список создателей объекта");
                return;
            }
            Control.tempUsers.Clear();
            Control.tempUsers.Add(Control.currentUser);
            CompleteForm.dgvObjectUsers(this);
        }
        #endregion

        #region AddDeleteCollection
        private void btnAddCollectionToObject_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Control.FindID(dgvExistingCollections);
                if (!Control.tempCollections.Exists(x => x.Id == id))
                    Control.tempCollections.Add(Control.container.Collections.Find(id));
                else
                    MessageBox.Show(string.Format("Объект уже назначен коллекции \"{0}\".", id),
                    "Список коллекций объекта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CompleteForm.dgvObjectCollections(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите коллекцию, чтобы добавить в нее объект.",
                    "Список коллекций объекта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddAllCollectionsToObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCollections.Count == Control.currentUser.Collections.ToList().Count)
            {
                Control.Exclamation("К объекту уже добавлены все коллекции.", "Список коллекций объекта");
                return;
            }
            Control.tempCollections = Control.currentUser.Collections.ToList();
            CompleteForm.dgvObjectCollections(this);
        }

        private void btnDeleteCollectionFromObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCollections.Count == 0)
            {
                Control.Exclamation("Объект не содержит ни одной коллекции.", "Список коллекций объекта");
                return;
            }
            try
            {
                int id = Control.FindID(dgvObjectCollections);
                Control.tempCollections.Remove(Control.container.Collections.Find(id));
                CompleteForm.dgvObjectCollections(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите коллекцию, чтобы удалить ее из списка коллекций объекта.", "Список коллекций объекта");
            }
        }

        private void btnDeleteCollectionsFromObject_Click(object sender, EventArgs e)
        {
            if (Control.tempCollections.Count == 0)
            {
                Control.Exclamation("Объект не содержит ни одной коллекции.", "Список коллекций объекта");
                return;
            }
            Control.tempCollections.Clear();
            CompleteForm.dgvObjectCollections(this);
        }
        #endregion
    }
}
