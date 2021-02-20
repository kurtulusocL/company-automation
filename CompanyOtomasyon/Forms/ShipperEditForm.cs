using CompanyOtomasyon.Data;
using CompanyOtomasyon.Models;
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
    public partial class ShipperEditForm : Form
    {
        ApplicationDbContext _db;
        Shipper ship = new Shipper();

        public ShipperEditForm()
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
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridShipper.DataSource = _db.Shippers.Include("Orders").Select(i => new
            {
                i.Id,
                i.Name,
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.MailAddress,
                i.Province,
                i.Country,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridShipper.DataSource = _db.Shippers.Include("Orders").Select(i => new
            {
                i.Id,
                i.Name,
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.MailAddress,
                i.Province,
                i.Country,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void ShipperEditForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridShipper.DataSource = _db.Shippers.Include("Orders").Select(i => new
            {
                i.Id,
                i.Name,
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.MailAddress,
                i.Province,
                i.Country,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i => i.Name.Contains(txtSearch.Text)).ToList();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridShipper.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridShipper.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridShipper.Rows)
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
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShipperAddForm add = new ShipperAddForm();
            this.Close();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ShipperListForm list = new ShipperListForm();
            this.Close();
            list.Show();
        }

        private void dtGridShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridShipper.CurrentRow;
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
            txtMail.Text = row.Cells["MailAddress"].Value.ToString();
            txtCountry.Text = row.Cells["Country"].Value.ToString();
            txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
            txtProvince.Text = row.Cells["Province"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var shipId = (int)txtName.Tag;
            ship = _db.Shippers.FirstOrDefault(i => i.Id == shipId);

            ship.Country = txtCountry.Text;
            ship.MailAddress = txtMail.Text;
            ship.Name = txtName.Text;
            ship.PhoneNumber = txtPhone.Text;
            ship.Province = txtProvince.Text;
            ship.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var shipId = (int)dtGridShipper.CurrentRow.Cells["Id"].Value;
            ship = _db.Shippers.FirstOrDefault(i => i.Id == shipId);

            _db.Shippers.Remove(ship);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}
