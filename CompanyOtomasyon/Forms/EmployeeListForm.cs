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
    public partial class EmployeeListForm : Form
    {
        ApplicationDbContext _db;
        Employee emp = new Employee();

        public EmployeeListForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridEmployeeList.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
            {
                AdıSoyadı = i.NameSurname,
                MailAdresi = i.MailAddress,
                ÜrünSayısı = i.Products.Count(),
                SiparişSayısı = i.Orders.Count(),
                TelefonNo = i.PhoneNumber,
                Adresi = i.Address,
                Resmi = i.Photo,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridEmployeeList.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
            {
                AdıSoyadı = i.NameSurname,
                MailAdresi = i.MailAddress,
                ÜrünSayısı = i.Products.Count(),
                SiparişSayısı = i.Orders.Count(),
                TelefonNo = i.PhoneNumber,
                Adresi = i.Address,
                Resmi = i.Photo,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i => i.AdıSoyadı.Contains(txtSearch.Text)).ToList();
        }

        private void radioCreated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCreated.Checked)
            {
                FormLoad();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dtGridEmployeeList.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
                {
                    AdıSoyadı = i.NameSurname,
                    MailAdresi = i.MailAddress,
                    ÜrünSayısı = i.Products.Count(),
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    Adresi = i.Address,
                    Resmi = i.Photo,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dtGridEmployeeList.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
                {
                    AdıSoyadı = i.NameSurname,
                    MailAdresi = i.MailAddress,
                    ÜrünSayısı = i.Products.Count(),
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    Adresi = i.Address,
                    Resmi = i.Photo,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.AdıSoyadı).ToList();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dtGridEmployeeList.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
                {
                    AdıSoyadı = i.NameSurname,
                    MailAdresi = i.MailAddress,
                    ÜrünSayısı = i.Products.Count(),
                    SiparişSayısı = i.Orders.Count(),
                    TelefonNo = i.PhoneNumber,
                    Adresi = i.Address,
                    Resmi = i.Photo,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.TelefonNo).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeEditForm edit = new EmployeeEditForm();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridEmployeeList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridEmployeeList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridEmployeeList.Rows)
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

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void dtGridEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridEmployeeList.CurrentRow;
            picEmployee.ImageLocation = row.Cells["Resmi"].Value.ToString();
        }

        private void btnExcell_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dtGridEmployeeList.Columns.Count; j++)
            {
               Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j]; myRange.Value2 = dtGridEmployeeList.Columns[j].HeaderText;
            }
            StartRow++; for (int i = 0; i < dtGridEmployeeList.Rows.Count; i++)
            {
                for (int j = 0; j < dtGridEmployeeList.Columns.Count; j++)
                {
                    try
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dtGridEmployeeList[j, i].Value == null ? "" : dtGridEmployeeList[j, i].Value;
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
