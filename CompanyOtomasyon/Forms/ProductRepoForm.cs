using CompanyOtomasyon.Data;
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
    public partial class ProductRepoForm : Form
    {
        ApplicationDbContext _db;

        public ProductRepoForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
            {
                ÜrünAdı = i.Name,
                Miktarı = i.Quantity,
                KDVOranı = i.KDV,
                BirimFiyatı = i.Price,
                ToplamFiyatı = i.TotalPrice,
                SiparişSayısı = i.Orders.Count(),
                DepodaMı = i.IsRepo,
                StokSayısı = i.Stocks.Count(),
                KategoriAdı = i.Category.Name,
                İşlemiYapan = i.Employee.NameSurname,
                ÜrünDurumu = i.ProductControl.Place,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).Where(i => i.DepodaMı == true).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        private void ProductRepoForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioProducyName.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.ÜrünAdı.Contains(txtSearch.Text) && i.DepodaMı == true).ToList();
            }
            else if (radioEmploye.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.İşlemiYapan.Contains(txtSearch.Text) && i.DepodaMı == true).ToList();
            }
            else if (radioCategory.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.KategoriAdı.Contains(txtSearch.Text) && i.DepodaMı == true).ToList();
            }
            else
            {
                MessageBox.Show("Gösterilecek bir arama sonucu yoktur.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void radioKdvOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKdvOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.KDVOranı).ToList();
            }
        }

        private void radioQuantityOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioQuantityOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.Miktarı).ToList();
            }
        }

        private void radioPriceOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPriceOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.BirimFiyatı).ToList();
            }
        }

        private void radioTotalPriceOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTotalPriceOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.ToplamFiyatı).ToList();
            }
        }

        private void radioOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.SiparişSayısı).ToList();
            }
        }

        private void radioStockOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStockOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.StokSayısı).ToList();
            }
        }

        private void radioCreatedOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCreatedOrder.Checked)
            {
                FormLoad();
            }
        }

        private void radioUpdatedOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdatedOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
            }
        }

        private void radioEmployeeOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEmployeeOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true).OrderBy(i => i.İşlemiYapan).ToList();
            }
        }

        private void radioCategoryOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCategoryOrder.Checked)
            {
                dtGridProduct.DataSource = _db.Products.Include("Category").Include("Employee").Include("ProductControl").Include("Orders").Include("Stocks").Select(i => new
                {
                    ÜrünAdı = i.Name,
                    Miktarı = i.Quantity,
                    KDVOranı = i.KDV,
                    BirimFiyatı = i.Price,
                    ToplamFiyatı = i.TotalPrice,
                    SiparişSayısı = i.Orders.Count(),
                    DepodaMı = i.IsRepo,
                    StokSayısı = i.Stocks.Count(),
                    KategoriAdı = i.Category.Name,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÜrünDurumu = i.ProductControl.Place,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.DepodaMı == true ).OrderBy(i => i.KategoriAdı).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductEditForm edit = new ProductEditForm();
            this.Close();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
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
                pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridProduct.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfHucresi.BackgroundColor = CMYKColor.BLUE;
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductListForm list = new ProductListForm();
            this.Close();
            list.Show();
        }
    }
}
