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
    public partial class EmployeeEditForm : Form
    {
        ApplicationDbContext _db;
        Employee emp = new Employee();

        public EmployeeEditForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtPicUrl.Clear();
            txtPhone.Clear();
            txtNameSurname.Clear();
            txtMail.Clear();
            richTextBox1.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Products").Include("Orders").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.MailAddress,
                Products = i.Products.Count(),
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.Address,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.MailAddress,
                Products = i.Products.Count(),
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.Address,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate).ToList();
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Products").Include("Products").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.MailAddress,
                Products = i.Products.Count(),
                Orders = i.Orders.Count(),
                i.PhoneNumber,
                i.Address,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.NameSurname.Contains(txtSearch.Text)).ToList();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridEmployee.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridEmployee.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridEmployee.Rows)
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
            EmployeeAddForm add = new EmployeeAddForm();
            this.Close();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeListForm list = new EmployeeListForm();
            this.Close();
            list.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picEmployee.ImageLocation = openFileDialog1.FileName;
            txtPicUrl.Text = openFileDialog1.FileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var empId = (int)txtNameSurname.Tag;
            emp = _db.Employees.FirstOrDefault(i => i.Id == empId);

            emp.NameSurname = txtNameSurname.Text;
            emp.Address = richTextBox1.Text;
            emp.MailAddress = txtMail.Text;
            emp.PhoneNumber = txtPhone.Text;
            emp.Photo = txtPicUrl.Text;
            emp.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var empId = (int)dtGridEmployee.CurrentRow.Cells["Id"].Value;
            emp = _db.Employees.FirstOrDefault(i => i.Id == empId);

            _db.Employees.Remove(emp);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void dtGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridEmployee.CurrentRow;
            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag = row.Cells["Id"].Value;
            txtMail.Text = row.Cells["MailAddress"].Value.ToString();
            txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
            richTextBox1.Text = row.Cells["Address"].Value.ToString();
            picEmployee.ImageLocation = row.Cells["Photo"].Value.ToString();
            txtPicUrl.Text= row.Cells["Photo"].Value.ToString();
        }
    }
}
