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
    public partial class ProductControlAddForm : Form
    {
        ApplicationDbContext _db;
        ProductControl control = new ProductControl();

        public ProductControlAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            control.Place = txtControl.Text;
            control.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.ProductControls.Add(control);
            _db.SaveChanges();
            txtControl.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductControlForm frmControl = new ProductControlForm();
            this.Close();
            frmControl.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductListForm list = new ProductListForm();
            this.Close();
            list.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm frmControl = new ControlForm();
            this.Close();
            frmControl.Show();
        }
    }
}
