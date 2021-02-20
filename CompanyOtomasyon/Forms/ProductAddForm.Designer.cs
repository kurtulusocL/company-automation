namespace CompanyOtomasyon.Forms
{
    partial class ProductAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numKDV = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbControl = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProductControl = new System.Windows.Forms.Button();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Name = "label1";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbCategory, "cmbCategory");
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Name = "cmbCategory";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Name = "label2";
            // 
            // numKDV
            // 
            resources.ApplyResources(this.numKDV, "numKDV");
            this.numKDV.Name = "numKDV";
            this.numKDV.ValueChanged += new System.EventHandler(this.numKDV_ValueChanged);
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Name = "label5";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // btnHesap
            // 
            resources.ApplyResources(this.btnHesap, "btnHesap");
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQuantity.Name = "lblQuantity";
            // 
            // lblKdv
            // 
            resources.ApplyResources(this.lblKdv, "lblKdv");
            this.lblKdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKdv.Name = "lblKdv";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Name = "label6";
            // 
            // txtTotalPrice
            // 
            resources.ApplyResources(this.txtTotalPrice, "txtTotalPrice");
            this.txtTotalPrice.Name = "txtTotalPrice";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Name = "label7";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbEmployee, "cmbEmployee");
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Name = "cmbEmployee";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Name = "label8";
            // 
            // cmbControl
            // 
            this.cmbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbControl, "cmbControl");
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Name = "cmbControl";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Name = "label9";
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnProductControl
            // 
            resources.ApplyResources(this.btnProductControl, "btnProductControl");
            this.btnProductControl.Name = "btnProductControl";
            this.btnProductControl.UseVisualStyleBackColor = true;
            this.btnProductControl.Click += new System.EventHandler(this.btnProductControl_Click);
            // 
            // radioYes
            // 
            resources.ApplyResources(this.radioYes, "radioYes");
            this.radioYes.Name = "radioYes";
            this.radioYes.TabStop = true;
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            resources.ApplyResources(this.radioNo, "radioNo");
            this.radioNo.Name = "radioNo";
            this.radioNo.TabStop = true;
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // ProductAddForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProductControl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblKdv);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.numKDV);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbControl);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ProductAddForm";
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKDV;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProductControl;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
    }
}