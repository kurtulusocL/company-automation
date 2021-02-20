using CompanyOtomasyon.Data;
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
    public partial class ControlForm : Form
    {
        ApplicationDbContext _db;

        public ControlForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Istatistic()
        {
            lblAuth.Text = Convert.ToString(_db.Roles.Count());
            lblCategory.Text = Convert.ToString(_db.Categories.Count());
            lblCustomer.Text = Convert.ToString(_db.Customers.Count());
            lblEmploye.Text = Convert.ToString(_db.Employees.Count());
            lblOrder.Text = Convert.ToString(_db.Orders.Count());
            lblOrderControl.Text = Convert.ToString(_db.OrderControls.Count());
            lblProduct.Text = Convert.ToString(_db.Products.Count());
            lblProductControl.Text = Convert.ToString(_db.ProductControls.Count());
            lblShipper.Text = Convert.ToString(_db.Shippers.Count());
            lblStock.Text = Convert.ToString(_db.Stocks.Count());
            lblUser.Text = Convert.ToString(_db.SetPasswords.Count());
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            Istatistic();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Istatistic();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm pList = new ProductListForm();
            pList.Show();
        }

        private void ürünKontrolüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductControlForm pControl = new ProductControlForm();
            pControl.Show();
        }

        private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductEditForm pEdit = new ProductEditForm();
            pEdit.Show();
        }

        private void kategoriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm cForm = new CategoryForm();
            cForm.Show();
        }

        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm();
            stock.Show();
        }

        private void stokKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAddForm sAdd = new StockAddForm();
            sAdd.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListForm cList = new CustomerListForm();
            cList.Show();
        }

        private void müşteriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEditForm cEdit = new CustomerEditForm();
            cEdit.Show();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListForm oList = new OrderListForm();
            oList.Show();
        }

        private void siparişDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderControlForm oControl = new OrderControlForm();
            oControl.Show();
        }

        private void gönderilenSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderSentForm sent = new OrderSentForm();
            sent.Show();
        }

        private void bekleyenSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderUnSentForm unsent = new OrderUnSentForm();
            unsent.Show();
        }

        private void siparişDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderEditForm oEdit = new OrderEditForm();
            oEdit.Show();
        }

        private void kargoListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperListForm cForm = new ShipperListForm();
            cForm.Show();
        }

        private void kargoDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperEditForm sEdit = new ShipperEditForm();
            sEdit.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordAuth pass = new PasswordAuth();
            pass.Show();
        }

        private void yetkiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolAuth rol = new RolAuth();
            rol.Show();
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryAdd cAdd = new CategoryAdd();
            cAdd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductAddForm product = new ProductAddForm();
            product.Show();
        }

        private void btnProductControl_Click(object sender, EventArgs e)
        {
            ProductControlAddForm controlAdd = new ProductControlAddForm();
            controlAdd.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerAddForm customer = new CustomerAddForm();
            customer.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderAddForm order = new OrderAddForm();
            order.Show();
        }

        private void btnOrderControl_Click(object sender, EventArgs e)
        {
            OrderControlAddForm orderControl = new OrderControlAddForm();
            orderControl.Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            ShipperAddForm shipper = new ShipperAddForm();
            shipper.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employee = new EmployeeAddForm();
            employee.Show();
        }

        private void btnYetki_Click(object sender, EventArgs e)
        {
            RolAuth rolAuth = new RolAuth();
            rolAuth.Show();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            PasswordAuth passAuth = new PasswordAuth();
            passAuth.Show();
        }

        private void kategoriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm cate = new CategoryForm();
            cate.Show();
        }

        private void müşteriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerListForm list = new CustomerListForm();
            list.Show();
        }

        private void çalışanListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeListForm empList = new EmployeeListForm();
            empList.Show();
        }

        private void siparişListesiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrderListForm ordList = new OrderListForm();
            ordList.Show();
        }

        private void gönderilenSiparişlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderSentForm sentOrder = new OrderSentForm();
            sentOrder.Show();
        }

        private void hazırlananSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderUnSentForm unOrder = new OrderUnSentForm();
            unOrder.Show();
        }

        private void kargoListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShipperListForm shipList = new ShipperListForm();
            shipList.Show();
        }

        private void stokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stok = new StockForm();
            stok.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RolAuth rAuth = new RolAuth();
            rAuth.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PasswordAuth pAuth = new PasswordAuth();
            pAuth.Show();
        }

        private void hakkımızdaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siparişBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm proList = new ProductListForm();
            proList.Show();
        }

        private void çalışanListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeListForm empList = new EmployeeListForm();
            empList.Show();
        }

        private void çalışanBilgiDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEditForm empEdit = new EmployeeEditForm();
            empEdit.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ProductRepoForm repo = new ProductRepoForm();
            repo.Show();
        }

        private void ControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
        }
    }
}
