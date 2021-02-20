namespace CompanyOtomasyon.Forms
{
    partial class ProductEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditForm));
            this.dtGridProduct = new System.Windows.Forms.DataGridView();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numKDV = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cmbControl = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEmploye = new System.Windows.Forms.RadioButton();
            this.radioCategory = new System.Windows.Forms.RadioButton();
            this.radioProducyName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProductControl = new System.Windows.Forms.Button();
            this.btnExcell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridProduct
            // 
            this.dtGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProduct.Location = new System.Drawing.Point(0, 0);
            this.dtGridProduct.Name = "dtGridProduct";
            this.dtGridProduct.Size = new System.Drawing.Size(885, 310);
            this.dtGridProduct.TabIndex = 0;
            this.dtGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProduct_CellClick);
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F, System.Drawing.FontStyle.Bold);
            this.lblKdv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKdv.Location = new System.Drawing.Point(282, 376);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(28, 15);
            this.lblKdv.TabIndex = 16;
            this.lblKdv.Text = "xxx";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQuantity.Location = new System.Drawing.Point(282, 403);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(28, 15);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "xxx";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.numQuantity.Location = new System.Drawing.Point(106, 399);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(170, 21);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // numKDV
            // 
            this.numKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.numKDV.Location = new System.Drawing.Point(106, 372);
            this.numKDV.Name = "numKDV";
            this.numKDV.Size = new System.Drawing.Size(170, 21);
            this.numKDV.TabIndex = 3;
            this.numKDV.ValueChanged += new System.EventHandler(this.numKDV_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.txtPrice.Location = new System.Drawing.Point(106, 426);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.txtName.Location = new System.Drawing.Point(106, 345);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 21);
            this.txtName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(106, 316);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(170, 23);
            this.cmbCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(8, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "KDV Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Kategorisi";
            // 
            // btnHesap
            // 
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F);
            this.btnHesap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHesap.Location = new System.Drawing.Point(24, 480);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(252, 23);
            this.btnHesap.TabIndex = 7;
            this.btnHesap.Text = "Ürün Toplam Fiyatını Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.radioNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioNo.Location = new System.Drawing.Point(506, 321);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(52, 19);
            this.radioNo.TabIndex = 10;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Hayır";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.radioYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioYes.Location = new System.Drawing.Point(432, 321);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(47, 19);
            this.radioYes.TabIndex = 9;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Evet";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.txtTotalPrice.Location = new System.Drawing.Point(106, 453);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(170, 21);
            this.txtTotalPrice.TabIndex = 8;
            // 
            // cmbControl
            // 
            this.cmbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(418, 375);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(170, 23);
            this.cmbControl.TabIndex = 12;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(418, 346);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(170, 23);
            this.cmbEmployee.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(8, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Toplam Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(320, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ürünün Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(320, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "İşlemi Yapan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(320, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ürün Depoda";
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(486, 461);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(48, 42);
            this.btnPdf.TabIndex = 19;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(378, 461);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 42);
            this.btnHome.TabIndex = 18;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(486, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Location = new System.Drawing.Point(432, 413);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(48, 42);
            this.btnList.TabIndex = 16;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(378, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 42);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(324, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(48, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEmploye);
            this.groupBox1.Controls.Add(this.radioCategory);
            this.groupBox1.Controls.Add(this.radioProducyName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(622, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 139);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // radioEmploye
            // 
            this.radioEmploye.AutoSize = true;
            this.radioEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioEmploye.Location = new System.Drawing.Point(13, 82);
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
            this.radioCategory.Location = new System.Drawing.Point(13, 57);
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
            this.radioProducyName.Location = new System.Drawing.Point(13, 34);
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
            this.txtSearch.Location = new System.Drawing.Point(33, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 21);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnProductControl
            // 
            this.btnProductControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductControl.BackgroundImage")));
            this.btnProductControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductControl.Location = new System.Drawing.Point(540, 413);
            this.btnProductControl.Name = "btnProductControl";
            this.btnProductControl.Size = new System.Drawing.Size(48, 42);
            this.btnProductControl.TabIndex = 17;
            this.btnProductControl.UseVisualStyleBackColor = true;
            this.btnProductControl.Click += new System.EventHandler(this.btnProductControl_Click);
            // 
            // btnExcell
            // 
            this.btnExcell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcell.BackgroundImage")));
            this.btnExcell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcell.Location = new System.Drawing.Point(432, 461);
            this.btnExcell.Name = "btnExcell";
            this.btnExcell.Size = new System.Drawing.Size(48, 42);
            this.btnExcell.TabIndex = 19;
            this.btnExcell.UseVisualStyleBackColor = true;
            this.btnExcell.Click += new System.EventHandler(this.btnExcell_Click);
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(885, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcell);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProductControl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.cmbControl);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lblKdv);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.numKDV);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi ve Ürün Bilgi Güncelleme Formu";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProduct;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numKDV;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cmbControl;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioProducyName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioCategory;
        private System.Windows.Forms.RadioButton radioEmploye;
        private System.Windows.Forms.Button btnProductControl;
        private System.Windows.Forms.Button btnExcell;
    }
}