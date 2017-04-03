using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DateBase
{
    public partial class QueryForm : Form
    {
        List<string> listObjectsCollections = new List<string>() { "ID", "Название", "Описание", "Средняя оценка", "Дата создания" };
        List<string> listUsers = new List<string>() { "ID", "Имя пользователя" };
        List<string> listConditions = new List<string>() { "Равно", "Не равно", "Больше", "Меньше" };
        bool reportIsReady = false;

        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.tempQueries.Clear();
            Control.tempObjectResult.Clear();
            Control.tempCollectionResult.Clear();
            Control.tempUserResult.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control.tempQueries.Clear();
            Control.tempObjectResult.Clear();
            Control.tempCollectionResult.Clear();
            Control.tempUserResult.Clear();
            this.Close();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            cbEntities.SelectedIndex = 0;
            cbProperties.SelectedIndex = 0;
            cbCondition.SelectedIndex = 0;
            cbLink.SelectedIndex = 0;
            cbLink.Enabled = false;
            tbValue.Visible = false;
            dtpValue.Visible = false;
        }

        private void cbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEntities.Text)
            {
                case "Объекты": cbProperties.DataSource = listObjectsCollections; break;
                case "Коллекции": cbProperties.DataSource = listObjectsCollections; break;
                case "Пользователи": cbProperties.DataSource = listUsers; break;
            }
        }

        private void cbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEntities.Text)
            {
                case "Объекты":
                    switch (cbProperties.Text)
                    {
                        case "ID":
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = false;
                            dtpValue.Visible = false;
                            nudValue.Visible = true;
                            if (Control.container.Objects.ToList().Count != 0)
                                nudValue.Maximum = (from obj in Control.container.Objects select obj.Id).Max();
                            else
                                nudValue.Maximum = 1;
                            break;
                        case "Название":
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = true;
                            dtpValue.Visible = false;
                            nudValue.Visible = false;
                            break;
                        case "Описание":
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = true;
                            dtpValue.Visible = false;
                            nudValue.Visible = false;
                            break;
                        case "Средняя оценка":
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = false;
                            dtpValue.Visible = false;
                            nudValue.Visible = true;
                            nudValue.Maximum = 5;
                            break;
                        case "Дата создания":
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = false;
                            dtpValue.Visible = true;
                            nudValue.Visible = false;
                            break;
                    }
                    break; // case "Объекты":

                case "Коллекции":
                    switch (cbProperties.Text)
                    {
                        case "ID": 
                            cbCondition.DataSource = listConditions; 
                            tbValue.Visible = false;
                            dtpValue.Visible = false;
                            nudValue.Visible = true;
                            if (Control.container.Collections.ToList().Count != 0)
                                nudValue.Maximum = (from collection in Control.container.Collections select collection.Id).Max();
                            else
                                nudValue.Maximum = 1;
                            break;
                        case "Название": 
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = true;
                            dtpValue.Visible = false;
                            nudValue.Visible = false;
                            break;
                        case "Описание": 
                            cbCondition.DataSource = listConditions; 
                            tbValue.Visible = true;
                            dtpValue.Visible = false;
                            nudValue.Visible = false;
                            break;
                        case "Средняя оценка": 
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = false;
                            dtpValue.Visible = false;
                            nudValue.Visible = true;
                            nudValue.Maximum = 5;
                            break;
                        case "Дата создания": 
                            cbCondition.DataSource = listConditions; 
                            tbValue.Visible = false;
                            dtpValue.Visible = true;
                            nudValue.Visible = false;
                            break;
                    }
                    break; // case "Коллекции":

                case "Пользователи":
                    switch (cbProperties.Text)
                    {
                        case "ID": 
                            cbCondition.DataSource = listConditions; 
                            tbValue.Visible = false;
                            dtpValue.Visible = false;
                            nudValue.Visible = true;
                            if (Control.container.Users.ToList().Count != 0)
                                nudValue.Maximum = (from obj in Control.container.Users select obj.Id).Max();
                            else
                                nudValue.Maximum = 1;
                            break;
                        case "Имя пользователя": 
                            cbCondition.DataSource = listConditions;
                            tbValue.Visible = true;
                            dtpValue.Visible = false;
                            nudValue.Visible = false;
                            break;
                    }
                    break; // case "Пользователи":
                default:
                    break;
            }
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            if (tbValue.Visible && tbValue.Text == string.Empty || nudValue.Text == string.Empty)
            {
                Control.Exclamation("Поле со значением не заполнено.", "Значение");
                return;
            }
            reportIsReady = false;
            Query query = new Query();
            if (tbValue.Visible)
            {
                query = new Query()
                {
                    Entity = cbEntities.Text,
                    Property = cbProperties.Text,
                    Condition = cbCondition.Text,
                    Value = tbValue.Text,
                    Link = Control.tempQueries.Count == 0 ? "" : cbLink.Text
                };
            }
            if (nudValue.Visible)
            {
                query = new Query()
                {
                    Entity = cbEntities.Text,
                    Property = cbProperties.Text,
                    Condition = cbCondition.Text,
                    Value = nudValue.Text,
                    Link = Control.tempQueries.Count == 0 ? "" : cbLink.Text
                };
            }
            if (dtpValue.Visible)
            {
                query = new Query()
                {
                    Entity = cbEntities.Text,
                    Property = cbProperties.Text,
                    Condition = cbCondition.Text,
                    Value = dtpValue.Value.ToShortDateString(),
                    Link = Control.tempQueries.Count == 0 ? "" : cbLink.Text
                };
            }
            Control.tempQueries.Add(query);
            CompleteForm.dgvQueries(this);
            cbEntities.Enabled = false;
            cbLink.Enabled = true;
            tbValue.Clear();
        }

        private void btnClearQueries_Click(object sender, EventArgs e)
        {
            if (dgvQueries.Rows.Count == 0)
            {
                Control.Exclamation("Список запросов пуст.", "Запросы");
            }
            reportIsReady = false;
            Control.tempQueries.Clear();
            Control.tempObjectResult.Clear();
            Control.tempCollectionResult.Clear();
            Control.tempUserResult.Clear();
            dgvQueries.DataSource = null;
            dgvResult.DataSource = null;
            cbEntities.Enabled = true;
            cbLink.Enabled = false;
            tbValue.Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (dgvQueries.Rows.Count == 0)
            {
                Control.Exclamation("Список запросов пуст.", "Запросы");
                return;
            }
            reportIsReady = true;
            int row = 0;
            switch (cbEntities.Text)
            {
                case "Объекты":
                    Control.tempObjectResult = Control.container.Objects.ToList();
                    do
                    {
                        // Значения в таблице запросов
                        int intValue;
                        string stringValue;
                        DateTime dateValue;

                        switch (dgvQueries.Rows[row].Cells[1].Value.ToString()) // Атрибут в таблице запросов
                        {
                            case "ID":
                                intValue = int.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString());
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Id == intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Id == intValue)).ToList(); break;
                                    case "Не равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Id != intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Id != intValue)).ToList(); break;
                                    case "Больше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Id > intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Id > intValue)).ToList(); break;
                                    case "Меньше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Id < intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Id < intValue)).ToList(); break;
                                }
                                break;
                            case "Название":
                                stringValue = dgvQueries.Rows[row].Cells[3].Value.ToString();
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Name == stringValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Name == stringValue)).ToList(); break;
                                    case "Не равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Name != stringValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Name != stringValue)).ToList(); break;
                                    case "Больше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => string.Compare(x.Name, stringValue) > 0).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => string.Compare(x.Name, stringValue) > 0)).ToList(); break;
                                    case "Меньше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => string.Compare(x.Name, stringValue) < 0).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => string.Compare(x.Name, stringValue) < 0)).ToList(); break;
                                }
                                break;
                            case "Описание":
                                stringValue = dgvQueries.Rows[row].Cells[3].Value.ToString();
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Description == stringValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Description == stringValue)).ToList(); break;
                                    case "Не равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.Description != stringValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.Description != stringValue)).ToList(); break;
                                    case "Больше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => string.Compare(x.Description, stringValue) > 0).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => string.Compare(x.Description, stringValue) > 0)).ToList(); break;
                                    case "Меньше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => string.Compare(x.Description, stringValue) < 0).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => string.Compare(x.Description, stringValue) < 0)).ToList(); break;
                                }
                                break;
                            case "Средняя оценка":
                                intValue = int.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString());
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.AvarageMark == (double)intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.AvarageMark == (double)intValue)).ToList(); break;
                                    case "Не равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.AvarageMark != (double)intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.AvarageMark != (double)intValue)).ToList(); break;
                                    case "Больше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.AvarageMark > (double)intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.AvarageMark > (double)intValue)).ToList(); break;
                                    case "Меньше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.AvarageMark < (double)intValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.AvarageMark < (double)intValue)).ToList(); break;
                                }
                                break;
                            case "Дата создания":
                                dateValue = DateTime.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString()).Date;
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.CreatingDate == dateValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.CreatingDate == dateValue)).ToList(); break;
                                    case "Не равно": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.CreatingDate != dateValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.CreatingDate != dateValue)).ToList(); break;
                                    case "Больше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.CreatingDate > dateValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.CreatingDate > dateValue)).ToList(); break;
                                    case "Меньше": Control.tempObjectResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempObjectResult.Where(x => x.CreatingDate < dateValue).ToList() : Control.tempObjectResult.Union(Control.container.Objects.Where(x => x.CreatingDate < dateValue)).ToList(); break;
                                }
                                break;
                        }
                    } while (dgvQueries.Rows.Count != ++row);
                    if (Control.tempObjectResult.Count != 0)
                        CompleteForm.dgvObjectResults(this);
                    else
                    {
                        dgvResult.DataSource = null;
                        Control.Exclamation("По заданному запросу не найдено ни одного объекта.", "Запрос объекта");
                    }
                    break; // case "Объекты": 

                case "Коллекции":
                    Control.tempCollectionResult = Control.container.Collections.ToList();
                    do
                    {
                        // Значения в таблице запросов
                        int intValue;
                        string stringValue;
                        DateTime dateValue;

                        switch (dgvQueries.Rows[row].Cells[1].Value.ToString()) // Атрибут в таблице запросов
                        {
                            case "ID":
                                intValue = int.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString());
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Id == intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Id == intValue)).ToList(); break;
                                    case "Не равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Id != intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Id != intValue)).ToList(); break;
                                    case "Больше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Id > intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Id > intValue)).ToList(); break;
                                    case "Меньше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Id < intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Id < intValue)).ToList(); break;
                                }
                                break;
                            case "Название":
                                stringValue = dgvQueries.Rows[row].Cells[3].Value.ToString();
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Name == stringValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Name == stringValue)).ToList(); break;
                                    case "Не равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Name != stringValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Name != stringValue)).ToList(); break;
                                    case "Больше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => string.Compare(x.Name, stringValue) > 0).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => string.Compare(x.Name, stringValue) > 0)).ToList(); break;
                                    case "Меньше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => string.Compare(x.Name, stringValue) < 0).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => string.Compare(x.Name, stringValue) < 0)).ToList(); break;
                                }
                                break;
                            case "Описание":
                                stringValue = dgvQueries.Rows[row].Cells[3].Value.ToString();
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Description == stringValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Description == stringValue)).ToList(); break;
                                    case "Не равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.Description != stringValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.Description != stringValue)).ToList(); break;
                                    case "Больше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => string.Compare(x.Description, stringValue) > 0).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => string.Compare(x.Description, stringValue) > 0)).ToList(); break;
                                    case "Меньше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => string.Compare(x.Description, stringValue) < 0).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => string.Compare(x.Description, stringValue) < 0)).ToList(); break;
                                }
                                break;
                            case "Средняя оценка":
                                intValue = int.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString());
                                MessageBox.Show("средняя оценка = " + intValue);
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.AverageMark == (double)intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.AverageMark == (double)intValue)).ToList(); break;
                                    case "Не равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.AverageMark != (double)intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.AverageMark != (double)intValue)).ToList(); break;
                                    case "Больше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.AverageMark > (double)intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.AverageMark > (double)intValue)).ToList(); break;
                                    case "Меньше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.AverageMark < (double)intValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.AverageMark < (double)intValue)).ToList(); break;
                                }
                                break;
                            case "Дата создания":
                                dateValue = DateTime.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString()).Date;
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.CreatingDate == dateValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.CreatingDate == dateValue)).ToList(); break;
                                    case "Не равно": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.CreatingDate != dateValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.CreatingDate != dateValue)).ToList(); break;
                                    case "Больше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.CreatingDate > dateValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.CreatingDate > dateValue)).ToList(); break;
                                    case "Меньше": Control.tempCollectionResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempCollectionResult.Where(x => x.CreatingDate < dateValue).ToList() : Control.tempCollectionResult.Union(Control.container.Collections.Where(x => x.CreatingDate < dateValue)).ToList(); break;
                                }
                                break;
                        }
                    } while (dgvQueries.Rows.Count != ++row);
                    if (Control.tempCollectionResult.Count != 0)
                        CompleteForm.dgvCollectionResults(this);
                    else
                    {
                        dgvResult.DataSource = null;
                        Control.Exclamation("По заданному запросу не найдено ни одной коллекции.", "Запрос коллекции");
                    }
                    break; // case "Коллекции":

                case "Пользователи":
                    Control.tempUserResult = Control.container.Users.ToList();
                    do
                    {
                        // Значения в таблице запросов
                        int intValue;
                        string stringValue;

                        switch (dgvQueries.Rows[row].Cells[1].Value.ToString()) // Атрибут в таблице запросов
                        {
                            case "ID":
                                intValue = int.Parse(dgvQueries.Rows[row].Cells[3].Value.ToString());
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Id == intValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Id == intValue)).ToList(); break;
                                    case "Не равно": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Id != intValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Id != intValue)).ToList(); break;
                                    case "Больше": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Id > intValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Id > intValue)).ToList(); break;
                                    case "Меньше": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Id < intValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Id < intValue)).ToList(); break;
                                }
                                break;
                            case "Имя пользователя":
                                stringValue = dgvQueries.Rows[row].Cells[3].Value.ToString();
                                switch (dgvQueries.Rows[row].Cells[2].Value.ToString())
                                {
                                    case "Равно": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Name == stringValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Name == stringValue)).ToList(); break;
                                    case "Не равно": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => x.Name != stringValue).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => x.Name != stringValue)).ToList(); break;
                                    case "Больше": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => string.Compare(x.Name, stringValue) > 0).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => string.Compare(x.Name, stringValue) > 0)).ToList(); break;
                                    case "Меньше": Control.tempUserResult = (row == 0 || dgvQueries.Rows[row].Cells[4].Value.ToString() == "And") ? Control.tempUserResult.Where(x => string.Compare(x.Name, stringValue) < 0).ToList() : Control.tempUserResult.Union(Control.container.Users.Where(x => string.Compare(x.Name, stringValue) < 0)).ToList(); break;
                                }
                                break;
                        }
                    } while (dgvQueries.Rows.Count != ++row);
                    if (Control.tempUserResult.Count != 0)
                        CompleteForm.dgvUserResult(this);
                    else
                    {
                        dgvResult.DataSource = null;
                        Control.Exclamation("По заданному запросу не найдено ни одного пользователя.", "Запрос пользователя");
                    }
                    break; // case "Пользователи":
                default:
                    break;
            }
        }

        private void btnExcelReport_Click(object sender, EventArgs e)
        {
            if (!reportIsReady)
            {
                Control.Exclamation("Запрос не выполнен. Чтобы сгенерировать отчет, необходимо выполнить запрос.", "Ошибка при создании отчета");
                return;
            }
            Excel.Application excel = new Excel.Application();
            if (excel == null)
            {
                Control.Exclamation("На вашем компьютере отсутствует программа Excel.", "Ошибка при открытии Excel");
                return;
            }
            excel.SheetsInNewWorkbook = 1;
            excel.Workbooks.Add(Type.Missing);
            Excel.Workbook excelWorkBook = excel.Workbooks[1];
            Excel.Worksheet excelWorkSheet = excelWorkBook.Worksheets[1];
            for (int i = 0; i < 5; i++)
                excel.Columns[i + 1].ColumnWidth = 20;
            Excel.Range excelCells = excelWorkSheet.get_Range("A1", "E1");
            excelCells.Merge();
            excelCells.HorizontalAlignment = Excel.Constants.xlCenter;
            excel.Rows[1].Cells[1].Value = "Запрос";
            excel.Rows[2].Cells[1].Value = "Сущность";
            excel.Rows[2].Cells[2].Value = "Атрибут";
            excel.Rows[2].Cells[3].Value = "Условие";
            excel.Rows[2].Cells[4].Value = "Значение";
            excel.Rows[2].Cells[5].Value = "Связка";

            // Записываем запросы
            for (int i = 0; i < dgvQueries.Rows.Count; i++)
                for (int j = 0; j < dgvQueries.Columns.Count; j++)
                    excel.Rows[i + 3].Cells[j + 1].Value = dgvQueries.Rows[i].Cells[j].Value.ToString(); 

            if (cbEntities.Text == "Пользователи")
                excelCells = excelWorkSheet.get_Range((char)65 + (5 + dgvQueries.Rows.Count).ToString(), (char)(65 + 1) + (5 + dgvQueries.Rows.Count).ToString());
            else
                excelCells = excelWorkSheet.get_Range((char)65 + (5 + dgvQueries.Rows.Count).ToString(), (char)(65 + 4) + (5 + dgvQueries.Rows.Count).ToString());
            excelCells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelCells.Merge();

            int shift = dgvQueries.Rows.Count;

            excel.Rows[5 + shift].Cells[1].Value = "Результаты поиска";
            if (cbEntities.Text == "Пользователи")
	        {
                excel.Rows[6 + shift].Cells[1].Value = "ID";
                excel.Rows[6 + shift].Cells[2].Value = "Имя пользователя";
            }
            else
            {
                excel.Rows[6 + shift].Cells[1].Value = "ID";
                excel.Rows[6 + shift].Cells[2].Value = "Название";
                excel.Rows[6 + shift].Cells[3].Value = "Оисание";
                excel.Rows[6 + shift].Cells[4].Value = "Дата создания";
                excel.Rows[6 + shift].Cells[5].Value = "Средняя оценка";
            }

            // Записываем результаты запроса
            for (int i = 0; i < dgvResult.Rows.Count; i++)
                for (int j = 0; j < dgvResult.Columns.Count; j++)
                {
                    object result = dgvResult.Rows[i].Cells[j].Value;
                    if (result is DateTime)
                        excel.Rows[i + 7 + shift].Cells[j + 1].Value = DateTime.Parse(dgvResult.Rows[i].Cells[j].Value.ToString()).Date;
                    else
                        excel.Rows[i + 7 + shift].Cells[j + 1].Value = dgvResult.Rows[i].Cells[j].Value == null ? "" : dgvResult.Rows[i].Cells[j].Value.ToString();
                }

            excel.Visible = true;
        }
    }
}