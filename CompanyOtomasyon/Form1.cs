using CompanyOtomasyon.Data;
using CompanyOtomasyon.Forms;
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

namespace CompanyOtomasyon
{
    public partial class Form1 : Form
    {
        ApplicationDbContext _db;
        SetPassword login = new SetPassword();
        ControlForm control = new ControlForm();

        public Form1()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtPassword.Clear();
            txtUserName.Clear();
            cmbRole.SelectedValue = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            login = _db.SetPasswords.Include("Role").FirstOrDefault(i => i.Id == (int)cmbRole.SelectedValue);

            if ((login.Username == txtUserName.Text) && (login.Password == txtPassword.Text) && (login.RoleId == (int)cmbRole.SelectedValue))
            {
               
                control.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgilerinizde hata vardır. Lütfen bilgilerinizi kontrol ederek tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = _db.Roles.Include("SetPasswords").OrderBy(i => i.SetPasswords.Count()).ToList();
            cmbRole.ValueMember = "Id";
            cmbRole.DisplayMember = "RolName";
        }
    }
}
