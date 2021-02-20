namespace CompanyOtomasyon.Forms
{
    partial class ProductRepoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRepoForm));
            this.dtGridProduct = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEmploye = new System.Windows.Forms.RadioButton();
            this.radioCategory = new System.Windows.Forms.RadioButton();
            this.radioProducyName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTotalPriceOrder = new System.Windows.Forms.RadioButton();
            this.radioPriceOrder = new System.Windows.Forms.RadioButton();
            this.radioQuantityOrder = new System.Windows.Forms.RadioButton();
            this.radioCategoryOrder = new System.Windows.Forms.RadioButton();
            this.radioEmployeeOrder = new System.Windows.Forms.RadioButton();
            this.radioUpdatedOrder = new System.Windows.Forms.RadioButton();
            this.radioCreatedOrder = new System.Windows.Forms.RadioButton();
            this.radioStockOrder = new System.Windows.Forms.RadioButton();
            this.radioOrder = new System.Windows.Forms.RadioButton();
            this.radioKdvOrder = new System.Windows.Forms.RadioButton();
            this.btnExcell = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridProduct
            // 
            this.dtGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProduct.Location = new System.Drawing.Point(2, 0);
            this.dtGridProduct.Name = "dtGridProduct";
            this.dtGridProduct.Size = new System.Drawing.Size(912, 333);
            this.dtGridProduct.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEmploye);
            this.groupBox1.Controls.Add(this.radioCategory);
            this.groupBox1.Controls.Add(this.radioProducyName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 142);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // radioEmploye
            // 
            this.radioEmploye.AutoSize = true;
            this.radioEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioEmploye.Location = new System.Drawing.Point(7, 77);
            this.radioEmploye.Name = "radioEmploye";
            this.radioEmploye.Size = new System.Drawing.Size(156, 19);
            this.radioEmploye.TabIndex = 2;
            this.radioEmploye.TabStop = true;
            this.radioEmploye.Text = "Çalışan Ad-Soyad İle";
            this.radioEmploye.UseVisualStyleBackColor = true;
            // 
            // radioCategory
            // 
            this.radioCategory.AutoSize = true;
            this.radioCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCategory.Location = new System.Drawing.Point(7, 52);
            this.radioCategory.Name = "radioCategory";
            this.radioCategory.Size = new System.Drawing.Size(144, 19);
            this.radioCategory.TabIndex = 1;
            this.radioCategory.TabStop = true;
            this.radioCategory.Text = "Ürün Kategorisi İle";
            this.radioCategory.UseVisualStyleBackColor = true;
            // 
            // radioProducyName
            // 
            this.radioProducyName.AutoSize = true;
            this.radioProducyName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioProducyName.Location = new System.Drawing.Point(7, 29);
            this.radioProducyName.Name = "radioProducyName";
            this.radioProducyName.Size = new System.Drawing.Size(99, 19);
            this.radioProducyName.TabIndex = 0;
            this.radioProducyName.TabStop = true;
            this.radioProducyName.Text = "Ürün Adı İle";
            this.radioProducyName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(28, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 21);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTotalPriceOrder);
            this.groupBox2.Controls.Add(this.radioPriceOrder);
            this.groupBox2.Controls.Add(this.radioQuantityOrder);
            this.groupBox2.Controls.Add(this.radioCategoryOrder);
            this.groupBox2.Controls.Add(this.radioEmployeeOrder);
            this.groupBox2.Controls.Add(this.radioUpdatedOrder);
            this.groupBox2.Controls.Add(this.radioCreatedOrder);
            this.groupBox2.Controls.Add(this.radioStockOrder);
            this.groupBox2.Controls.Add(this.radioOrder);
            this.groupBox2.Controls.Add(this.radioKdvOrder);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(287, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 157);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sıralama Yap";
            // 
            // radioTotalPriceOrder
            // 
            this.radioTotalPriceOrder.AutoSize = true;
            this.radioTotalPriceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioTotalPriceOrder.Location = new System.Drawing.Point(7, 102);
            this.radioTotalPriceOrder.Name = "radioTotalPriceOrder";
            this.radioTotalPriceOrder.Size = new System.Drawing.Size(149, 19);
            this.radioTotalPriceOrder.TabIndex = 3;
            this.radioTotalPriceOrder.TabStop = true;
            this.radioTotalPriceOrder.Text = "Toplam Fiyata Göre";
            this.radioTotalPriceOrder.UseVisualStyleBackColor = true;
            this.radioTotalPriceOrder.CheckedChanged += new System.EventHandler(this.radioTotalPriceOrder_CheckedChanged);
            // 
            // radioPriceOrder
            // 
            this.radioPriceOrder.AutoSize = true;
            this.radioPriceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioPriceOrder.Location = new System.Drawing.Point(7, 77);
            this.radioPriceOrder.Name = "radioPriceOrder";
            this.radioPriceOrder.Size = new System.Drawing.Size(145, 19);
            this.radioPriceOrder.TabIndex = 2;
            this.radioPriceOrder.TabStop = true;
            this.radioPriceOrder.Text = "Tane Fiyatına Göre";
            this.radioPriceOrder.UseVisualStyleBackColor = true;
            this.radioPriceOrder.CheckedChanged += new System.EventHandler(this.radioPriceOrder_CheckedChanged);
            // 
            // radioQuantityOrder
            // 
            this.radioQuantityOrder.AutoSize = true;
            this.radioQuantityOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioQuantityOrder.Location = new System.Drawing.Point(7, 52);
            this.radioQuantityOrder.Name = "radioQuantityOrder";
            this.radioQuantityOrder.Size = new System.Drawing.Size(107, 19);
            this.radioQuantityOrder.TabIndex = 1;
            this.radioQuantityOrder.TabStop = true;
            this.radioQuantityOrder.Text = "Miktara Göre";
            this.radioQuantityOrder.UseVisualStyleBackColor = true;
            this.radioQuantityOrder.CheckedChanged += new System.EventHandler(this.radioQuantityOrder_CheckedChanged);
            // 
            // radioCategoryOrder
            // 
            this.radioCategoryOrder.AutoSize = true;
            this.radioCategoryOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCategoryOrder.Location = new System.Drawing.Point(201, 129);
            this.radioCategoryOrder.Name = "radioCategoryOrder";
            this.radioCategoryOrder.Size = new System.Drawing.Size(153, 19);
            this.radioCategoryOrder.TabIndex = 10;
            this.radioCategoryOrder.TabStop = true;
            this.radioCategoryOrder.Text = "Kategori Adına Göre";
            this.radioCategoryOrder.UseVisualStyleBackColor = true;
            this.radioCategoryOrder.CheckedChanged += new System.EventHandler(this.radioCategoryOrder_CheckedChanged);
            // 
            // radioEmployeeOrder
            // 
            this.radioEmployeeOrder.AutoSize = true;
            this.radioEmployeeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioEmployeeOrder.Location = new System.Drawing.Point(201, 102);
            this.radioEmployeeOrder.Name = "radioEmployeeOrder";
            this.radioEmployeeOrder.Size = new System.Drawing.Size(147, 19);
            this.radioEmployeeOrder.TabIndex = 8;
            this.radioEmployeeOrder.TabStop = true;
            this.radioEmployeeOrder.Text = "Çalışan Adına Göre";
            this.radioEmployeeOrder.UseVisualStyleBackColor = true;
            this.radioEmployeeOrder.CheckedChanged += new System.EventHandler(this.radioEmployeeOrder_CheckedChanged);
            // 
            // radioUpdatedOrder
            // 
            this.radioUpdatedOrder.AutoSize = true;
            this.radioUpdatedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioUpdatedOrder.Location = new System.Drawing.Point(201, 77);
            this.radioUpdatedOrder.Name = "radioUpdatedOrder";
            this.radioUpdatedOrder.Size = new System.Drawing.Size(201, 19);
            this.radioUpdatedOrder.TabIndex = 7;
            this.radioUpdatedOrder.TabStop = true;
            this.radioUpdatedOrder.Text = "Güncellenme Tarihine Göre";
            this.radioUpdatedOrder.UseVisualStyleBackColor = true;
            this.radioUpdatedOrder.CheckedChanged += new System.EventHandler(this.radioUpdatedOrder_CheckedChanged);
            // 
            // radioCreatedOrder
            // 
            this.radioCreatedOrder.AutoSize = true;
            this.radioCreatedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCreatedOrder.Location = new System.Drawing.Point(201, 52);
            this.radioCreatedOrder.Name = "radioCreatedOrder";
            this.radioCreatedOrder.Size = new System.Drawing.Size(147, 19);
            this.radioCreatedOrder.TabIndex = 6;
            this.radioCreatedOrder.TabStop = true;
            this.radioCreatedOrder.Text = "Kayıt Tarihine Göre";
            this.radioCreatedOrder.UseVisualStyleBackColor = true;
            this.radioCreatedOrder.CheckedChanged += new System.EventHandler(this.radioCreatedOrder_CheckedChanged);
            // 
            // radioStockOrder
            // 
            this.radioStockOrder.AutoSize = true;
            this.radioStockOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioStockOrder.Location = new System.Drawing.Point(201, 27);
            this.radioStockOrder.Name = "radioStockOrder";
            this.radioStockOrder.Size = new System.Drawing.Size(145, 19);
            this.radioStockOrder.TabIndex = 5;
            this.radioStockOrder.TabStop = true;
            this.radioStockOrder.Text = "Stok Sayısına Göre";
            this.radioStockOrder.UseVisualStyleBackColor = true;
            this.radioStockOrder.CheckedChanged += new System.EventHandler(this.radioStockOrder_CheckedChanged);
            // 
            // radioOrder
            // 
            this.radioOrder.AutoSize = true;
            this.radioOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioOrder.Location = new System.Drawing.Point(7, 127);
            this.radioOrder.Name = "radioOrder";
            this.radioOrder.Size = new System.Drawing.Size(162, 19);
            this.radioOrder.TabIndex = 4;
            this.radioOrder.TabStop = true;
            this.radioOrder.Text = "Sipariş Sayısına Göre";
            this.radioOrder.UseVisualStyleBackColor = true;
            this.radioOrder.CheckedChanged += new System.EventHandler(this.radioOrder_CheckedChanged);
            // 
            // radioKdvOrder
            // 
            this.radioKdvOrder.AutoSize = true;
            this.radioKdvOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioKdvOrder.Location = new System.Drawing.Point(7, 27);
            this.radioKdvOrder.Name = "radioKdvOrder";
            this.radioKdvOrder.Size = new System.Drawing.Size(104, 19);
            this.radioKdvOrder.TabIndex = 0;
            this.radioKdvOrder.TabStop = true;
            this.radioKdvOrder.Text = "KDV\'ye Göre";
            this.radioKdvOrder.UseVisualStyleBackColor = true;
            this.radioKdvOrder.CheckedChanged += new System.EventHandler(this.radioKdvOrder_CheckedChanged);
            // 
            // btnExcell
            // 
            this.btnExcell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcell.BackgroundImage")));
            this.btnExcell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcell.Location = new System.Drawing.Point(825, 403);
            this.btnExcell.Name = "btnExcell";
            this.btnExcell.Size = new System.Drawing.Size(48, 42);
            this.btnExcell.TabIndex = 30;
            this.btnExcell.UseVisualStyleBackColor = true;
            this.btnExcell.Click += new System.EventHandler(this.btnExcell_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(771, 403);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(48, 42);
            this.btnPdf.TabIndex = 29;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(855, 355);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 42);
            this.btnHome.TabIndex = 28;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(747, 354);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 42);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Location = new System.Drawing.Point(801, 354);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(48, 42);
            this.btnList.TabIndex = 31;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // ProductRepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(912, 508);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnExcell);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductRepoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depodaki ve Stoktaki Ürünlerin Listesi";
            this.Load += new System.EventHandler(this.ProductRepoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEmploye;
        private System.Windows.Forms.RadioButton radioCategory;
        private System.Windows.Forms.RadioButton radioProducyName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTotalPriceOrder;
        private System.Windows.Forms.RadioButton radioPriceOrder;
        private System.Windows.Forms.RadioButton radioQuantityOrder;
        private System.Windows.Forms.RadioButton radioCategoryOrder;
        private System.Windows.Forms.RadioButton radioEmployeeOrder;
        private System.Windows.Forms.RadioButton radioUpdatedOrder;
        private System.Windows.Forms.RadioButton radioCreatedOrder;
        private System.Windows.Forms.RadioButton radioStockOrder;
        private System.Windows.Forms.RadioButton radioOrder;
        private System.Windows.Forms.RadioButton radioKdvOrder;
        private System.Windows.Forms.Button btnExcell;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnList;
    }
}