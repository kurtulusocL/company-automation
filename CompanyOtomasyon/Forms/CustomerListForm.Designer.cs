namespace CompanyOtomasyon.Forms
{
    partial class CustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtGridCustomerList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioPhoneNumber = new System.Windows.Forms.RadioButton();
            this.radioCompanyName = new System.Windows.Forms.RadioButton();
            this.radioNameSurname = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPhoneOrder = new System.Windows.Forms.RadioButton();
            this.radioCompanyOrder = new System.Windows.Forms.RadioButton();
            this.radioCustomerOrder = new System.Windows.Forms.RadioButton();
            this.radioFaxOrder = new System.Windows.Forms.RadioButton();
            this.radioSiparisOrder = new System.Windows.Forms.RadioButton();
            this.radioMailOrder = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustomerList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(818, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // dtGridCustomerList
            // 
            this.dtGridCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCustomerList.Location = new System.Drawing.Point(1, 0);
            this.dtGridCustomerList.Name = "dtGridCustomerList";
            this.dtGridCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCustomerList.Size = new System.Drawing.Size(865, 331);
            this.dtGridCustomerList.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.radioPhoneNumber);
            this.groupBox1.Controls.Add(this.radioCompanyName);
            this.groupBox1.Controls.Add(this.radioNameSurname);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(6, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // radioPhoneNumber
            // 
            this.radioPhoneNumber.AutoSize = true;
            this.radioPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioPhoneNumber.Location = new System.Drawing.Point(6, 86);
            this.radioPhoneNumber.Name = "radioPhoneNumber";
            this.radioPhoneNumber.Size = new System.Drawing.Size(114, 19);
            this.radioPhoneNumber.TabIndex = 2;
            this.radioPhoneNumber.TabStop = true;
            this.radioPhoneNumber.Text = "Telefon No İle";
            this.radioPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // radioCompanyName
            // 
            this.radioCompanyName.AutoSize = true;
            this.radioCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCompanyName.Location = new System.Drawing.Point(6, 61);
            this.radioCompanyName.Name = "radioCompanyName";
            this.radioCompanyName.Size = new System.Drawing.Size(105, 19);
            this.radioCompanyName.TabIndex = 1;
            this.radioCompanyName.TabStop = true;
            this.radioCompanyName.Text = "Şirket Adı İle";
            this.radioCompanyName.UseVisualStyleBackColor = true;
            // 
            // radioNameSurname
            // 
            this.radioNameSurname.AutoSize = true;
            this.radioNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNameSurname.Location = new System.Drawing.Point(6, 36);
            this.radioNameSurname.Name = "radioNameSurname";
            this.radioNameSurname.Size = new System.Drawing.Size(116, 19);
            this.radioNameSurname.TabIndex = 0;
            this.radioNameSurname.TabStop = true;
            this.radioNameSurname.Text = "Müşteri Adı İle";
            this.radioNameSurname.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFaxOrder);
            this.groupBox2.Controls.Add(this.radioPhoneOrder);
            this.groupBox2.Controls.Add(this.radioCompanyOrder);
            this.groupBox2.Controls.Add(this.radioMailOrder);
            this.groupBox2.Controls.Add(this.radioSiparisOrder);
            this.groupBox2.Controls.Add(this.radioCustomerOrder);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(268, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sıralama Yap";
            // 
            // radioPhoneOrder
            // 
            this.radioPhoneOrder.AutoSize = true;
            this.radioPhoneOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioPhoneOrder.Location = new System.Drawing.Point(6, 86);
            this.radioPhoneOrder.Name = "radioPhoneOrder";
            this.radioPhoneOrder.Size = new System.Drawing.Size(193, 19);
            this.radioPhoneOrder.TabIndex = 2;
            this.radioPhoneOrder.TabStop = true;
            this.radioPhoneOrder.Text = "Telefon Numarasuna Göre";
            this.radioPhoneOrder.UseVisualStyleBackColor = true;
            // 
            // radioCompanyOrder
            // 
            this.radioCompanyOrder.AutoSize = true;
            this.radioCompanyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCompanyOrder.Location = new System.Drawing.Point(6, 61);
            this.radioCompanyOrder.Name = "radioCompanyOrder";
            this.radioCompanyOrder.Size = new System.Drawing.Size(136, 19);
            this.radioCompanyOrder.TabIndex = 1;
            this.radioCompanyOrder.TabStop = true;
            this.radioCompanyOrder.Text = "Şirket Adına Göre";
            this.radioCompanyOrder.UseVisualStyleBackColor = true;
            // 
            // radioCustomerOrder
            // 
            this.radioCustomerOrder.AutoSize = true;
            this.radioCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCustomerOrder.Location = new System.Drawing.Point(6, 36);
            this.radioCustomerOrder.Name = "radioCustomerOrder";
            this.radioCustomerOrder.Size = new System.Drawing.Size(147, 19);
            this.radioCustomerOrder.TabIndex = 0;
            this.radioCustomerOrder.TabStop = true;
            this.radioCustomerOrder.Text = "Müşteri Adına Göre";
            this.radioCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // radioFaxOrder
            // 
            this.radioFaxOrder.AutoSize = true;
            this.radioFaxOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioFaxOrder.Location = new System.Drawing.Point(6, 111);
            this.radioFaxOrder.Name = "radioFaxOrder";
            this.radioFaxOrder.Size = new System.Drawing.Size(164, 19);
            this.radioFaxOrder.TabIndex = 3;
            this.radioFaxOrder.TabStop = true;
            this.radioFaxOrder.Text = "Fax Numarasına Göre";
            this.radioFaxOrder.UseVisualStyleBackColor = true;
            // 
            // radioSiparisOrder
            // 
            this.radioSiparisOrder.AutoSize = true;
            this.radioSiparisOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioSiparisOrder.Location = new System.Drawing.Point(229, 36);
            this.radioSiparisOrder.Name = "radioSiparisOrder";
            this.radioSiparisOrder.Size = new System.Drawing.Size(112, 19);
            this.radioSiparisOrder.TabIndex = 4;
            this.radioSiparisOrder.TabStop = true;
            this.radioSiparisOrder.Text = "Siparişe Göre";
            this.radioSiparisOrder.UseVisualStyleBackColor = true;
            // 
            // radioMailOrder
            // 
            this.radioMailOrder.AutoSize = true;
            this.radioMailOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMailOrder.Location = new System.Drawing.Point(229, 61);
            this.radioMailOrder.Name = "radioMailOrder";
            this.radioMailOrder.Size = new System.Drawing.Size(147, 19);
            this.radioMailOrder.TabIndex = 5;
            this.radioMailOrder.TabStop = true;
            this.radioMailOrder.Text = "Mail Adresine Göre";
            this.radioMailOrder.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(690, 373);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(798, 373);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(48, 42);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(744, 373);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 42);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridCustomerList);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustomerList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtGridCustomerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioPhoneNumber;
        private System.Windows.Forms.RadioButton radioCompanyName;
        private System.Windows.Forms.RadioButton radioNameSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPhoneOrder;
        private System.Windows.Forms.RadioButton radioCompanyOrder;
        private System.Windows.Forms.RadioButton radioCustomerOrder;
        private System.Windows.Forms.RadioButton radioFaxOrder;
        private System.Windows.Forms.RadioButton radioSiparisOrder;
        private System.Windows.Forms.RadioButton radioMailOrder;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
    }
}