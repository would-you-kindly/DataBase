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
    public partial class UserAccountForm : Form
    {
        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
            Control.ForgetCurrentCollection();
            Control.ForgetCurrentUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
            Control.ForgetCurrentCollection();
            Control.ForgetCurrentUser();
            this.Close();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            lblUserLogin.Text = Control.currentUser.Name;

            CompleteForm.dgvObjects(this);
            CompleteForm.dgvCollections(this);
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            CreatingObjectForm creatingObjectForm = new CreatingObjectForm();
            creatingObjectForm.ShowDialog();
            CompleteForm.dgvObjects(this);
            CompleteForm.dgvCollections(this);
        }

        private void btnCreateCollection_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Objects.Count != 0)
            {
                CreatingCollectionForm creatingCollectionForm = new CreatingCollectionForm();
                creatingCollectionForm.ShowDialog();
                CompleteForm.dgvObjects(this);
                CompleteForm.dgvCollections(this);
            }
            else
            {
                Control.Exclamation("У вас еще нет ни одного объекта для создания коллекции.", "Создание коллекции");
            }
        }

        private void btnObjectInfo_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Objects.Count != 0)
            {
                try
                {
                    int id = Control.FindID(dgvObjects);
                    Control.currentObject = Control.container.Objects.Find(id);
                    ObjectInfoForm objectInfoForm = new ObjectInfoForm();
                    objectInfoForm.ShowDialog();
                    Control.ForgetCurrentObject();
                    CompleteForm.dgvObjects(this);
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите объект, чтобы просмотреть его данные.", "Информация об объекте");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одного объекта.", "Информация об объекте");
            }
        }

        private void btnCollectionInfo_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Collections.Count != 0)
            {
                try
                {
                    int id = Control.FindID(dgvCollections);
                    Control.currentCollection = Control.container.Collections.Find(id);
                    CollectionInfoForm collectionInfoForm = new CollectionInfoForm();
                    collectionInfoForm.ShowDialog();
                    Control.ForgetCurrentCollection();
                    CompleteForm.dgvCollections(this);
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите коллекцию, чтобы просмотреть ее данные.", "Информация о коллекции");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одной коллекции.", "Информация о коллекции");
            }
        }

        private void btnEditObject_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Objects.Count != 0)
            {
                try
                {
                    int id = Control.FindID(dgvObjects);
                    Control.currentObject = Control.container.Objects.Find(id);
                    Control.currentFile = Control.currentObject.File;
                    EditObjectForm editObjectForm = new EditObjectForm();
                    editObjectForm.ShowDialog();
                    Control.ForgetCurrentObject();
                    Control.ForgetCurrentFile();
                    CompleteForm.dgvObjects(this);
                    CompleteForm.dgvCollections(this);
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите объект, чтобы отредактировать его данные.", "Редактирование объекта");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одного объекта.", "Редактирование объекта");
            }
        }

        private void btnEditCollection_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Collections.Count != 0)
            {
                try
                {
                    int id = Control.FindID(dgvCollections);
                    Control.currentCollection = Control.container.Collections.Find(id);
                    EditCollectionForm editCollectionForm = new EditCollectionForm();
                    editCollectionForm.ShowDialog();
                    Control.ForgetCurrentCollection();
                    CompleteForm.dgvObjects(this);
                    CompleteForm.dgvCollections(this);
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите коллекцию, чтобы отредактировать ее данные.", "Редактирование коллекции");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одной коллекции.", "Редактирование коллекции");
            }
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Objects.Count != 0)
            {
                try
                {
                    if (Control.Question("Вы действительно хотите удалить объект?", "Удаление объекта") == DialogResult.Yes)
                    {
                        int id = Control.FindID(dgvObjects);
                        Control.DeleteObject(Control.container.Objects.Find(id));
                        CompleteForm.dgvObjects(this);
                        CompleteForm.dgvCollections(this);
                    }
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите объект, чтобы удалить его.", "Удаление объекта");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одного объекта.", "Удаление объекта");
            }
        }

        private void btnDeleteCollection_Click(object sender, EventArgs e)
        {
            if (Control.currentUser.Collections.Count != 0)
            {
                try
                {
                    if (Control.Question("Вы действительно хотите удалить коллекцию?", "Удаление коллекции") == DialogResult.Yes)
                    {
                        int id = Control.FindID(dgvCollections);
                        Control.DeleteCollection(Control.container.Collections.Find(id));
                        CompleteForm.dgvObjects(this);
                        CompleteForm.dgvCollections(this);
                    }
                }
                catch (Exception)
                {
                    Control.Exclamation("Выберите коллекцию, чтобы удалить ее.", "Удаление коллекции");
                }
            }
            else
            {
                Control.Exclamation("Вы еще не создали ни одной коллекции.", "Удаление коллекции");
            }
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBaseForm = new DataBaseForm();
            dataBaseForm.ShowDialog();
        }
    }
}
