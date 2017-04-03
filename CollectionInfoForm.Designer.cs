namespace DateBase
{
    partial class CollectionInfoForm
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
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblAverageMarkTitle = new System.Windows.Forms.Label();
            this.lblCreatingDate = new System.Windows.Forms.Label();
            this.lblCreatingDateTitle = new System.Windows.Forms.Label();
            this.lblCollectionDescription = new System.Windows.Forms.Label();
            this.lblCollectionDescriptionTitle = new System.Windows.Forms.Label();
            this.lblCollectionName = new System.Windows.Forms.Label();
            this.lblCollectionNameTitle = new System.Windows.Forms.Label();
            this.dgvCreators = new System.Windows.Forms.DataGridView();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblCommentDescription = new System.Windows.Forms.Label();
            this.tbCommentTitle = new System.Windows.Forms.TextBox();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.tbCommentDescription = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblCreators = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.dgvObjects = new System.Windows.Forms.DataGridView();
            this.lblObjects = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMarks = new System.Windows.Forms.Label();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(110, 48);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(0, 13);
            this.lblAverageMark.TabIndex = 41;
            // 
            // lblAverageMarkTitle
            // 
            this.lblAverageMarkTitle.AutoSize = true;
            this.lblAverageMarkTitle.Location = new System.Drawing.Point(12, 48);
            this.lblAverageMarkTitle.Name = "lblAverageMarkTitle";
            this.lblAverageMarkTitle.Size = new System.Drawing.Size(92, 13);
            this.lblAverageMarkTitle.TabIndex = 38;
            this.lblAverageMarkTitle.Text = "Средняя оценка:";
            // 
            // lblCreatingDate
            // 
            this.lblCreatingDate.AutoSize = true;
            this.lblCreatingDate.Location = new System.Drawing.Point(108, 35);
            this.lblCreatingDate.Name = "lblCreatingDate";
            this.lblCreatingDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreatingDate.TabIndex = 34;
            // 
            // lblCreatingDateTitle
            // 
            this.lblCreatingDateTitle.AutoSize = true;
            this.lblCreatingDateTitle.Location = new System.Drawing.Point(12, 35);
            this.lblCreatingDateTitle.Name = "lblCreatingDateTitle";
            this.lblCreatingDateTitle.Size = new System.Drawing.Size(90, 13);
            this.lblCreatingDateTitle.TabIndex = 35;
            this.lblCreatingDateTitle.Text = "Дата создания: ";
            // 
            // lblCollectionDescription
            // 
            this.lblCollectionDescription.AutoSize = true;
            this.lblCollectionDescription.Location = new System.Drawing.Point(81, 22);
            this.lblCollectionDescription.Name = "lblCollectionDescription";
            this.lblCollectionDescription.Size = new System.Drawing.Size(0, 13);
            this.lblCollectionDescription.TabIndex = 32;
            // 
            // lblCollectionDescriptionTitle
            // 
            this.lblCollectionDescriptionTitle.AutoSize = true;
            this.lblCollectionDescriptionTitle.Location = new System.Drawing.Point(12, 22);
            this.lblCollectionDescriptionTitle.Name = "lblCollectionDescriptionTitle";
            this.lblCollectionDescriptionTitle.Size = new System.Drawing.Size(63, 13);
            this.lblCollectionDescriptionTitle.TabIndex = 33;
            this.lblCollectionDescriptionTitle.Text = "Описание: ";
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.AutoSize = true;
            this.lblCollectionName.Location = new System.Drawing.Point(81, 9);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(0, 13);
            this.lblCollectionName.TabIndex = 30;
            // 
            // lblCollectionNameTitle
            // 
            this.lblCollectionNameTitle.AutoSize = true;
            this.lblCollectionNameTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCollectionNameTitle.Name = "lblCollectionNameTitle";
            this.lblCollectionNameTitle.Size = new System.Drawing.Size(63, 13);
            this.lblCollectionNameTitle.TabIndex = 31;
            this.lblCollectionNameTitle.Text = "Название: ";
            // 
            // dgvCreators
            // 
            this.dgvCreators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCreators.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCreators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreators.Location = new System.Drawing.Point(12, 381);
            this.dgvCreators.MultiSelect = false;
            this.dgvCreators.Name = "dgvCreators";
            this.dgvCreators.RowHeadersVisible = false;
            this.dgvCreators.Size = new System.Drawing.Size(180, 180);
            this.dgvCreators.TabIndex = 53;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(570, 365);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(45, 13);
            this.lblMark.TabIndex = 52;
            this.lblMark.Text = "Оценка";
            // 
            // lblCommentDescription
            // 
            this.lblCommentDescription.AutoSize = true;
            this.lblCommentDescription.Location = new System.Drawing.Point(570, 126);
            this.lblCommentDescription.Name = "lblCommentDescription";
            this.lblCommentDescription.Size = new System.Drawing.Size(129, 13);
            this.lblCommentDescription.TabIndex = 51;
            this.lblCommentDescription.Text = "Описание комментария";
            // 
            // tbCommentTitle
            // 
            this.tbCommentTitle.Location = new System.Drawing.Point(570, 103);
            this.tbCommentTitle.Name = "tbCommentTitle";
            this.tbCommentTitle.Size = new System.Drawing.Size(160, 20);
            this.tbCommentTitle.TabIndex = 50;
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Location = new System.Drawing.Point(570, 87);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(129, 13);
            this.lblCommentTitle.TabIndex = 49;
            this.lblCommentTitle.Text = "Название комментария";
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
            this.cbMark.TabIndex = 48;
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(570, 408);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(160, 23);
            this.btnAddMark.TabIndex = 47;
            this.btnAddMark.Text = "Оценить";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // tbCommentDescription
            // 
            this.tbCommentDescription.Location = new System.Drawing.Point(570, 142);
            this.tbCommentDescription.Multiline = true;
            this.tbCommentDescription.Name = "tbCommentDescription";
            this.tbCommentDescription.Size = new System.Drawing.Size(160, 50);
            this.tbCommentDescription.TabIndex = 46;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(570, 198);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(160, 23);
            this.btnAddComment.TabIndex = 45;
            this.btnAddComment.Text = "Оставить комментарий";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
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
            this.dgvComments.TabIndex = 44;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 87);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(77, 13);
            this.lblComments.TabIndex = 43;
            this.lblComments.Text = "Комментарии";
            // 
            // lblCreators
            // 
            this.lblCreators.AutoSize = true;
            this.lblCreators.Location = new System.Drawing.Point(12, 365);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(61, 13);
            this.lblCreators.TabIndex = 42;
            this.lblCreators.Text = "Создатели";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(195, 365);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 59;
            this.lblCategories.Text = "Категории";
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
            this.dgvCategories.TabIndex = 58;
            // 
            // dgvObjects
            // 
            this.dgvObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjects.Location = new System.Drawing.Point(12, 242);
            this.dgvObjects.MultiSelect = false;
            this.dgvObjects.Name = "dgvObjects";
            this.dgvObjects.RowHeadersVisible = false;
            this.dgvObjects.Size = new System.Drawing.Size(552, 120);
            this.dgvObjects.TabIndex = 57;
            // 
            // lblObjects
            // 
            this.lblObjects.AutoSize = true;
            this.lblObjects.Location = new System.Drawing.Point(12, 226);
            this.lblObjects.Name = "lblObjects";
            this.lblObjects.Size = new System.Drawing.Size(53, 13);
            this.lblObjects.TabIndex = 54;
            this.lblObjects.Text = "Объекты";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(570, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 23);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(381, 365);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(45, 13);
            this.lblMarks.TabIndex = 61;
            this.lblMarks.Text = "Оценки";
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
            this.dgvMarks.TabIndex = 62;
            // 
            // CollectionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 642);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.dgvObjects);
            this.Controls.Add(this.lblObjects);
            this.Controls.Add(this.dgvCreators);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblCommentDescription);
            this.Controls.Add(this.tbCommentTitle);
            this.Controls.Add(this.lblCommentTitle);
            this.Controls.Add(this.cbMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.tbCommentDescription);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblCreators);
            this.Controls.Add(this.lblAverageMark);
            this.Controls.Add(this.lblAverageMarkTitle);
            this.Controls.Add(this.lblCreatingDate);
            this.Controls.Add(this.lblCreatingDateTitle);
            this.Controls.Add(this.lblCollectionDescription);
            this.Controls.Add(this.lblCollectionDescriptionTitle);
            this.Controls.Add(this.lblCollectionName);
            this.Controls.Add(this.lblCollectionNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CollectionInfoForm";
            this.Text = "Информация о коллекции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CollectionInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.CollectionInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblAverageMarkTitle;
        private System.Windows.Forms.Label lblCreatingDate;
        private System.Windows.Forms.Label lblCreatingDateTitle;
        private System.Windows.Forms.Label lblCollectionDescription;
        private System.Windows.Forms.Label lblCollectionDescriptionTitle;
        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.Label lblCollectionNameTitle;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblCommentDescription;
        private System.Windows.Forms.TextBox tbCommentTitle;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.TextBox tbCommentDescription;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblCreators;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblObjects;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dgvCreators;
        public System.Windows.Forms.DataGridView dgvComments;
        public System.Windows.Forms.DataGridView dgvCategories;
        public System.Windows.Forms.DataGridView dgvObjects;
        private System.Windows.Forms.Label lblMarks;
        public System.Windows.Forms.DataGridView dgvMarks;
    }
}