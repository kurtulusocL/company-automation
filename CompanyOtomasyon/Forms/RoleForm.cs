using CompanyOtomasyon.Data;
using CompanyOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyOtomasyon.Forms
{
    public partial class RoleForm : Form
    {
        ApplicationDbContext _db;
        Role role = new Role();

        public RoleForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtRole.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridRole.DataSource = _db.Roles.Include("SetPasswords").Select(i => new
            {
                i.Id,
                i.RolName,
                Users = i.SetPasswords.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridRole.DataSource = _db.Roles.Include("SetPasswords").Select(i => new
            {
                i.Id,
                i.RolName,
                Users = i.SetPasswords.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridRole.DataSource = _db.Roles.Include("SetPasswords").Select(i => new
            {
                i.Id,
                i.RolName,
                Users = i.SetPasswords.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.RolName.Contains(txtSearch.Text)).ToList();
        }

        private void radioCreated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCreated.Checked)
            {
                FormLoad();
            }
        }

        private void radioUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdated.Checked)
            {
                UpdatedDate();
            }
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUser.Checked)
            {
                dtGridRole.DataSource = _db.Roles.Include("SetPasswords").Select(i => new
                {
                    i.Id,
                    i.RolName,
                    Users = i.SetPasswords.Count(),
                    i.CreatedDate,
                    i.UpdatedDate
                }).OrderBy(i => i.Users).ToList();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            PasswordAuth auth = new PasswordAuth();
            this.Close();
            auth.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            role.RolName = txtRole.Text;
            role.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Roles.Add(role);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void dtGridRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridRole.CurrentRow;
            txtRole.Text = row.Cells["RolName"].Value.ToString();
            txtRole.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var roleId = (int)txtRole.Tag;
            role = _db.Roles.FirstOrDefault(i => i.Id == roleId);

            role.RolName = txtRole.Text;
            role.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var roleId = (int)dtGridRole.CurrentRow.Cells["Id"].Value;
            role = _db.Roles.FirstOrDefault(i => i.Id == roleId);

            _db.Roles.Remove(role);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }        
    }
}
