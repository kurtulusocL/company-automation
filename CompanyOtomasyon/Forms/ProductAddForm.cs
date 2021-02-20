using CompanyOtomasyon.Data;
using CompanyOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyOtomasyon.Forms
{
    public partial class ProductAddForm : Form
    {
        ApplicationDbContext _db;
        Product pro = new Product();

        public ProductAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtTotalPrice.Clear();
            btnHesap.Text = "Ürünün toplam fiyatını hesapla";
            lblKdv.Text = "xxx";
            lblQuantity.Text = "xxx";
            numKDV.Value = 1;
            numQuantity.Value = 1;
            radioYes.Checked = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductEditForm edit = new ProductEditForm();
            this.Close();
            edit.Show();
        }

        private void btnProductControl_Click(object sender, EventArgs e)
        {
            ProductControlForm control = new ProductControlForm();
            this.Close();
            control.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            var price = Convert.ToDecimal(txtPrice.Text);
            var result = (price * Convert.ToInt32(lblKdv.Text) * Convert.ToInt32(lblQuantity.Text)) / 100;
            btnHesap.Text = "Toplam Fiyat " + result.ToString() + " " + "TL";
            txtTotalPrice.Text = result.ToString();
        }

        private void numKDV_ValueChanged(object sender, EventArgs e)
        {
            lblKdv.Text = Convert.ToInt32(numKDV.Value).ToString();
            lblKdv.ForeColor = Color.DarkGreen;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblQuantity.Text = Convert.ToInt32(numQuantity.Value).ToString();
            lblQuantity.ForeColor = Color.DarkGreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pro.Name = txtName.Text;
            pro.Quantity = Convert.ToInt32(lblQuantity.Text);
            pro.KDV = Convert.ToInt32(lblKdv.Text);
            pro.Price = Convert.ToDecimal(txtPrice.Text);
            pro.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            pro.CategoryId = (int)cmbCategory.SelectedValue;
            pro.ProductControlId = (int)cmbControl.SelectedValue;
            pro.EmployeeId = (int)cmbEmployee.SelectedValue;
            pro.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (pro.IsRepo = radioYes.Checked)
            {
                radioYes.Text = pro.IsRepo.ToString();
            }
            else
            {
                radioNo.Text = pro.IsRepo.ToString();
            }

            _db.Products.Add(pro);
            _db.SaveChanges();
            Clear();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            radioYes.Checked = true;

            cmbCategory.DataSource = _db.Categories.Include("Products").OrderByDescending(i => i.Products.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            cmbControl.DataSource = _db.ProductControls.Include("Products").OrderByDescending(i => i.Products.Count()).ToList();
            cmbControl.ValueMember = "Id";
            cmbControl.DisplayMember = "Place";

            cmbEmployee.DataSource = _db.Employees.Include("Products").Include("Orders").OrderByDescending(i => i.Products.Count()).ToList();
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "NameSurname";
        }
    }
}
