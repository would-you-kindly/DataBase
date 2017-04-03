namespace DateBase
{
    partial class DataBaseForm
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
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbObjects = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBase.Location = new System.Drawing.Point(12, 39);
            this.dgvDataBase.MultiSelect = false;
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.RowHeadersVisible = false;
            this.dgvDataBase.Size = new System.Drawing.Size(760, 232);
            this.dgvDataBase.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(697, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbObjects
            // 
            this.cbObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjects.FormattingEnabled = true;
            this.cbObjects.Items.AddRange(new object[] {
            "Объекты",
            "Коллекции",
            "Пользователи"});
            this.cbObjects.Location = new System.Drawing.Point(12, 12);
            this.cbObjects.Name = "cbObjects";
            this.cbObjects.Size = new System.Drawing.Size(180, 21);
            this.cbObjects.TabIndex = 3;
            this.cbObjects.SelectedIndexChanged += new System.EventHandler(this.cbObjects_SelectedIndexChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(12, 277);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(180, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Выполнить запрос";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 312);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cbObjects);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DataBaseForm";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dgvDataBase;
        private System.Windows.Forms.ComboBox cbObjects;
        private System.Windows.Forms.Button btnQuery;

    }
}