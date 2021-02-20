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
    public partial class CategoryAdd : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cate.Name = txtCatename.Text;
            cate.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Categories.Add(cate);
            _db.SaveChanges();
            txtCatename.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryForm frmCate = new CategoryForm();
            this.Hide();
            frmCate.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }
    }
}
