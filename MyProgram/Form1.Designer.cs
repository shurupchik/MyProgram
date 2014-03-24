namespace MyProgram
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBoxStorage = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.btnZakMerch = new System.Windows.Forms.Button();
            this.btnPerMerch = new System.Windows.Forms.Button();
            this.dGVStateBranch = new System.Windows.Forms.DataGridView();
            this.labelMerchBranch = new System.Windows.Forms.Label();
            this.cbChooseBranch = new System.Windows.Forms.ComboBox();
            this.gBoxReport = new System.Windows.Forms.GroupBox();
            this.btnReportMan = new System.Windows.Forms.Button();
            this.btnReportSale = new System.Windows.Forms.Button();
            this.btnReportProv = new System.Windows.Forms.Button();
            this.btnReportMerch = new System.Windows.Forms.Button();
            this.gBoxTables = new System.Windows.Forms.GroupBox();
            this.btnListMerch = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProvisioner = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.gBoxImage = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxEmblem = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStateBranch)).BeginInit();
            this.gBoxReport.SuspendLayout();
            this.gBoxTables.SuspendLayout();
            this.gBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxStorage
            // 
            this.gBoxStorage.Controls.Add(this.add);
            this.gBoxStorage.Controls.Add(this.btnZakMerch);
            this.gBoxStorage.Controls.Add(this.btnPerMerch);
            this.gBoxStorage.Controls.Add(this.dGVStateBranch);
            this.gBoxStorage.Controls.Add(this.labelMerchBranch);
            this.gBoxStorage.Controls.Add(this.cbChooseBranch);
            this.gBoxStorage.Location = new System.Drawing.Point(291, 3);
            this.gBoxStorage.Name = "gBoxStorage";
            this.gBoxStorage.Size = new System.Drawing.Size(569, 527);
            this.gBoxStorage.TabIndex = 7;
            this.gBoxStorage.TabStop = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(136, 497);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // btnZakMerch
            // 
            this.btnZakMerch.Location = new System.Drawing.Point(393, 485);
            this.btnZakMerch.Name = "btnZakMerch";
            this.btnZakMerch.Size = new System.Drawing.Size(170, 35);
            this.btnZakMerch.TabIndex = 4;
            this.btnZakMerch.Text = "Заказать товар";
            this.btnZakMerch.UseVisualStyleBackColor = true;
            // 
            // btnPerMerch
            // 
            this.btnPerMerch.Location = new System.Drawing.Point(217, 485);
            this.btnPerMerch.Name = "btnPerMerch";
            this.btnPerMerch.Size = new System.Drawing.Size(170, 35);
            this.btnPerMerch.TabIndex = 3;
            this.btnPerMerch.Text = "Перераспределить товар";
            this.btnPerMerch.UseVisualStyleBackColor = true;
            // 
            // dGVStateBranch
            // 
            this.dGVStateBranch.AllowUserToAddRows = false;
            this.dGVStateBranch.AllowUserToDeleteRows = false;
            this.dGVStateBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStateBranch.Location = new System.Drawing.Point(6, 69);
            this.dGVStateBranch.Name = "dGVStateBranch";
            this.dGVStateBranch.ReadOnly = true;
            this.dGVStateBranch.Size = new System.Drawing.Size(557, 411);
            this.dGVStateBranch.TabIndex = 2;
            // 
            // labelMerchBranch
            // 
            this.labelMerchBranch.AutoSize = true;
            this.labelMerchBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMerchBranch.Location = new System.Drawing.Point(29, 20);
            this.labelMerchBranch.Name = "labelMerchBranch";
            this.labelMerchBranch.Size = new System.Drawing.Size(215, 20);
            this.labelMerchBranch.TabIndex = 1;
            this.labelMerchBranch.Text = "Наличие товара на складе";
            // 
            // cbChooseBranch
            // 
            this.cbChooseBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbChooseBranch.FormattingEnabled = true;
            this.cbChooseBranch.Location = new System.Drawing.Point(295, 19);
            this.cbChooseBranch.Name = "cbChooseBranch";
            this.cbChooseBranch.Size = new System.Drawing.Size(191, 28);
            this.cbChooseBranch.TabIndex = 0;
            this.cbChooseBranch.Text = "Выберете филиал";
            // 
            // gBoxReport
            // 
            this.gBoxReport.Controls.Add(this.btnReportMan);
            this.gBoxReport.Controls.Add(this.btnReportSale);
            this.gBoxReport.Controls.Add(this.btnReportProv);
            this.gBoxReport.Controls.Add(this.btnReportMerch);
            this.gBoxReport.Location = new System.Drawing.Point(12, 371);
            this.gBoxReport.Name = "gBoxReport";
            this.gBoxReport.Size = new System.Drawing.Size(273, 159);
            this.gBoxReport.TabIndex = 6;
            this.gBoxReport.TabStop = false;
            this.gBoxReport.Text = "Отчеты";
            // 
            // btnReportMan
            // 
            this.btnReportMan.Location = new System.Drawing.Point(6, 118);
            this.btnReportMan.Name = "btnReportMan";
            this.btnReportMan.Size = new System.Drawing.Size(261, 27);
            this.btnReportMan.TabIndex = 3;
            this.btnReportMan.Text = "Результативность менеджеров";
            this.btnReportMan.UseVisualStyleBackColor = true;
            // 
            // btnReportSale
            // 
            this.btnReportSale.Location = new System.Drawing.Point(6, 85);
            this.btnReportSale.Name = "btnReportSale";
            this.btnReportSale.Size = new System.Drawing.Size(261, 27);
            this.btnReportSale.TabIndex = 2;
            this.btnReportSale.Text = "Продаваемость по филиалам";
            this.btnReportSale.UseVisualStyleBackColor = true;
            // 
            // btnReportProv
            // 
            this.btnReportProv.Location = new System.Drawing.Point(6, 52);
            this.btnReportProv.Name = "btnReportProv";
            this.btnReportProv.Size = new System.Drawing.Size(261, 27);
            this.btnReportProv.TabIndex = 1;
            this.btnReportProv.Text = "Популярность поставщиков";
            this.btnReportProv.UseVisualStyleBackColor = true;
            // 
            // btnReportMerch
            // 
            this.btnReportMerch.Location = new System.Drawing.Point(6, 19);
            this.btnReportMerch.Name = "btnReportMerch";
            this.btnReportMerch.Size = new System.Drawing.Size(261, 27);
            this.btnReportMerch.TabIndex = 0;
            this.btnReportMerch.Text = "Продаваемость товара";
            this.btnReportMerch.UseVisualStyleBackColor = true;
            // 
            // gBoxTables
            // 
            this.gBoxTables.Controls.Add(this.btnListMerch);
            this.gBoxTables.Controls.Add(this.btnCategory);
            this.gBoxTables.Controls.Add(this.btnProvisioner);
            this.gBoxTables.Controls.Add(this.btnManager);
            this.gBoxTables.Controls.Add(this.btnBranch);
            this.gBoxTables.Location = new System.Drawing.Point(12, 180);
            this.gBoxTables.Name = "gBoxTables";
            this.gBoxTables.Size = new System.Drawing.Size(273, 185);
            this.gBoxTables.TabIndex = 5;
            this.gBoxTables.TabStop = false;
            // 
            // btnListMerch
            // 
            this.btnListMerch.Location = new System.Drawing.Point(6, 143);
            this.btnListMerch.Name = "btnListMerch";
            this.btnListMerch.Size = new System.Drawing.Size(261, 25);
            this.btnListMerch.TabIndex = 4;
            this.btnListMerch.Text = "Список товаров сети";
            this.btnListMerch.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(6, 112);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(261, 25);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Просмотр категорий товара";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnProvisioner
            // 
            this.btnProvisioner.Location = new System.Drawing.Point(6, 81);
            this.btnProvisioner.Name = "btnProvisioner";
            this.btnProvisioner.Size = new System.Drawing.Size(261, 25);
            this.btnProvisioner.TabIndex = 2;
            this.btnProvisioner.Text = "Просмотр поставщиков";
            this.btnProvisioner.UseVisualStyleBackColor = true;
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(6, 50);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(261, 25);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Просмотр менеджеров";
            this.btnManager.UseVisualStyleBackColor = true;
            // 
            // btnBranch
            // 
            this.btnBranch.Location = new System.Drawing.Point(6, 19);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(261, 25);
            this.btnBranch.TabIndex = 0;
            this.btnBranch.Text = "Просмотр филиалов";
            this.btnBranch.UseVisualStyleBackColor = true;
            // 
            // gBoxImage
            // 
            this.gBoxImage.Controls.Add(this.labelName);
            this.gBoxImage.Controls.Add(this.pictureBoxEmblem);
            this.gBoxImage.Location = new System.Drawing.Point(12, 3);
            this.gBoxImage.Name = "gBoxImage";
            this.gBoxImage.Size = new System.Drawing.Size(273, 171);
            this.gBoxImage.TabIndex = 4;
            this.gBoxImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(49, 155);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(169, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Сеть супермаркетов \"Магазин\"";
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxEmblem.Name = "pictureBoxEmblem";
            this.pictureBoxEmblem.Size = new System.Drawing.Size(261, 142);
            this.pictureBoxEmblem.TabIndex = 0;
            this.pictureBoxEmblem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(870, 535);
            this.Controls.Add(this.gBoxStorage);
            this.Controls.Add(this.gBoxReport);
            this.Controls.Add(this.gBoxTables);
            this.Controls.Add(this.gBoxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxStorage.ResumeLayout(false);
            this.gBoxStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStateBranch)).EndInit();
            this.gBoxReport.ResumeLayout(false);
            this.gBoxTables.ResumeLayout(false);
            this.gBoxImage.ResumeLayout(false);
            this.gBoxImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxStorage;
        private System.Windows.Forms.Button btnZakMerch;
        private System.Windows.Forms.Button btnPerMerch;
        private System.Windows.Forms.DataGridView dGVStateBranch;
        private System.Windows.Forms.Label labelMerchBranch;
        private System.Windows.Forms.ComboBox cbChooseBranch;
        private System.Windows.Forms.GroupBox gBoxReport;
        private System.Windows.Forms.Button btnReportMan;
        private System.Windows.Forms.Button btnReportSale;
        private System.Windows.Forms.Button btnReportProv;
        private System.Windows.Forms.Button btnReportMerch;
        private System.Windows.Forms.GroupBox gBoxTables;
        private System.Windows.Forms.Button btnListMerch;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProvisioner;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.GroupBox gBoxImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxEmblem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button add;
    }
}

