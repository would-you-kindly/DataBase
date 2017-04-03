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
    public partial class CreatingCollectionForm : Form
    {
        public CreatingCollectionForm()
        {
            InitializeComponent();
        }

        private void CreatingCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
            this.Close();
        }

        private void btnCreateCollection_Click(object sender, EventArgs e)
        {
            if (tbCollectionName.Text == string.Empty)
            {
                Control.Exclamation("Поле с названием коллекции не заполнено.", "Название коллекции");
                return;
            }
            if (tbCollectionDescription.Text == string.Empty)
            {
                Control.Exclamation("Поле с описанием коллекции не заполнено.", "Описание коллекции");
                return;
            }
            if (Control.tempObjects.Count == 0)
            {
                Control.Exclamation("Коллекция должна содержать минимум один объект.", "Объекты коллекции");
                return;
            }

            Collection newCollection = new Collection();
            newCollection.Name = tbCollectionName.Text;
            newCollection.Description = tbCollectionDescription.Text;
            newCollection.CreatingDate = DateTime.Now.Date;
            newCollection.Objects = Control.tempObjects.ToList();

            foreach (Object obj in Control.tempObjects)
                foreach (User user in obj.Users)
                    newCollection.Users.Add(user);
            newCollection.Users.Distinct();

            foreach (Object obj in Control.tempObjects)
                foreach (Category category in obj.Categories)
                    newCollection.Categories.Add(category);
            newCollection.Categories.Distinct();

            Control.container.Collections.Add(newCollection);
            foreach (Object obj in Control.tempObjects)
            {
                Object changingObject = new Object();
                changingObject = Control.container.Objects.Find(obj.Id);
            }
            Control.container.SaveChanges();

            Control.Information(string.Format("Коллекция \"{0}\" успешно создана.", newCollection.Name), "Создание коллекции");

            Control.ForgetAllTempInfo();
            Control.ForgetCurrentCollection();
            this.Close();
        }

        private void CreatingCollectionForm_Load(object sender, EventArgs e)
        {
            CompleteForm.dgvExistingObjects(this);
            CompleteForm.dgvCollectionObjects(this);
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
