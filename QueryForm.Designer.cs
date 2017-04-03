namespace DateBase
{
    partial class QueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntity = new System.Windows.Forms.Label();
            this.cbEntities = new System.Windows.Forms.ComboBox();
            this.cbProperties = new System.Windows.Forms.ComboBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cbLink = new System.Windows.Forms.ComboBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.lblQueries = new System.Windows.Forms.Label();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClearQueries = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.dtpValue = new System.Windows.Forms.DateTimePicker();
            this.btnExcelReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(9, 9);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(57, 13);
            this.lblEntity.TabIndex = 0;
            this.lblEntity.Text = "Сущность";
            // 
            // cbEntities
            // 
            this.cbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntities.FormattingEnabled = true;
            this.cbEntities.Items.AddRange(new object[] {
            "Объекты",
            "Коллекции",
            "Пользователи"});
            this.cbEntities.Location = new System.Drawing.Point(12, 25);
            this.cbEntities.Name = "cbEntities";
            this.cbEntities.Size = new System.Drawing.Size(121, 21);
            this.cbEntities.TabIndex = 1;
            this.cbEntities.SelectedIndexChanged += new System.EventHandler(this.cbEntities_SelectedIndexChanged);
            // 
            // cbProperties
            // 
            this.cbProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Items.AddRange(new object[] {
            "Название",
            "Описание",
            "Средняя оценка",
            "Дата создания"});
            this.cbProperties.Location = new System.Drawing.Point(139, 25);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(121, 21);
            this.cbProperties.TabIndex = 1;
            this.cbProperties.SelectedIndexChanged += new System.EventHandler(this.cbProperties_SelectedIndexChanged);
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(136, 9);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(55, 13);
            this.lblProperty.TabIndex = 2;
            this.lblProperty.Text = "Свойство";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(393, 25);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(120, 20);
            this.tbValue.TabIndex = 4;
            this.tbValue.Visible = false;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(390, 9);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(55, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Значение";
            // 
            // cbCondition
            // 
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "==",
            "!="});
            this.cbCondition.Location = new System.Drawing.Point(266, 25);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(121, 21);
            this.cbCondition.TabIndex = 1;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(263, 9);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(51, 13);
            this.lblCondition.TabIndex = 6;
            this.lblCondition.Text = "Условие";
            // 
            // cbLink
            // 
            this.cbLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLink.FormattingEnabled = true;
            this.cbLink.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.cbLink.Location = new System.Drawing.Point(519, 25);
            this.cbLink.Name = "cbLink";
            this.cbLink.Size = new System.Drawing.Size(121, 21);
            this.cbLink.TabIndex = 1;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(516, 9);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(44, 13);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Связка";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(646, 23);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(122, 23);
            this.btnAddCondition.TabIndex = 8;
            this.btnAddCondition.Text = "Добавить условие";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Location = new System.Drawing.Point(9, 71);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(52, 13);
            this.lblQueries.TabIndex = 9;
            this.lblQueries.Text = "Запросы";
            // 
            // dgvQueries
            // 
            this.dgvQueries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQueries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(12, 87);
            this.dgvQueries.MultiSelect = false;
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.RowHeadersVisible = false;
            this.dgvQueries.Size = new System.Drawing.Size(375, 150);
            this.dgvQueries.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(390, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Результаты поиска";
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(393, 87);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.Size = new System.Drawing.Size(375, 150);
            this.dgvResult.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 243);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(121, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "Выполнить запрос";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClearQueries
            // 
            this.btnClearQueries.Location = new System.Drawing.Point(12, 272);
            this.btnClearQueries.Name = "btnClearQueries";
            this.btnClearQueries.Size = new System.Drawing.Size(121, 23);
            this.btnClearQueries.TabIndex = 13;
            this.btnClearQueries.Text = "Очистить запросы";
            this.btnClearQueries.UseVisualStyleBackColor = true;
            this.btnClearQueries.Click += new System.EventHandler(this.btnClearQueries_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(646, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(393, 26);
            this.nudValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 20);
            this.nudValue.TabIndex = 14;
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpValue
            // 
            this.dtpValue.Location = new System.Drawing.Point(393, 25);
            this.dtpValue.Name = "dtpValue";
            this.dtpValue.Size = new System.Drawing.Size(120, 20);
            this.dtpValue.TabIndex = 15;
            // 
            // btnExcelReport
            // 
            this.btnExcelReport.Location = new System.Drawing.Point(646, 243);
            this.btnExcelReport.Name = "btnExcelReport";
            this.btnExcelReport.Size = new System.Drawing.Size(122, 23);
            this.btnExcelReport.TabIndex = 16;
            this.btnExcelReport.Text = "Отчет Excel";
            this.btnExcelReport.UseVisualStyleBackColor = true;
            this.btnExcelReport.Click += new System.EventHandler(this.btnExcelReport_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 307);
            this.Controls.Add(this.btnExcelReport);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearQueries);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvQueries);
            this.Controls.Add(this.lblQueries);
            this.Controls.Add(this.btnAddCondition);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.cbLink);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cbProperties);
            this.Controls.Add(this.cbEntities);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.dtpValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QueryForm";
            this.Text = "Конструктор запросов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryForm_FormClosing);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.ComboBox cbEntities;
        private System.Windows.Forms.ComboBox cbProperties;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cbLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.Label lblQueries;
        public System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.Label lblResult;
        public System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClearQueries;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.DateTimePicker dtpValue;
        private System.Windows.Forms.Button btnExcelReport;
    }
}