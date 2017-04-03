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
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataBaseForm_Load(object sender, System.EventArgs e)
        {
            cbObjects.SelectedIndex = 0;
            CompleteForm.dgvDataBaseObjects(this);
        }

        private void cbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbObjects.Text)
            {
                case "Объекты": CompleteForm.dgvDataBaseObjects(this); break;
                case "Коллекции": CompleteForm.dgvDataBaseCollections(this); break;
                case "Пользователи": CompleteForm.dgvDataBaseUsers(this); break;
                default:
                    break;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
        }
    }
}
