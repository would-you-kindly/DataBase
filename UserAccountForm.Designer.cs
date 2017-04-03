namespace DateBase
{
    partial class UserAccountForm
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
            this.lblUserLoginTitle = new System.Windows.Forms.Label();
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.dgvObjects = new System.Windows.Forms.DataGridView();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.btnObjectInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblObjects = new System.Windows.Forms.Label();
            this.lblCollections = new System.Windows.Forms.Label();
            this.btnCollectionInfo = new System.Windows.Forms.Button();
            this.btnCreateCollection = new System.Windows.Forms.Button();
            this.btnEditObject = new System.Windows.Forms.Button();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnEditCollection = new System.Windows.Forms.Button();
            this.btnDeleteCollection = new System.Windows.Forms.Button();
            this.btnDataBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserLoginTitle
            // 
            this.lblUserLoginTitle.AutoSize = true;
            this.lblUserLoginTitle.Location = new System.Drawing.Point(12, 9);
            this.lblUserLoginTitle.Name = "lblUserLoginTitle";
            this.lblUserLoginTitle.Size = new System.Drawing.Size(118, 13);
            this.lblUserLoginTitle.TabIndex = 0;
            this.lblUserLoginTitle.Text = "Логин пользователя: ";
            // 
            // dgvCollections
            // 
            this.dgvCollections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCollections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(12, 220);
            this.dgvCollections.MultiSelect = false;
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.RowHeadersVisible = false;
            this.dgvCollections.Size = new System.Drawing.Size(444, 150);
            this.dgvCollections.TabIndex = 0;
            // 
            // dgvObjects
            // 
            this.dgvObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjects.Location = new System.Drawing.Point(12, 51);
            this.dgvObjects.MultiSelect = false;
            this.dgvObjects.Name = "dgvObjects";
            this.dgvObjects.RowHeadersVisible = false;
            this.dgvObjects.Size = new System.Drawing.Size(444, 150);
            this.dgvObjects.TabIndex = 0;
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(462, 178);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(160, 23);
            this.btnCreateObject.TabIndex = 4;
            this.btnCreateObject.Text = "Создать объект";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnObjectInfo
            // 
            this.btnObjectInfo.Location = new System.Drawing.Point(462, 51);
            this.btnObjectInfo.Name = "btnObjectInfo";
            this.btnObjectInfo.Size = new System.Drawing.Size(160, 23);
            this.btnObjectInfo.TabIndex = 1;
            this.btnObjectInfo.Text = "Информация об объекте";
            this.btnObjectInfo.UseVisualStyleBackColor = true;
            this.btnObjectInfo.Click += new System.EventHandler(this.btnObjectInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblObjects
            // 
            this.lblObjects.AutoSize = true;
            this.lblObjects.Location = new System.Drawing.Point(12, 35);
            this.lblObjects.Name = "lblObjects";
            this.lblObjects.Size = new System.Drawing.Size(56, 13);
            this.lblObjects.TabIndex = 8;
            this.lblObjects.Text = "Объекты:";
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Location = new System.Drawing.Point(12, 204);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(65, 13);
            this.lblCollections.TabIndex = 9;
            this.lblCollections.Text = "Коллекции:";
            // 
            // btnCollectionInfo
            // 
            this.btnCollectionInfo.Location = new System.Drawing.Point(462, 220);
            this.btnCollectionInfo.Name = "btnCollectionInfo";
            this.btnCollectionInfo.Size = new System.Drawing.Size(160, 23);
            this.btnCollectionInfo.TabIndex = 5;
            this.btnCollectionInfo.Text = "Информация о коллекции";
            this.btnCollectionInfo.UseVisualStyleBackColor = true;
            this.btnCollectionInfo.Click += new System.EventHandler(this.btnCollectionInfo_Click);
            // 
            // btnCreateCollection
            // 
            this.btnCreateCollection.Location = new System.Drawing.Point(462, 347);
            this.btnCreateCollection.Name = "btnCreateCollection";
            this.btnCreateCollection.Size = new System.Drawing.Size(160, 23);
            this.btnCreateCollection.TabIndex = 8;
            this.btnCreateCollection.Text = "Создать коллекцию";
            this.btnCreateCollection.UseVisualStyleBackColor = true;
            this.btnCreateCollection.Click += new System.EventHandler(this.btnCreateCollection_Click);
            // 
            // btnEditObject
            // 
            this.btnEditObject.Location = new System.Drawing.Point(462, 80);
            this.btnEditObject.Name = "btnEditObject";
            this.btnEditObject.Size = new System.Drawing.Size(160, 23);
            this.btnEditObject.TabIndex = 2;
            this.btnEditObject.Text = "Редактировать объект";
            this.btnEditObject.UseVisualStyleBackColor = true;
            this.btnEditObject.Click += new System.EventHandler(this.btnEditObject_Click);
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(462, 109);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteObject.TabIndex = 3;
            this.btnDeleteObject.Text = "Удалить объект";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Location = new System.Drawing.Point(136, 9);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(0, 13);
            this.lblUserLogin.TabIndex = 0;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(135, 22);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(0, 13);
            this.lblUserEmail.TabIndex = 1;
            // 
            // btnEditCollection
            // 
            this.btnEditCollection.Location = new System.Drawing.Point(462, 249);
            this.btnEditCollection.Name = "btnEditCollection";
            this.btnEditCollection.Size = new System.Drawing.Size(160, 23);
            this.btnEditCollection.TabIndex = 6;
            this.btnEditCollection.Text = "Редактировать коллекцию";
            this.btnEditCollection.UseVisualStyleBackColor = true;
            this.btnEditCollection.Click += new System.EventHandler(this.btnEditCollection_Click);
            // 
            // btnDeleteCollection
            // 
            this.btnDeleteCollection.Location = new System.Drawing.Point(462, 278);
            this.btnDeleteCollection.Name = "btnDeleteCollection";
            this.btnDeleteCollection.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteCollection.TabIndex = 7;
            this.btnDeleteCollection.Text = "Удалить коллекцию";
            this.btnDeleteCollection.UseVisualStyleBackColor = true;
            this.btnDeleteCollection.Click += new System.EventHandler(this.btnDeleteCollection_Click);
            // 
            // btnDataBase
            // 
            this.btnDataBase.Location = new System.Drawing.Point(462, 427);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(160, 23);
            this.btnDataBase.TabIndex = 9;
            this.btnDataBase.Text = "База данных";
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.btnDataBase);
            this.Controls.Add(this.btnDeleteCollection);
            this.Controls.Add(this.btnEditCollection);
            this.Controls.Add(this.btnDeleteObject);
            this.Controls.Add(this.btnEditObject);
            this.Controls.Add(this.btnCreateCollection);
            this.Controls.Add(this.btnCollectionInfo);
            this.Controls.Add(this.lblCollections);
            this.Controls.Add(this.lblObjects);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnObjectInfo);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.dgvObjects);
            this.Controls.Add(this.dgvCollections);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.lblUserLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserAccountForm";
            this.Text = "Аккаунт пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserLoginTitle;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Button btnObjectInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblObjects;
        private System.Windows.Forms.Label lblCollections;
        private System.Windows.Forms.Button btnCollectionInfo;
        private System.Windows.Forms.Button btnCreateCollection;
        private System.Windows.Forms.Button btnEditObject;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnEditCollection;
        private System.Windows.Forms.Button btnDeleteCollection;
        private System.Windows.Forms.Button btnDataBase;
        public System.Windows.Forms.DataGridView dgvCollections;
        public System.Windows.Forms.DataGridView dgvObjects;
    }
}