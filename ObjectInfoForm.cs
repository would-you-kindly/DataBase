using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DateBase
{
    public partial class ObjectInfoForm : Form
    {
        public ObjectInfoForm()
        {
            InitializeComponent();
        }

        private void ObjectInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control.ForgetCurrentObject();
            Control.ForgetCurrentFile();
            this.Close();
        }

        private void ObjectInfoForm_Load(object sender, EventArgs e)
        {
            lblObjectName.Text = Control.currentObject.Name;
            lblObjectDescription.Text = Control.currentObject.Description;
            lblFile.Text = Control.currentObject.File.Name;
            lblCreatingDate.Text = Control.currentObject.CreatingDate.ToShortDateString();
            lblAverageMark.Text = Control.currentObject.AvarageMark.ToString();
            cbMark.SelectedIndex = 4;

            CompleteForm.dgvObjectComments(this);
            CompleteForm.dgvAuthors(this);
            CompleteForm.dgvCollections(this);
            CompleteForm.dgvCategories(this);
            CompleteForm.dgvMarks(this);   
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (tbCommentDescription.Text.Length == 0)
            {
                Control.Exclamation("Поле с описанием комментария не заполнено.", "Комментарий");
                return;
            }

            Comment newComment = new Comment();
            newComment.Title = tbCommentTitle.Text;
            newComment.Description = tbCommentDescription.Text;
            newComment.Date = DateTime.Now.Date;
            newComment.User = Control.currentUser;
            newComment.Object = Control.currentObject;

            Control.container.Comments.Add(newComment);
            Control.container.SaveChanges();

            tbCommentTitle.Clear();
            tbCommentDescription.Clear();

            CompleteForm.dgvObjectComments(this);
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (cbMark.Text.Length == 0)
            {
                Control.Exclamation("Оценка не выбрана.", "Оценка");
                return;
            }
            if (Control.currentObject.Marks.ToList().Exists(x => x.User == Control.currentUser))
            {
                Control.Exclamation("Вы уже ставили оценку этому объекту.", "Оценка");
                return;
            }

            Mark newMark = new Mark();
            newMark.Value = int.Parse(cbMark.Text);
            newMark.User = Control.currentUser;
            newMark.Object = Control.currentObject;

            Control.container.Marks.Add(newMark);

            Control.currentObject.Marks.Add(newMark);
            Control.currentObject.AvarageMark = 
                (double)(from mark in Control.currentObject.Marks select mark.Value).Sum() /
                (double)Control.currentObject.Marks.Count;

            ////ТАК ДЕЛАЕТСЯ ИЗМЕНЕНИЕ ДАННЫХ//
            //Control.container.Objects.AsEnumerable().Select(c => { c.AvarageMark = Control.currentObject.AvarageMark; return c; });
            //foreach (Object collectionObject in Control.container.Objects)
            //{
            //    Control.container.Entry(collectionObject).State = EntityState.Modified;
            //}

            Object changingObject = new Object();
            changingObject = Control.container.Objects.Find(Control.currentObject.Id);
            changingObject.AvarageMark = Control.currentObject.AvarageMark;

            Control.container.SaveChanges();

            CompleteForm.dgvMarks(this);
            lblAverageMark.Text = Control.currentObject.AvarageMark.ToString();
        }
    }
}
