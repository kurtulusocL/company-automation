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
    public partial class CategoryForm : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryForm()
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
            dtGridCategory.DataSource = _db.Categories.Include("Products").Select(i => new
            {
                i.Id,
                i.Name,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridCategory.DataSource = _db.Categories.Include("Products").Select(i => new
            {
                i.Id,
                i.Name,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCategory.DataSource = _db.Categories.Include("Products").Select(i => new
            {
                i.Id,
                i.Name,
                Products = i.Products.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.Name.Contains(txtSearch.Text)).ToList();
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

        private void radioProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProduct.Checked)
            {
                dtGridCategory.DataSource = _db.Categories.Include("Products").Select(i => new
                {
                    i.Id,
                    i.Name,
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cateId = (int)txtCatename.Tag;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            cate.Name = txtCatename.Text;
            cate.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cateId = (int)dtGridCategory.CurrentRow.Cells["Id"].Value;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            _db.Categories.Remove(cate);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd add = new CategoryAdd();
            this.Close();
            add.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridCategory.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridCategory.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridCategory.Rows)
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

        private void dtGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridCategory.CurrentRow;

            txtCatename.Text = row.Cells["Name"].Value.ToString();
            txtCatename.Tag = row.Cells["Id"].Value;
        }
    }
}
