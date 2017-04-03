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
    public partial class CollectionInfoForm : Form
    {
        public CollectionInfoForm()
        {
            InitializeComponent();
        }

        private void CollectionInfoForm_Load(object sender, EventArgs e)
        {
            lblCollectionName.Text = Control.currentCollection.Name;
            lblCollectionDescription.Text = Control.currentCollection.Description;
            lblCreatingDate.Text = Control.currentCollection.CreatingDate.ToShortDateString();
            lblAverageMark.Text = Control.currentCollection.AverageMark.ToString();
            cbMark.SelectedIndex = 4;

            CompleteForm.dgvCollectionComments(this);
            CompleteForm.dgvCollectionCreators(this);
            CompleteForm.dgvCollectionObjects(this);
            CompleteForm.dgvCollectionCategories(this);
            CompleteForm.dgvCollectionMarks(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control.ForgetCurrentCollection();
            this.Close();
        }

        private void CollectionInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.ForgetCurrentCollection();
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
            newComment.Collection = Control.currentCollection;

            Control.container.Comments.Add(newComment);
            Control.container.SaveChanges();

            tbCommentTitle.Clear();
            tbCommentDescription.Clear();

            CompleteForm.dgvCollectionComments(this);
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (cbMark.Text.Length == 0)
            {
                Control.Exclamation("Оценка не выбрана.", "Оценка");
                return;
            }
            if (Control.currentCollection.Marks.ToList().Exists(x => x.User == Control.currentUser))
            {
                Control.Exclamation("Вы уже ставили оценку этой коллекции.", "Оценка");
                return;
            }

            Mark newMark = new Mark();
            newMark.Value = int.Parse(cbMark.Text);
            newMark.User = Control.currentUser;
            newMark.Collection = Control.currentCollection;

            Control.container.Marks.Add(newMark);

            Control.currentCollection.Marks.Add(newMark);
            Control.currentCollection.AverageMark =
                (double)(from mark in Control.currentCollection.Marks select mark.Value).Sum() /
                (double)Control.currentCollection.Marks.Count;

            Collection changingCollection = new Collection();
            changingCollection = Control.container.Collections.Find(Control.currentCollection.Id);
            changingCollection.AverageMark = Control.currentCollection.AverageMark;

            Control.container.SaveChanges();

            CompleteForm.dgvCollectionMarks(this);
            lblAverageMark.Text = Control.currentCollection.AverageMark.ToString();
        }
    }
}
