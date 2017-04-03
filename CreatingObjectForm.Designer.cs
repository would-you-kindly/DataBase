namespace DateBase
{
    partial class CreatingObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatingObjectForm));
            this.lblObjectName = new System.Windows.Forms.Label();
            this.tbObjectName = new System.Windows.Forms.TextBox();
            this.lblObjectDescription = new System.Windows.Forms.Label();
            this.tbObjectDescription = new System.Windows.Forms.TextBox();
            this.btnFileChoice = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbOverview = new System.Windows.Forms.PictureBox();
            this.lblExistingCategories = new System.Windows.Forms.Label();
            this.dgvExistingCategories = new System.Windows.Forms.DataGridView();
            this.btnAddCategoryToObject = new System.Windows.Forms.Button();
            this.btnDeleteCategoryFromObject = new System.Windows.Forms.Button();
            this.btnAddAllCategoriesToObject = new System.Windows.Forms.Button();
            this.btnDeleteAllCategoreisFromObject = new System.Windows.Forms.Button();
            this.dgvObjectCategories = new System.Windows.Forms.DataGridView();
            this.lblObjectCategories = new System.Windows.Forms.Label();
            this.lblObjectAuthors = new System.Windows.Forms.Label();
            this.dgvObjectAuthors = new System.Windows.Forms.DataGridView();
            this.btnDeleteAllAuthorsFromObject = new System.Windows.Forms.Button();
            this.btnAddAllAuthorsToObject = new System.Windows.Forms.Button();
            this.btnDeleteAuthorFromObject = new System.Windows.Forms.Button();
            this.btnAddAuthorToObject = new System.Windows.Forms.Button();
            this.dgvExistingUsers = new System.Windows.Forms.DataGridView();
            this.lblExistingUsers = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblObjectCollections = new System.Windows.Forms.Label();
            this.dgvObjectCollections = new System.Windows.Forms.DataGridView();
            this.btnDeleteCollectionsFromObject = new System.Windows.Forms.Button();
            this.btnAddAllCollectionsToObject = new System.Windows.Forms.Button();
            this.btnDeleteCollectionFromObject = new System.Windows.Forms.Button();
            this.btnAddCollectionToObject = new System.Windows.Forms.Button();
            this.dgvExistingCollections = new System.Windows.Forms.DataGridView();
            this.lblExistingCollections = new System.Windows.Forms.Label();
            this.btnCreateNewCategory = new System.Windows.Forms.Button();
            this.lblCreateNewCategory = new System.Windows.Forms.Label();
            this.tbCreateNewCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCollections)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Location = new System.Drawing.Point(12, 9);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(102, 13);
            this.lblObjectName.TabIndex = 0;
            this.lblObjectName.Text = "Название объекта";
            // 
            // tbObjectName
            // 
            this.tbObjectName.Location = new System.Drawing.Point(12, 25);
            this.tbObjectName.Name = "tbObjectName";
            this.tbObjectName.Size = new System.Drawing.Size(200, 20);
            this.tbObjectName.TabIndex = 1;
            // 
            // lblObjectDescription
            // 
            this.lblObjectDescription.AutoSize = true;
            this.lblObjectDescription.Location = new System.Drawing.Point(12, 48);
            this.lblObjectDescription.Name = "lblObjectDescription";
            this.lblObjectDescription.Size = new System.Drawing.Size(102, 13);
            this.lblObjectDescription.TabIndex = 2;
            this.lblObjectDescription.Text = "Описание объекта";
            // 
            // tbObjectDescription
            // 
            this.tbObjectDescription.Location = new System.Drawing.Point(12, 64);
            this.tbObjectDescription.Multiline = true;
            this.tbObjectDescription.Name = "tbObjectDescription";
            this.tbObjectDescription.Size = new System.Drawing.Size(200, 60);
            this.tbObjectDescription.TabIndex = 3;
            // 
            // btnFileChoice
            // 
            this.btnFileChoice.Location = new System.Drawing.Point(12, 143);
            this.btnFileChoice.Name = "btnFileChoice";
            this.btnFileChoice.Size = new System.Drawing.Size(200, 23);
            this.btnFileChoice.TabIndex = 5;
            this.btnFileChoice.Text = "Выбрать файл";
            this.btnFileChoice.UseVisualStyleBackColor = true;
            this.btnFileChoice.Click += new System.EventHandler(this.btnFileChoice_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 127);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(36, 13);
            this.lblFilename.TabIndex = 6;
            this.lblFilename.Text = "Файл";
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(12, 461);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(200, 23);
            this.btnCreateObject.TabIndex = 7;
            this.btnCreateObject.Text = "Создать объект";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbOverview
            // 
            this.pbOverview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOverview.BackgroundImage")));
            this.pbOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbOverview.Location = new System.Drawing.Point(12, 185);
            this.pbOverview.Name = "pbOverview";
            this.pbOverview.Size = new System.Drawing.Size(200, 159);
            this.pbOverview.TabIndex = 9;
            this.pbOverview.TabStop = false;
            // 
            // lblExistingCategories
            // 
            this.lblExistingCategories.AutoSize = true;
            this.lblExistingCategories.Location = new System.Drawing.Point(292, 9);
            this.lblExistingCategories.Name = "lblExistingCategories";
            this.lblExistingCategories.Size = new System.Drawing.Size(140, 13);
            this.lblExistingCategories.TabIndex = 10;
            this.lblExistingCategories.Text = "Существующие категории";
            // 
            // dgvExistingCategories
            // 
            this.dgvExistingCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExistingCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExistingCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingCategories.Location = new System.Drawing.Point(295, 25);
            this.dgvExistingCategories.MultiSelect = false;
            this.dgvExistingCategories.Name = "dgvExistingCategories";
            this.dgvExistingCategories.RowHeadersVisible = false;
            this.dgvExistingCategories.Size = new System.Drawing.Size(170, 150);
            this.dgvExistingCategories.TabIndex = 11;
            // 
            // btnAddCategoryToObject
            // 
            this.btnAddCategoryToObject.Location = new System.Drawing.Point(471, 25);
            this.btnAddCategoryToObject.Name = "btnAddCategoryToObject";
            this.btnAddCategoryToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategoryToObject.TabIndex = 12;
            this.btnAddCategoryToObject.Text = ">";
            this.btnAddCategoryToObject.UseVisualStyleBackColor = true;
            this.btnAddCategoryToObject.Click += new System.EventHandler(this.btnAddCategoryToObject_Click);
            // 
            // btnDeleteCategoryFromObject
            // 
            this.btnDeleteCategoryFromObject.Location = new System.Drawing.Point(471, 83);
            this.btnDeleteCategoryFromObject.Name = "btnDeleteCategoryFromObject";
            this.btnDeleteCategoryFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategoryFromObject.TabIndex = 13;
            this.btnDeleteCategoryFromObject.Text = "<";
            this.btnDeleteCategoryFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteCategoryFromObject.Click += new System.EventHandler(this.btnDeleteCategoryFromObject_Click);
            // 
            // btnAddAllCategoriesToObject
            // 
            this.btnAddAllCategoriesToObject.Location = new System.Drawing.Point(471, 54);
            this.btnAddAllCategoriesToObject.Name = "btnAddAllCategoriesToObject";
            this.btnAddAllCategoriesToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllCategoriesToObject.TabIndex = 14;
            this.btnAddAllCategoriesToObject.Text = ">>";
            this.btnAddAllCategoriesToObject.UseVisualStyleBackColor = true;
            this.btnAddAllCategoriesToObject.Click += new System.EventHandler(this.btnAddAllCategoriesToObject_Click);
            // 
            // btnDeleteAllCategoreisFromObject
            // 
            this.btnDeleteAllCategoreisFromObject.Location = new System.Drawing.Point(471, 112);
            this.btnDeleteAllCategoreisFromObject.Name = "btnDeleteAllCategoreisFromObject";
            this.btnDeleteAllCategoreisFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllCategoreisFromObject.TabIndex = 15;
            this.btnDeleteAllCategoreisFromObject.Text = "<<";
            this.btnDeleteAllCategoreisFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteAllCategoreisFromObject.Click += new System.EventHandler(this.btnDeleteAllCategoreisFromObject_Click);
            // 
            // dgvObjectCategories
            // 
            this.dgvObjectCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObjectCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjectCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectCategories.Location = new System.Drawing.Point(552, 25);
            this.dgvObjectCategories.MultiSelect = false;
            this.dgvObjectCategories.Name = "dgvObjectCategories";
            this.dgvObjectCategories.RowHeadersVisible = false;
            this.dgvObjectCategories.Size = new System.Drawing.Size(170, 150);
            this.dgvObjectCategories.TabIndex = 16;
            // 
            // lblObjectCategories
            // 
            this.lblObjectCategories.AutoSize = true;
            this.lblObjectCategories.Location = new System.Drawing.Point(549, 9);
            this.lblObjectCategories.Name = "lblObjectCategories";
            this.lblObjectCategories.Size = new System.Drawing.Size(105, 13);
            this.lblObjectCategories.TabIndex = 17;
            this.lblObjectCategories.Text = "Категории объекта";
            // 
            // lblObjectAuthors
            // 
            this.lblObjectAuthors.AutoSize = true;
            this.lblObjectAuthors.Location = new System.Drawing.Point(549, 178);
            this.lblObjectAuthors.Name = "lblObjectAuthors";
            this.lblObjectAuthors.Size = new System.Drawing.Size(119, 13);
            this.lblObjectAuthors.TabIndex = 25;
            this.lblObjectAuthors.Text = "Авторы объекта (+вы)";
            // 
            // dgvObjectAuthors
            // 
            this.dgvObjectAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObjectAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjectAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectAuthors.Location = new System.Drawing.Point(552, 194);
            this.dgvObjectAuthors.MultiSelect = false;
            this.dgvObjectAuthors.Name = "dgvObjectAuthors";
            this.dgvObjectAuthors.RowHeadersVisible = false;
            this.dgvObjectAuthors.Size = new System.Drawing.Size(170, 150);
            this.dgvObjectAuthors.TabIndex = 24;
            // 
            // btnDeleteAllAuthorsFromObject
            // 
            this.btnDeleteAllAuthorsFromObject.Location = new System.Drawing.Point(471, 281);
            this.btnDeleteAllAuthorsFromObject.Name = "btnDeleteAllAuthorsFromObject";
            this.btnDeleteAllAuthorsFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllAuthorsFromObject.TabIndex = 23;
            this.btnDeleteAllAuthorsFromObject.Text = "<<";
            this.btnDeleteAllAuthorsFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteAllAuthorsFromObject.Click += new System.EventHandler(this.btnDeleteAllAuthorsFromObject_Click);
            // 
            // btnAddAllAuthorsToObject
            // 
            this.btnAddAllAuthorsToObject.Location = new System.Drawing.Point(471, 223);
            this.btnAddAllAuthorsToObject.Name = "btnAddAllAuthorsToObject";
            this.btnAddAllAuthorsToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllAuthorsToObject.TabIndex = 22;
            this.btnAddAllAuthorsToObject.Text = ">>";
            this.btnAddAllAuthorsToObject.UseVisualStyleBackColor = true;
            this.btnAddAllAuthorsToObject.Click += new System.EventHandler(this.btnAddAllAuthorsToObject_Click);
            // 
            // btnDeleteAuthorFromObject
            // 
            this.btnDeleteAuthorFromObject.Location = new System.Drawing.Point(471, 252);
            this.btnDeleteAuthorFromObject.Name = "btnDeleteAuthorFromObject";
            this.btnDeleteAuthorFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAuthorFromObject.TabIndex = 21;
            this.btnDeleteAuthorFromObject.Text = "<";
            this.btnDeleteAuthorFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteAuthorFromObject.Click += new System.EventHandler(this.btnDeleteAuthorFromObject_Click);
            // 
            // btnAddAuthorToObject
            // 
            this.btnAddAuthorToObject.Location = new System.Drawing.Point(471, 194);
            this.btnAddAuthorToObject.Name = "btnAddAuthorToObject";
            this.btnAddAuthorToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthorToObject.TabIndex = 20;
            this.btnAddAuthorToObject.Text = ">";
            this.btnAddAuthorToObject.UseVisualStyleBackColor = true;
            this.btnAddAuthorToObject.Click += new System.EventHandler(this.btnAddAuthorToObject_Click);
            // 
            // dgvExistingUsers
            // 
            this.dgvExistingUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExistingUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExistingUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingUsers.Location = new System.Drawing.Point(295, 194);
            this.dgvExistingUsers.MultiSelect = false;
            this.dgvExistingUsers.Name = "dgvExistingUsers";
            this.dgvExistingUsers.RowHeadersVisible = false;
            this.dgvExistingUsers.Size = new System.Drawing.Size(170, 150);
            this.dgvExistingUsers.TabIndex = 19;
            // 
            // lblExistingUsers
            // 
            this.lblExistingUsers.AutoSize = true;
            this.lblExistingUsers.Location = new System.Drawing.Point(292, 178);
            this.lblExistingUsers.Name = "lblExistingUsers";
            this.lblExistingUsers.Size = new System.Drawing.Size(159, 13);
            this.lblExistingUsers.TabIndex = 18;
            this.lblExistingUsers.Text = "Существующие пользователи";
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Location = new System.Drawing.Point(12, 169);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(82, 13);
            this.lblOverview.TabIndex = 26;
            this.lblOverview.Text = "Предпросмотр";
            // 
            // lblObjectCollections
            // 
            this.lblObjectCollections.AutoSize = true;
            this.lblObjectCollections.Location = new System.Drawing.Point(549, 347);
            this.lblObjectCollections.Name = "lblObjectCollections";
            this.lblObjectCollections.Size = new System.Drawing.Size(107, 13);
            this.lblObjectCollections.TabIndex = 34;
            this.lblObjectCollections.Text = "Коллекции объекта";
            // 
            // dgvObjectCollections
            // 
            this.dgvObjectCollections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObjectCollections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjectCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectCollections.Location = new System.Drawing.Point(552, 363);
            this.dgvObjectCollections.MultiSelect = false;
            this.dgvObjectCollections.Name = "dgvObjectCollections";
            this.dgvObjectCollections.RowHeadersVisible = false;
            this.dgvObjectCollections.Size = new System.Drawing.Size(170, 150);
            this.dgvObjectCollections.TabIndex = 33;
            // 
            // btnDeleteCollectionsFromObject
            // 
            this.btnDeleteCollectionsFromObject.Location = new System.Drawing.Point(471, 450);
            this.btnDeleteCollectionsFromObject.Name = "btnDeleteCollectionsFromObject";
            this.btnDeleteCollectionsFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCollectionsFromObject.TabIndex = 32;
            this.btnDeleteCollectionsFromObject.Text = "<<";
            this.btnDeleteCollectionsFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteCollectionsFromObject.Click += new System.EventHandler(this.btnDeleteCollectionsFromObject_Click);
            // 
            // btnAddAllCollectionsToObject
            // 
            this.btnAddAllCollectionsToObject.Location = new System.Drawing.Point(471, 392);
            this.btnAddAllCollectionsToObject.Name = "btnAddAllCollectionsToObject";
            this.btnAddAllCollectionsToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllCollectionsToObject.TabIndex = 31;
            this.btnAddAllCollectionsToObject.Text = ">>";
            this.btnAddAllCollectionsToObject.UseVisualStyleBackColor = true;
            this.btnAddAllCollectionsToObject.Click += new System.EventHandler(this.btnAddAllCollectionsToObject_Click);
            // 
            // btnDeleteCollectionFromObject
            // 
            this.btnDeleteCollectionFromObject.Location = new System.Drawing.Point(471, 421);
            this.btnDeleteCollectionFromObject.Name = "btnDeleteCollectionFromObject";
            this.btnDeleteCollectionFromObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCollectionFromObject.TabIndex = 30;
            this.btnDeleteCollectionFromObject.Text = "<";
            this.btnDeleteCollectionFromObject.UseVisualStyleBackColor = true;
            this.btnDeleteCollectionFromObject.Click += new System.EventHandler(this.btnDeleteCollectionFromObject_Click);
            // 
            // btnAddCollectionToObject
            // 
            this.btnAddCollectionToObject.Location = new System.Drawing.Point(471, 363);
            this.btnAddCollectionToObject.Name = "btnAddCollectionToObject";
            this.btnAddCollectionToObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddCollectionToObject.TabIndex = 29;
            this.btnAddCollectionToObject.Text = ">";
            this.btnAddCollectionToObject.UseVisualStyleBackColor = true;
            this.btnAddCollectionToObject.Click += new System.EventHandler(this.btnAddCollectionToObject_Click);
            // 
            // dgvExistingCollections
            // 
            this.dgvExistingCollections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExistingCollections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExistingCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingCollections.Location = new System.Drawing.Point(295, 363);
            this.dgvExistingCollections.MultiSelect = false;
            this.dgvExistingCollections.Name = "dgvExistingCollections";
            this.dgvExistingCollections.RowHeadersVisible = false;
            this.dgvExistingCollections.Size = new System.Drawing.Size(170, 150);
            this.dgvExistingCollections.TabIndex = 28;
            // 
            // lblExistingCollections
            // 
            this.lblExistingCollections.AutoSize = true;
            this.lblExistingCollections.Location = new System.Drawing.Point(292, 347);
            this.lblExistingCollections.Name = "lblExistingCollections";
            this.lblExistingCollections.Size = new System.Drawing.Size(91, 13);
            this.lblExistingCollections.TabIndex = 27;
            this.lblExistingCollections.Text = "Ваши коллекции";
            // 
            // btnCreateNewCategory
            // 
            this.btnCreateNewCategory.Location = new System.Drawing.Point(12, 389);
            this.btnCreateNewCategory.Name = "btnCreateNewCategory";
            this.btnCreateNewCategory.Size = new System.Drawing.Size(200, 23);
            this.btnCreateNewCategory.TabIndex = 35;
            this.btnCreateNewCategory.Text = "Создать категорию";
            this.btnCreateNewCategory.UseVisualStyleBackColor = true;
            this.btnCreateNewCategory.Click += new System.EventHandler(this.btnCreateNewCategory_Click);
            // 
            // lblCreateNewCategory
            // 
            this.lblCreateNewCategory.AutoSize = true;
            this.lblCreateNewCategory.Location = new System.Drawing.Point(12, 347);
            this.lblCreateNewCategory.Name = "lblCreateNewCategory";
            this.lblCreateNewCategory.Size = new System.Drawing.Size(144, 13);
            this.lblCreateNewCategory.TabIndex = 36;
            this.lblCreateNewCategory.Text = "Создать новую категорию*";
            // 
            // tbCreateNewCategory
            // 
            this.tbCreateNewCategory.Location = new System.Drawing.Point(12, 363);
            this.tbCreateNewCategory.Name = "tbCreateNewCategory";
            this.tbCreateNewCategory.Size = new System.Drawing.Size(200, 20);
            this.tbCreateNewCategory.TabIndex = 37;
            // 
            // CreatingObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 525);
            this.Controls.Add(this.tbCreateNewCategory);
            this.Controls.Add(this.lblCreateNewCategory);
            this.Controls.Add(this.btnCreateNewCategory);
            this.Controls.Add(this.lblObjectCollections);
            this.Controls.Add(this.dgvObjectCollections);
            this.Controls.Add(this.btnDeleteCollectionsFromObject);
            this.Controls.Add(this.btnAddAllCollectionsToObject);
            this.Controls.Add(this.btnDeleteCollectionFromObject);
            this.Controls.Add(this.btnAddCollectionToObject);
            this.Controls.Add(this.dgvExistingCollections);
            this.Controls.Add(this.lblExistingCollections);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.lblObjectAuthors);
            this.Controls.Add(this.dgvObjectAuthors);
            this.Controls.Add(this.btnDeleteAllAuthorsFromObject);
            this.Controls.Add(this.btnAddAllAuthorsToObject);
            this.Controls.Add(this.btnDeleteAuthorFromObject);
            this.Controls.Add(this.btnAddAuthorToObject);
            this.Controls.Add(this.dgvExistingUsers);
            this.Controls.Add(this.lblExistingUsers);
            this.Controls.Add(this.lblObjectCategories);
            this.Controls.Add(this.dgvObjectCategories);
            this.Controls.Add(this.btnDeleteAllCategoreisFromObject);
            this.Controls.Add(this.btnAddAllCategoriesToObject);
            this.Controls.Add(this.btnDeleteCategoryFromObject);
            this.Controls.Add(this.btnAddCategoryToObject);
            this.Controls.Add(this.dgvExistingCategories);
            this.Controls.Add(this.lblExistingCategories);
            this.Controls.Add(this.pbOverview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnFileChoice);
            this.Controls.Add(this.tbObjectDescription);
            this.Controls.Add(this.lblObjectDescription);
            this.Controls.Add(this.tbObjectName);
            this.Controls.Add(this.lblObjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreatingObjectForm";
            this.Text = "Создание объекта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatingObjectForm_FormClosing);
            this.Load += new System.EventHandler(this.CreatingObjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCollections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectName;
        private System.Windows.Forms.TextBox tbObjectName;
        private System.Windows.Forms.Label lblObjectDescription;
        private System.Windows.Forms.TextBox tbObjectDescription;
        private System.Windows.Forms.Button btnFileChoice;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbOverview;
        private System.Windows.Forms.Label lblExistingCategories;
        private System.Windows.Forms.Button btnAddCategoryToObject;
        private System.Windows.Forms.Button btnDeleteCategoryFromObject;
        private System.Windows.Forms.Button btnAddAllCategoriesToObject;
        private System.Windows.Forms.Button btnDeleteAllCategoreisFromObject;
        private System.Windows.Forms.Label lblObjectCategories;
        private System.Windows.Forms.Label lblObjectAuthors;
        private System.Windows.Forms.Button btnDeleteAllAuthorsFromObject;
        private System.Windows.Forms.Button btnAddAllAuthorsToObject;
        private System.Windows.Forms.Button btnDeleteAuthorFromObject;
        private System.Windows.Forms.Button btnAddAuthorToObject;
        private System.Windows.Forms.Label lblExistingUsers;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblObjectCollections;
        private System.Windows.Forms.Button btnDeleteCollectionsFromObject;
        private System.Windows.Forms.Button btnAddAllCollectionsToObject;
        private System.Windows.Forms.Button btnDeleteCollectionFromObject;
        private System.Windows.Forms.Button btnAddCollectionToObject;
        private System.Windows.Forms.Label lblExistingCollections;
        private System.Windows.Forms.Button btnCreateNewCategory;
        private System.Windows.Forms.Label lblCreateNewCategory;
        private System.Windows.Forms.TextBox tbCreateNewCategory;
        public System.Windows.Forms.DataGridView dgvExistingCategories;
        public System.Windows.Forms.DataGridView dgvObjectCategories;
        public System.Windows.Forms.DataGridView dgvObjectAuthors;
        public System.Windows.Forms.DataGridView dgvExistingUsers;
        public System.Windows.Forms.DataGridView dgvObjectCollections;
        public System.Windows.Forms.DataGridView dgvExistingCollections;
    }
}