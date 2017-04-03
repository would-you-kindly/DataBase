using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    public partial class EditCollectionForm : Form
    {
        public EditCollectionForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
            this.Close();
        }

        private void EditCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
        }

        private void EditCollectionForm_Load(object sender, EventArgs e)
        {
            tbCollectionName.Text = Control.currentCollection.Name;
            tbCollectionDescription.Text = Control.currentCollection.Description;

            CompleteForm.dgvExistingObjects(this);

            Control.tempObjects = Control.currentCollection.Objects.ToList();

            CompleteForm.dgvCollectionObjects(this);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Проверки на наличие изменений коллекции
            if (tbCollectionName.Text == Control.currentCollection.Name &&
                tbCollectionDescription.Text == Control.currentCollection.Description &&
                (Control.tempObjects.Except(Control.currentCollection.Objects)).Count() == 0 &&
                (Control.currentCollection.Objects.Except(Control.tempObjects)).Count() == 0)
            {
                Control.Exclamation("Изменения не были внесены", "Редактирование коллекции");
                return;
            }
            if (Control.tempObjects.Where(x => x.Users.Contains(Control.currentUser)).ToList().Count == 0)
            {
                Control.Exclamation("Коллекция должна содержать минимум один созданный вами объект объект.", "Редактирование коллекции");
                return;
            }
            Collection changingCollection = new Collection();
            changingCollection = Control.container.Collections.Find(Control.currentCollection.Id);

            changingCollection.Name = tbCollectionName.Text;
            changingCollection.Description = tbCollectionDescription.Text;
            changingCollection.Objects = Control.tempObjects.ToList();
            changingCollection.Users.Clear();
            changingCollection.Categories.Clear();

            foreach (Object obj in Control.tempObjects)
	        {
                foreach (User user in obj.Users)
                {
                    changingCollection.Users.Add(user);
                }
                foreach (Category category in obj.Categories)
                {
                    changingCollection.Categories.Add(category);
                }
	        }
            changingCollection.Users.Distinct();
            changingCollection.Categories.Distinct();

            Control.container.SaveChanges();

            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
            Control.Information("Все изменения успешно сохранены.", "Редактирование коллекции");
            this.Close();
        }

        #region AddDeleteObjects
        private void btnAddObjectToCollection_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Control.FindID(dgvExistingObjects);
                Object obj = Control.container.Objects.Find(id);
                if (!Control.tempObjects.Exists(x => x.Id == id))
                    Control.tempObjects.Add(obj);
                else
                    Control.Exclamation(string.Format("Коллекция уже содержит объект \"{0}\".", obj.Name), "Список объектов коллекции");
                CompleteForm.dgvCollectionObjects(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите объект, чтобы добавить его в список объектов коллекции.",
                    "Список объектов коллекции");
            }
        }

        private void btnAddAllObjectsToCollection_Click(object sender, EventArgs e)
        {
            if (Control.tempObjects.Count == Control.currentUser.Objects.Count)
            {
                Control.Exclamation("К коллекции уже добавлены все объекты.",
                    "Список объектов коллекции");
                return;
            }
            Control.tempObjects = Control.currentUser.Objects.ToList();
            CompleteForm.dgvCollectionObjects(this);
        }

        private void btnDeleteObjectFromCollection_Click(object sender, EventArgs e)
        {
            if (Control.tempObjects.Count == 0)
            {
                Control.Exclamation("Коллекци не содержит ни одного объекта.",
                    "Список объектов коллекции");
                return;
            }
            try
            {
                int id = Control.FindID(dgvCollectionObjects);
                Control.tempObjects.Remove(Control.container.Objects.Find(id));
                CompleteForm.dgvCollectionObjects(this);
            }
            catch (Exception)
            {
                Control.Exclamation("Выберите объект, чтобы удалить его из списка объектов коллекции.",
                    "Список объектов коллекции");
            }
        }

        private void btnDeleteAllObjectsFromCollection_Click(object sender, EventArgs e)
        {
            if (Control.tempObjects.Count == 0)
            {
                Control.Exclamation("Коллекция не содержит ни одного объекта.",
                    "Список объектов коллекции");
                return;
            }
            Control.tempObjects.Clear();
            CompleteForm.dgvCollectionObjects(this);
        }
        #endregion
    }
}
