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
    public partial class EmployeeAddForm : Form
    {
        ApplicationDbContext _db;
        Employee emp = new Employee();

        public EmployeeAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtPicUrl.Clear();
            txtPhone.Clear();
            txtNameSurname.Clear();
            txtMail.Clear();
            richTextBox1.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeEditForm edit = new EmployeeEditForm();
            this.Close();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picEmployee.ImageLocation = openFileDialog1.FileName;
            txtPicUrl.Text = openFileDialog1.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            emp.NameSurname = txtNameSurname.Text;
            emp.Address = richTextBox1.Text;
            emp.MailAddress = txtMail.Text;
            emp.PhoneNumber = txtPhone.Text;
            emp.Photo = txtPicUrl.Text;
            emp.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Employees.Add(emp);
            _db.SaveChanges();
            Clear();
        }
    }
}
