using CompanyOtomasyon.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class ShipperListForm : Form
    {
        ApplicationDbContext _db;

        public ShipperListForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
            {
                KargoAdı = i.Name,
                SiparişSayısı = i.Orders.Count(),
                TelefonNo = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                Eyalet = i.Province,
                Ülke = i.Country,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
            {
                KargoAdı = i.Name,
                SiparişSayısı = i.Orders.Count(),
                TelefonNo = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                Eyalet = i.Province,
                Ülke = i.Country,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i=>i.KargoAdı.Contains(txtSearch.Text)).ToList();
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
                dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
                {
                    KargoAdı = i.Name,
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    Eyalet = i.Province,
                    Ülke = i.Country,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
            }
        }

        private void radioProvince_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProvince.Checked)
            {
                dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
                {
                    KargoAdı = i.Name,
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    Eyalet = i.Province,
                    Ülke = i.Country,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Eyalet).ToList();
            }
        }

        private void radioCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCountry.Checked)
            {
                dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
                {
                    KargoAdı = i.Name,
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    Eyalet = i.Province,
                    Ülke = i.Country,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Ülke).ToList();
            }
        }

        private void radioOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrder.Checked)
            {
                dtGridShipperList.DataSource = _db.Shippers.Include("Orders").Select(i => new
                {
                    KargoAdı = i.Name,
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    Eyalet = i.Province,
                    Ülke = i.Country,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.SiparişSayısı).ToList();
            }
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridShipperList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridShipperList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridShipperList.Rows)
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}
