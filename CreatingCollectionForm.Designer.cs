namespace DateBase
{
    partial class CreatingCollectionForm
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
            this.tbCollectionDescription = new System.Windows.Forms.TextBox();
            this.lblCollectionDescription = new System.Windows.Forms.Label();
            this.tbCollectionName = new System.Windows.Forms.TextBox();
            this.lblCollectionName = new System.Windows.Forms.Label();
            this.lblCollectionObjects = new System.Windows.Forms.Label();
            this.dgvCollectionObjects = new System.Windows.Forms.DataGridView();
            this.btnDeleteAllObjectsFromCollection = new System.Windows.Forms.Button();
            this.btnAddAllObjectsToCollection = new System.Windows.Forms.Button();
            this.btnDeleteObjectFromCollection = new System.Windows.Forms.Button();
            this.btnAddObjectToCollection = new System.Windows.Forms.Button();
            this.dgvExistingObjects = new System.Windows.Forms.DataGridView();
            this.lblExistingObjects = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateCollection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectionObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCollectionDescription
            // 
            this.tbCollectionDescription.Location = new System.Drawing.Point(12, 64);
            this.tbCollectionDescription.Multiline = true;
            this.tbCollectionDescription.Name = "tbCollectionDescription";
            this.tbCollectionDescription.Size = new System.Drawing.Size(200, 60);
            this.tbCollectionDescription.TabIndex = 7;
            // 
            // lblCollectionDescription
            // 
            this.lblCollectionDescription.AutoSize = true;
            this.lblCollectionDescription.Location = new System.Drawing.Point(12, 48);
            this.lblCollectionDescription.Name = "lblCollectionDescription";
            this.lblCollectionDescription.Size = new System.Drawing.Size(114, 13);
            this.lblCollectionDescription.TabIndex = 6;
            this.lblCollectionDescription.Text = "Описание коллекции";
            // 
            // tbCollectionName
            // 
            this.tbCollectionName.Location = new System.Drawing.Point(12, 25);
            this.tbCollectionName.Name = "tbCollectionName";
            this.tbCollectionName.Size = new System.Drawing.Size(200, 20);
            this.tbCollectionName.TabIndex = 5;
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.AutoSize = true;
            this.lblCollectionName.Location = new System.Drawing.Point(12, 9);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(114, 13);
            this.lblCollectionName.TabIndex = 4;
            this.lblCollectionName.Text = "Название коллекции";
            // 
            // lblCollectionObjects
            // 
            this.lblCollectionObjects.AutoSize = true;
            this.lblCollectionObjects.Location = new System.Drawing.Point(549, 9);
            this.lblCollectionObjects.Name = "lblCollectionObjects";
            this.lblCollectionObjects.Size = new System.Drawing.Size(110, 13);
            this.lblCollectionObjects.TabIndex = 47;
            this.lblCollectionObjects.Text = "Объекты коллекции";
            // 
            // dgvCollectionObjects
            // 
            this.dgvCollectionObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCollectionObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCollectionObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollectionObjects.Location = new System.Drawing.Point(552, 25);
            this.dgvCollectionObjects.MultiSelect = false;
            this.dgvCollectionObjects.Name = "dgvCollectionObjects";
            this.dgvCollectionObjects.RowHeadersVisible = false;
            this.dgvCollectionObjects.Size = new System.Drawing.Size(170, 150);
            this.dgvCollectionObjects.TabIndex = 46;
            // 
            // btnDeleteAllObjectsFromCollection
            // 
            this.btnDeleteAllObjectsFromCollection.Location = new System.Drawing.Point(471, 112);
            this.btnDeleteAllObjectsFromCollection.Name = "btnDeleteAllObjectsFromCollection";
            this.btnDeleteAllObjectsFromCollection.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllObjectsFromCollection.TabIndex = 45;
            this.btnDeleteAllObjectsFromCollection.Text = "<<";
            this.btnDeleteAllObjectsFromCollection.UseVisualStyleBackColor = true;
            this.btnDeleteAllObjectsFromCollection.Click += new System.EventHandler(this.btnDeleteAllObjectsFromCollection_Click);
            // 
            // btnAddAllObjectsToCollection
            // 
            this.btnAddAllObjectsToCollection.Location = new System.Drawing.Point(471, 54);
            this.btnAddAllObjectsToCollection.Name = "btnAddAllObjectsToCollection";
            this.btnAddAllObjectsToCollection.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllObjectsToCollection.TabIndex = 44;
            this.btnAddAllObjectsToCollection.Text = ">>";
            this.btnAddAllObjectsToCollection.UseVisualStyleBackColor = true;
            this.btnAddAllObjectsToCollection.Click += new System.EventHandler(this.btnAddAllObjectsToCollection_Click);
            // 
            // btnDeleteObjectFromCollection
            // 
            this.btnDeleteObjectFromCollection.Location = new System.Drawing.Point(471, 83);
            this.btnDeleteObjectFromCollection.Name = "btnDeleteObjectFromCollection";
            this.btnDeleteObjectFromCollection.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObjectFromCollection.TabIndex = 43;
            this.btnDeleteObjectFromCollection.Text = "<";
            this.btnDeleteObjectFromCollection.UseVisualStyleBackColor = true;
            this.btnDeleteObjectFromCollection.Click += new System.EventHandler(this.btnDeleteObjectFromCollection_Click);
            // 
            // btnAddObjectToCollection
            // 
            this.btnAddObjectToCollection.Location = new System.Drawing.Point(471, 25);
            this.btnAddObjectToCollection.Name = "btnAddObjectToCollection";
            this.btnAddObjectToCollection.Size = new System.Drawing.Size(75, 23);
            this.btnAddObjectToCollection.TabIndex = 42;
            this.btnAddObjectToCollection.Text = ">";
            this.btnAddObjectToCollection.UseVisualStyleBackColor = true;
            this.btnAddObjectToCollection.Click += new System.EventHandler(this.btnAddObjectToCollection_Click);
            // 
            // dgvExistingObjects
            // 
            this.dgvExistingObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExistingObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExistingObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingObjects.Location = new System.Drawing.Point(295, 25);
            this.dgvExistingObjects.MultiSelect = false;
            this.dgvExistingObjects.Name = "dgvExistingObjects";
            this.dgvExistingObjects.ReadOnly = true;
            this.dgvExistingObjects.RowHeadersVisible = false;
            this.dgvExistingObjects.Size = new System.Drawing.Size(170, 150);
            this.dgvExistingObjects.TabIndex = 41;
            // 
            // lblExistingObjects
            // 
            this.lblExistingObjects.AutoSize = true;
            this.lblExistingObjects.Location = new System.Drawing.Point(292, 9);
            this.lblExistingObjects.Name = "lblExistingObjects";
            this.lblExistingObjects.Size = new System.Drawing.Size(81, 13);
            this.lblExistingObjects.TabIndex = 40;
            this.lblExistingObjects.Text = "Ваши объекты";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateCollection
            // 
            this.btnCreateCollection.Location = new System.Drawing.Point(12, 130);
            this.btnCreateCollection.Name = "btnCreateCollection";
            this.btnCreateCollection.Size = new System.Drawing.Size(200, 23);
            this.btnCreateCollection.TabIndex = 50;
            this.btnCreateCollection.Text = "Создать коллекцию";
            this.btnCreateCollection.UseVisualStyleBackColor = true;
            this.btnCreateCollection.Click += new System.EventHandler(this.btnCreateCollection_Click);
            // 
            // CreatingCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 194);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateCollection);
            this.Controls.Add(this.lblCollectionObjects);
            this.Controls.Add(this.dgvCollectionObjects);
            this.Controls.Add(this.btnDeleteAllObjectsFromCollection);
            this.Controls.Add(this.btnAddAllObjectsToCollection);
            this.Controls.Add(this.btnDeleteObjectFromCollection);
            this.Controls.Add(this.btnAddObjectToCollection);
            this.Controls.Add(this.dgvExistingObjects);
            this.Controls.Add(this.lblExistingObjects);
            this.Controls.Add(this.tbCollectionDescription);
            this.Controls.Add(this.lblCollectionDescription);
            this.Controls.Add(this.tbCollectionName);
            this.Controls.Add(this.lblCollectionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreatingCollectionForm";
            this.Text = "Создание коллекции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatingCollectionForm_FormClosing);
            this.Load += new System.EventHandler(this.CreatingCollectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollectionObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCollectionDescription;
        private System.Windows.Forms.Label lblCollectionDescription;
        private System.Windows.Forms.TextBox tbCollectionName;
        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.Label lblCollectionObjects;
        private System.Windows.Forms.Button btnDeleteAllObjectsFromCollection;
        private System.Windows.Forms.Button btnAddAllObjectsToCollection;
        private System.Windows.Forms.Button btnDeleteObjectFromCollection;
        private System.Windows.Forms.Button btnAddObjectToCollection;
        private System.Windows.Forms.Label lblExistingObjects;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateCollection;
        public System.Windows.Forms.DataGridView dgvCollectionObjects;
        public System.Windows.Forms.DataGridView dgvExistingObjects;
    }
}