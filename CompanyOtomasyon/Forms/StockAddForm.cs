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
    public partial class StockAddForm : Form
    {
        ApplicationDbContext _db;
        Stock stok = new Stock();

        public StockAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            numStok.Value = 1;
            cmbProduct.SelectedValue = "";
        }

        private void StockAddForm_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").OrderBy(i => i.Orders.Count()).ToList();
            cmbProduct.ValueMember = "Id";
            cmbProduct.DisplayMember = "Name";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StockForm edit = new StockForm();
            this.Close();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stok.StockName = txtName.Text;
            stok.Quantity = Convert.ToInt32(numStok.Value);
            stok.ProductId = (int)cmbProduct.SelectedValue;
            stok.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Stocks.Add(stok);
            _db.SaveChanges();
            Clear();
        }
    }
}
