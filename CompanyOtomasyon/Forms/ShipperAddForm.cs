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
    public partial class ShipperAddForm : Form
    {
        ApplicationDbContext _db;
        Shipper ship = new Shipper();

        public ShipperAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtCountry.Clear();
            txtMail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtProvince.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ship.Country = txtCountry.Text;
            ship.MailAddress = txtMail.Text;
            ship.Name = txtName.Text;
            ship.PhoneNumber = txtPhone.Text;
            ship.Province = txtProvince.Text;
            ship.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Shippers.Add(ship);
            _db.SaveChanges();
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShipperEditForm edit = new ShipperEditForm();
            this.Close();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }
    }
}
