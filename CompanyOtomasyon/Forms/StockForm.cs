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
    public partial class StockForm : Form
    {
        ApplicationDbContext _db;
        Stock stok = new Stock();

        public StockForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            numStok.Value = 1;
            cmbProduct.SelectedValue = "";
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
            {
                i.Id,
                i.StockName,
                i.Product.Name,
                i.Quantity,
                i.Product.Price,
                i.Product.TotalPrice,
                i.CreatedDate,
                i.UpdatedDate,
                i.ProductId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
            {
                i.Id,
                i.StockName,
                i.Product.Name,
                i.Quantity,
                i.Product.Price,
                i.Product.TotalPrice,
                i.CreatedDate,
                i.UpdatedDate,
                i.ProductId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            FormLoad();

            cmbProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").OrderBy(i => i.Orders.Count()).ToList();
            cmbProduct.ValueMember = "Id";
            cmbProduct.DisplayMember = "Name";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioProductName.Checked)
            {
                dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
                {
                    i.Id,
                    i.StockName,
                    i.Product.Name,
                    i.Quantity,
                    i.Product.Price,
                    i.Product.TotalPrice,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.ProductId
                }).Where(i=>i.Name.Contains(txtSearch.Text)).ToList();
            }
            else if (radioName.Checked)
            {
                dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
                {
                    i.Id,
                    i.StockName,
                    i.Product.Name,
                    i.Quantity,
                    i.Product.Price,
                    i.Product.TotalPrice,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.ProductId
                }).Where(i => i.StockName.Contains(txtSearch.Text)).ToList();
            }
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

        private void radioStock_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStock.Checked)
            {
                dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
                {
                    i.Id,
                    i.StockName,
                    i.Product.Name,
                    i.Quantity,
                    i.Product.Price,
                    i.Product.TotalPrice,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.ProductId
                }).OrderBy(i => i.Quantity).ToList();
            }
        }

        private void radioProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProduct.Checked)
            {
                dtGridStock.DataSource = _db.Stocks.Include("Product").Select(i => new
                {
                    i.Id,
                    i.StockName,
                    i.Product.Name,
                    i.Quantity,
                    i.Product.Price,
                    i.Product.TotalPrice,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.ProductId
                }).OrderBy(i => i.Name).ToList();
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridStock.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridStock.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridStock.Rows)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockAddForm add = new StockAddForm();
            this.Close();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductListForm list = new ProductListForm();
            this.Close();
            list.Show();
        }

        private void dtGridStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridStock.CurrentRow;

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
            numStok.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
            cmbProduct.SelectedValue = row.Cells["ProductId"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var stokId = (int)txtName.Tag;
            stok = _db.Stocks.FirstOrDefault(i => i.Id == stokId);

            stok.StockName = txtName.Text;
            stok.Quantity = Convert.ToInt32(numStok.Value);
            stok.ProductId = (int)cmbProduct.SelectedValue;
            stok.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var stokId = (int)dtGridStock.CurrentRow.Cells["Id"].Value;
            stok = _db.Stocks.FirstOrDefault(i => i.Id == stokId);

            _db.Stocks.Remove(stok);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void btnExcell_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dtGridStock.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j]; myRange.Value2 = dtGridStock.Columns[j].HeaderText;
            }
            StartRow++; for (int i = 0; i < dtGridStock.Rows.Count; i++)
            {
                for (int j = 0; j < dtGridStock.Columns.Count; j++)
                {
                    try
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dtGridStock[j, i].Value == null ? "" : dtGridStock[j, i].Value;
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }
    }
}
