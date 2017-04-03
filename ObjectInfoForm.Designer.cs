namespace DateBase
{
    partial class ObjectInfoForm
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
            this.lblObjectNameTitle = new System.Windows.Forms.Label();
            this.lblObjectDescriptionTitle = new System.Windows.Forms.Label();
            this.lblCreatingDateTitle = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblCollections = new System.Windows.Forms.Label();
            this.lblAverageMarkTitle = new System.Windows.Forms.Label();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.tbCommentDescription = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.tbCommentTitle = new System.Windows.Forms.TextBox();
            this.lblCommentDescription = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblCreatingDate = new System.Windows.Forms.Label();
            this.lblObjectDescription = new System.Windows.Forms.Label();
            this.lblObjectName = new System.Windows.Forms.Label();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.lblMarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObjectNameTitle
            // 
            this.lblObjectNameTitle.AutoSize = true;
            this.lblObjectNameTitle.Location = new System.Drawing.Point(12, 9);
            this.lblObjectNameTitle.Name = "lblObjectNameTitle";
            this.lblObjectNameTitle.Size = new System.Drawing.Size(63, 13);
            this.lblObjectNameTitle.TabIndex = 0;
            this.lblObjectNameTitle.Text = "Название: ";
            // 
            // lblObjectDescriptionTitle
            // 
            this.lblObjectDescriptionTitle.AutoSize = true;
            this.lblObjectDescriptionTitle.Location = new System.Drawing.Point(12, 22);
            this.lblObjectDescriptionTitle.Name = "lblObjectDescriptionTitle";
            this.lblObjectDescriptionTitle.Size = new System.Drawing.Size(63, 13);
            this.lblObjectDescriptionTitle.TabIndex = 1;
            this.lblObjectDescriptionTitle.Text = "Описание: ";
            // 
            // lblCreatingDateTitle
            // 
            this.lblCreatingDateTitle.AutoSize = true;
            this.lblCreatingDateTitle.Location = new System.Drawing.Point(12, 35);
            this.lblCreatingDateTitle.Name = "lblCreatingDateTitle";
            this.lblCreatingDateTitle.Size = new System.Drawing.Size(90, 13);
            this.lblCreatingDateTitle.TabIndex = 2;
            this.lblCreatingDateTitle.Text = "Дата создания: ";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(12, 365);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(61, 13);
            this.lblAuthors.TabIndex = 4;
            this.lblAuthors.Text = "Создатели";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 87);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(77, 13);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Комментарии";
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Location = new System.Drawing.Point(12, 226);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(62, 13);
            this.lblCollections.TabIndex = 6;
            this.lblCollections.Text = "Коллекции";
            // 
            // lblAverageMarkTitle
            // 
            this.lblAverageMarkTitle.AutoSize = true;
            this.lblAverageMarkTitle.Location = new System.Drawing.Point(12, 48);
            this.lblAverageMarkTitle.Name = "lblAverageMarkTitle";
            this.lblAverageMarkTitle.Size = new System.Drawing.Size(92, 13);
            this.lblAverageMarkTitle.TabIndex = 7;
            this.lblAverageMarkTitle.Text = "Средняя оценка:";
            // 
            // dgvComments
            // 
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(12, 103);
            this.dgvComments.MultiSelect = false;
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersVisible = false;
            this.dgvComments.Size = new System.Drawing.Size(552, 120);
            this.dgvComments.TabIndex = 9;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(570, 198);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(160, 23);
            this.btnAddComment.TabIndex = 10;
            this.btnAddComment.Text = "Оставить комментарий";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // tbCommentDescription
            // 
            this.tbCommentDescription.Location = new System.Drawing.Point(570, 142);
            this.tbCommentDescription.Multiline = true;
            this.tbCommentDescription.Name = "tbCommentDescription";
            this.tbCommentDescription.Size = new System.Drawing.Size(160, 50);
            this.tbCommentDescription.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(570, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(570, 408);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(160, 23);
            this.btnAddMark.TabIndex = 14;
            this.btnAddMark.Text = "Оценить";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // cbMark
            // 
            this.cbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbMark.Location = new System.Drawing.Point(570, 381);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(160, 21);
            this.cbMark.TabIndex = 15;
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Location = new System.Drawing.Point(570, 87);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(129, 13);
            this.lblCommentTitle.TabIndex = 16;
            this.lblCommentTitle.Text = "Название комментария";
            // 
            // tbCommentTitle
            // 
            this.tbCommentTitle.Location = new System.Drawing.Point(570, 103);
            this.tbCommentTitle.Name = "tbCommentTitle";
            this.tbCommentTitle.Size = new System.Drawing.Size(160, 20);
            this.tbCommentTitle.TabIndex = 17;
            // 
            // lblCommentDescription
            // 
            this.lblCommentDescription.AutoSize = true;
            this.lblCommentDescription.Location = new System.Drawing.Point(570, 126);
            this.lblCommentDescription.Name = "lblCommentDescription";
            this.lblCommentDescription.Size = new System.Drawing.Size(129, 13);
            this.lblCommentDescription.TabIndex = 18;
            this.lblCommentDescription.Text = "Описание комментария";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(570, 365);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(45, 13);
            this.lblMark.TabIndex = 19;
            this.lblMark.Text = "Оценка";
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(12, 381);
            this.dgvAuthors.MultiSelect = false;
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowHeadersVisible = false;
            this.dgvAuthors.Size = new System.Drawing.Size(180, 180);
            this.dgvAuthors.TabIndex = 21;
            // 
            // dgvCollections
            // 
            this.dgvCollections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCollections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(12, 242);
            this.dgvCollections.MultiSelect = false;
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.RowHeadersVisible = false;
            this.dgvCollections.Size = new System.Drawing.Size(552, 120);
            this.dgvCollections.TabIndex = 22;
            // 
            // lblFileTitle
            // 
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Location = new System.Drawing.Point(12, 61);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(42, 13);
            this.lblFileTitle.TabIndex = 25;
            this.lblFileTitle.Text = "Файл: ";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(198, 381);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.Size = new System.Drawing.Size(180, 180);
            this.dgvCategories.TabIndex = 27;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(195, 365);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 28;
            this.lblCategories.Text = "Категории";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(110, 48);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(0, 13);
            this.lblAverageMark.TabIndex = 29;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(60, 61);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 25;
            // 
            // lblCreatingDate
            // 
            this.lblCreatingDate.AutoSize = true;
            this.lblCreatingDate.Location = new System.Drawing.Point(108, 35);
            this.lblCreatingDate.Name = "lblCreatingDate";
            this.lblCreatingDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreatingDate.TabIndex = 2;
            // 
            // lblObjectDescription
            // 
            this.lblObjectDescription.AutoSize = true;
            this.lblObjectDescription.Location = new System.Drawing.Point(81, 22);
            this.lblObjectDescription.Name = "lblObjectDescription";
            this.lblObjectDescription.Size = new System.Drawing.Size(0, 13);
            this.lblObjectDescription.TabIndex = 1;
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Location = new System.Drawing.Point(81, 9);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(0, 13);
            this.lblObjectName.TabIndex = 0;
            // 
            // dgvMarks
            // 
            this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(384, 381);
            this.dgvMarks.MultiSelect = false;
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowHeadersVisible = false;
            this.dgvMarks.Size = new System.Drawing.Size(180, 180);
            this.dgvMarks.TabIndex = 30;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(381, 365);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(45, 13);
            this.lblMarks.TabIndex = 31;
            this.lblMarks.Text = "Оценки";
            // 
            // ObjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 642);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.lblAverageMark);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFileTitle);
            this.Controls.Add(this.dgvCollections);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblCommentDescription);
            this.Controls.Add(this.tbCommentTitle);
            this.Controls.Add(this.lblCommentTitle);
            this.Controls.Add(this.cbMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbCommentDescription);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.lblAverageMarkTitle);
            this.Controls.Add(this.lblCollections);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.lblCreatingDate);
            this.Controls.Add(this.lblCreatingDateTitle);
            this.Controls.Add(this.lblObjectDescription);
            this.Controls.Add(this.lblObjectDescriptionTitle);
            this.Controls.Add(this.lblObjectName);
            this.Controls.Add(this.lblObjectNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ObjectInfoForm";
            this.Text = "Информация об объекте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ObjectInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectNameTitle;
        private System.Windows.Forms.Label lblObjectDescriptionTitle;
        private System.Windows.Forms.Label lblCreatingDateTitle;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblCollections;
        private System.Windows.Forms.Label lblAverageMarkTitle;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.TextBox tbCommentDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.TextBox tbCommentTitle;
        private System.Windows.Forms.Label lblCommentDescription;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblCreatingDate;
        private System.Windows.Forms.Label lblObjectDescription;
        private System.Windows.Forms.Label lblObjectName;
        public System.Windows.Forms.DataGridView dgvComments;
        public System.Windows.Forms.DataGridView dgvAuthors;
        public System.Windows.Forms.DataGridView dgvCollections;
        public System.Windows.Forms.DataGridView dgvCategories;
        public System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Label lblMarks;
    }
}