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
    public partial class ProductControlForm : Form
    {
        ApplicationDbContext _db;
        ProductControl control = new ProductControl();

        public ProductControlForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtCatename.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridProControl.DataSource = _db.ProductControls.Include("Products").Select(i => new
            {
                i.Id,
                i.Place,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridProControl.DataSource = _db.ProductControls.Include("Products").Select(i => new
            {
                i.Id,
                i.Place,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void ProductControlForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridProControl.DataSource = _db.ProductControls.Include("Products").Select(i => new
            {
                i.Id,
                i.Place,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.Place.Contains(txtSearch.Text)).ToList();
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

        private void radioControl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioControl.Checked)
            {
                dtGridProControl.DataSource = _db.ProductControls.Include("Products").Select(i => new
                {
                    i.Id,
                    i.Place,
                    Products = i.Products.Count(),
                    i.CreatedDate,
                    i.UpdatedDate
                }).OrderBy(i => i.Place).ToList();
            }
        }

        private void radioProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProduct.Checked)
            {
                dtGridProControl.DataSource = _db.ProductControls.Include("Products").Select(i => new
                {
                    i.Id,
                    i.Place,
                    Products = i.Products.Count(),
                    i.CreatedDate,
                    i.UpdatedDate
                }).OrderBy(i => i.Products).ToList();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductControlAddForm add = new ProductControlAddForm();
            this.Close();
            add.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductListForm list = new ProductListForm();
            this.Close();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void dtGridProControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridProControl.CurrentRow;
            txtCatename.Text = row.Cells["Place"].Value.ToString();
            txtCatename.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var controlId = (int)txtCatename.Tag;
            control = _db.ProductControls.FirstOrDefault(i => i.Id == controlId);

            control.Place = txtCatename.Text;
            control.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var controlId = (int)dtGridProControl.CurrentRow.Cells["Id"].Value;
            control = _db.ProductControls.FirstOrDefault(i => i.Id == controlId);

            _db.ProductControls.Remove(control);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}
