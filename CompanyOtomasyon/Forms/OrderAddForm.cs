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
    public partial class OrderAddForm : Form
    {
        ApplicationDbContext _db;
        Order order = new Order();
        Customer cust = new Customer();
        Product pro = new Product();

        public OrderAddForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtCity.Clear();
            txtCountry.Clear();
            txtNameSurname.Clear();
            txtOrderNo.Clear();
            txtProvince.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtFax.Clear();
            txtCompanyName.Clear();
            txtTotalPrice.Clear();
            txtPrice.Clear();
            txtSearch.Clear();
            btnTotalPrice.Text = "Toplam Fiyat İçin Tıklayınız";
            cmbEmployee.SelectedValue = 1;
            cmbOrderCont.SelectedValue = "";
            cmbShip.SelectedValue = "";
            rdbYes.Checked = true;
            dtPicArrivingdate.ResetText();
            dtPicOrderdate.ResetText();
            dtPicShipdate.ResetText();
            numQuantity.Value = 1;
            lstOrder.Items.Clear();
            lblQuantity.Text = "";
        }

        void ProductList()
        {
            dataGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
            {
                i.Id,
                i.Name,
                i.Quantity,
                i.KDV,
                i.Price,
                i.TotalPrice,
                Orders = i.Orders.Count(),
                i.IsRepo,
                Stocks = i.Stocks.Count(),
                Category = i.Category.Name,
                i.Employee.NameSurname,
                i.ProductControl.Place,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId,
                i.EmployeeId,
                i.ProductControlId
            }).Where(i => i.IsRepo == true && i.Quantity != 0 && i.Stocks > 0).OrderByDescending(i => i.CreatedDate).ToList();
        }

        private void OrderAddForm_Load(object sender, EventArgs e)
        {
            ProductList();

            cmbShip.DataSource = _db.Shippers.Include("Orders").OrderBy(i => i.Orders.Count()).ToList();
            cmbShip.ValueMember = "Id";
            cmbShip.DisplayMember = "Name";

            cmbOrderCont.DataSource = _db.OrderControls.Include("Orders").OrderBy(i => i.Orders.Count()).ToList();
            cmbOrderCont.ValueMember = "Id";
            cmbOrderCont.DisplayMember = "Place";

            cmbEmployee.DataSource = _db.Employees.Include("Orders").Include("Products").OrderBy(i => i.Orders.Count()).ToList();
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "NameSurname";
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblQuantity.Text = Convert.ToInt32(numQuantity.Value).ToString();
            lblQuantity.ForeColor = Color.DarkGreen;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            var price = Convert.ToDecimal(txtPrice.Text);
            var result = (price * Convert.ToInt32(lblQuantity.Text));
            btnTotalPrice.Text = "Toplam Fiyat " + result.ToString() + " " + "TL";
            txtTotalPrice.Text = result.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OrderEditForm edit = new OrderEditForm();
            this.Close();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (dataGridProduct.CurrentRow == null) return;
            DataGridViewRow row = dataGridProduct.CurrentRow;
            ListViewItem sprs = new ListViewItem();

            sprs.Text = row.Cells["Name"].Value.ToString();            
            sprs.SubItems.Add(Convert.ToInt32(numQuantity.Value).ToString());
            sprs.SubItems.Add(txtPrice.Text);
            sprs.SubItems.Add(txtTotalPrice.Text);
            //sprs.Tag = row.Cells["ProductId"].Value;

            lstOrder.Items.Add(sprs);            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstOrder.Items)
            {
                order.ProductId = pro.Id;

                order.ProductId = (int)item.Tag;
                //order.ProductId = int.Parse(item.SubItems[1].Text);
                order.Quantity = int.Parse(item.SubItems[1].Text);
                order.Price = decimal.Parse(item.SubItems[2].Text);
                order.TotalPrice = decimal.Parse((item.SubItems[3].Text));

                _db.Orders.Add(order);
                _db.SaveChanges();
            }

            order.OrderNumber = txtOrderNo.Text;
            order.OrderDate = Convert.ToDateTime(dtPicOrderdate.Value.ToLongDateString());
            order.ShipDate = Convert.ToDateTime(dtPicShipdate.Value.ToLongDateString());
            order.ArriveDate = Convert.ToDateTime(dtPicArrivingdate.Value.ToLongDateString());
            order.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            order.City = txtCity.Text;
            //order.Quantity = Convert.ToInt32(numQuantity.Value.ToString());
            //order.Price = Convert.ToDecimal(txtPrice.Text);
            //order.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            order.Province = txtProvince.Text;
            order.Country = txtCountry.Text;
            order.EmployeeId = (int)cmbEmployee.SelectedValue;
            order.ShipperId = (int)cmbEmployee.SelectedValue;
            order.OrderControlId = (int)cmbOrderCont.SelectedValue;
            cust.CompanyName = txtCompanyName.Text;
            cust.NameSurname = txtNameSurname.Text;
            cust.PhoneNumber = txtPhone.Text;
            cust.FaxNumber = txtFax.Text;
            cust.MailAddress = txtMail.Text;
            if (order.IsSent== rdbYes.Checked)
            {
                rdbYes.Text = order.IsSent.ToString();
            }
            else
            {
                rdbNo.Text = order.IsSent.ToString();
            }

            _db.Orders.Add(order);
            _db.Customers.Add(cust);
            _db.SaveChanges();
            Clear();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
            {
                i.Id,
                i.Name,
                i.Quantity,
                i.KDV,
                i.Price,
                i.TotalPrice,
                Orders = i.Orders.Count(),
                i.IsRepo,
                Stocks = i.Stocks.Count(),
                Category = i.Category.Name,
                i.Employee.NameSurname,
                i.ProductControl.Place,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId,
                i.EmployeeId,
                i.ProductControlId
            }).Where(i => i.IsRepo == true && i.Quantity != 0 && i.Stocks > 0 && i.Name.Contains(txtSearch.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal topla = 0;
            decimal[] toplam = new decimal[lstOrder.Items.Count];
            for (int i = 0; i < lstOrder.Items.Count; i++)
            {
                toplam[i] = Convert.ToDecimal(lstOrder.Items[i].SubItems[3].Text.ToString());
                topla = topla + toplam[i];
            }
            lblTotal.Text = Convert.ToString(topla + " " + "TL");
            lblTotal.ForeColor = Color.Maroon;
        }
    }
}
