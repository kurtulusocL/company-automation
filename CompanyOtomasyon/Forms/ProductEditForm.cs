using CompanyOtomasyon.Data;
using CompanyOtomasyon.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyOtomasyon.Forms
{
    public partial class ProductEditForm : Form
    {
        ApplicationDbContext _db;
        Product pro = new Product();

        public ProductEditForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtTotalPrice.Clear();
            btnHesap.Text = "Ürünün toplam fiyatını hesapla";
            lblKdv.Text = "xxx";
            lblQuantity.Text = "xxx";
            numKDV.Value = 1;
            numQuantity.Value = 1;
            radioYes.Checked = true;
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
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
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
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
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            radioYes.Checked = true;
            FormLoad();

            cmbCategory.DataSource = _db.Categories.Include("Products").OrderByDescending(i => i.Products.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            cmbControl.DataSource = _db.ProductControls.Include("Products").OrderByDescending(i => i.Products.Count()).ToList();
            cmbControl.ValueMember = "Id";
            cmbControl.DisplayMember = "Place";

            cmbEmployee.DataSource = _db.Employees.Include("Products").Include("Orders").OrderByDescending(i => i.Products.Count()).ToList();
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "NameSurname";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioProducyName.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
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
                }).Where(i => i.Name.Contains(txtSearch.Text)).ToList();
            }
            else if (radioEmploye.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
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
                }).Where(i => i.NameSurname.Contains(txtSearch.Text)).ToList();
            }
            else if (radioCategory.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
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
                }).Where(i => i.Category.Contains(txtSearch.Text)).ToList();
            }
            else
            {
                MessageBox.Show("Gösterilecek bir arama sonucu yoktur.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnExcell_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dtGridProduct.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j]; myRange.Value2 = dtGridProduct.Columns[j].HeaderText;
            }
            StartRow++; for (int i = 0; i < dtGridProduct.Rows.Count; i++)
            {
                for (int j = 0; j < dtGridProduct.Columns.Count; j++)
                {
                    try
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dtGridProduct[j, i].Value == null ? "" : dtGridProduct[j, i].Value;
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridProduct.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridProduct.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridProduct.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "dosyaadı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {

                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
        }

        private void btnProductControl_Click(object sender, EventArgs e)
        {
            ProductControlForm control = new ProductControlForm();
            this.Close();
            control.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductAddForm add = new ProductAddForm();
            this.Close();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductListForm list = new ProductListForm();
            this.Close();
            list.Show();
        }

        private void numKDV_ValueChanged(object sender, EventArgs e)
        {
            lblKdv.Text = Convert.ToInt32(numKDV.Value).ToString();
            lblKdv.ForeColor = Color.DarkGreen;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblQuantity.Text = Convert.ToInt32(numQuantity.Value).ToString();
            lblQuantity.ForeColor = Color.DarkGreen;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            var price = Convert.ToDecimal(txtPrice.Text);
            var result = (price * Convert.ToInt32(lblKdv.Text) * Convert.ToInt32(lblQuantity.Text)) / 100;
            btnHesap.Text = "Toplam Fiyat " + result.ToString() + " " + "TL";
            txtTotalPrice.Text = result.ToString();
        }

        private void dtGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridProduct.CurrentRow;

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
            numKDV.Value = Convert.ToInt32(row.Cells["KDV"].Value);
            numQuantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
            txtPrice.Text = Convert.ToDecimal(row.Cells["Price"].Value).ToString();
            txtTotalPrice.Text = Convert.ToDecimal(row.Cells["TotalPrice"].Value).ToString();
            if (pro.IsRepo=radioYes.Checked)
            {
                radioYes.Text = Convert.ToBoolean(row.Cells["IsRepo"].Value).ToString();
            }
            else
            {
                radioNo.Text = Convert.ToBoolean(row.Cells["IsRepo"].Value).ToString();
            }
            cmbCategory.SelectedValue = row.Cells["CategoryId"].Value;
            cmbControl.SelectedValue = row.Cells["ProductControlId"].Value;
            cmbEmployee.SelectedValue = row.Cells["EmployeeId"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var proId = (int)txtName.Tag;
            pro = _db.Products.FirstOrDefault(i => i.Id == proId);

            pro.Name = txtName.Text;
            pro.Quantity = Convert.ToInt32(lblQuantity.Text);
            pro.KDV = Convert.ToInt32(lblKdv.Text);
            pro.Price = Convert.ToDecimal(txtPrice.Text);
            pro.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            pro.CategoryId = (int)cmbCategory.SelectedValue;
            pro.ProductControlId = (int)cmbControl.SelectedValue;
            pro.EmployeeId = (int)cmbEmployee.SelectedValue;
            pro.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (pro.IsRepo = radioYes.Checked)
            {
                radioYes.Text = pro.IsRepo.ToString();
            }
            else
            {
                radioNo.Text = pro.IsRepo.ToString();
            }

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var proId = (int)dtGridProduct.CurrentRow.Cells["Id"].Value;
            pro = _db.Products.FirstOrDefault(i => i.Id == proId);

            _db.Products.Remove(pro);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}
