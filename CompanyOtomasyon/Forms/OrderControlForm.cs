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
    public partial class OrderControlForm : Form
    {
        ApplicationDbContext _db;
        OrderControl control = new OrderControl();

        public OrderControlForm()
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
            dtGridOrdControl.DataSource = _db.OrderControls.Include("Orders").Select(i => new
            {
                i.Id,
                i.Place,
                Orders = i.Orders.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridOrdControl.DataSource = _db.OrderControls.Include("Orders").Select(i => new
            {
                i.Id,
                i.Place,
                Orders = i.Orders.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void OrderControlForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridOrdControl.DataSource = _db.OrderControls.Include("Orders").Select(i => new
            {
                i.Id,
                i.Place,
                Orders = i.Orders.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i => i.Place.Contains(txtSearch.Text)).ToList();
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

        private void radioControl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioControl.Checked)
            {
                dtGridOrdControl.DataSource = _db.OrderControls.Include("Orders").Select(i => new
                {
                    i.Id,
                    i.Place,
                    Orders = i.Orders.Count(),
                    i.CreatedDate,
                    i.UpdatedDate
                }).OrderBy(i => i.Place).ToList();
            }
        }

        private void radioOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrder.Checked)
            {
                dtGridOrdControl.DataSource = _db.OrderControls.Include("Orders").Select(i => new
                {
                    i.Id,
                    i.Place,
                    Orders = i.Orders.Count(),
                    i.CreatedDate,
                    i.UpdatedDate
                }).OrderBy(i => i.Orders).ToList();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlForm home = new ControlForm();
            this.Close();
            home.Show();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            OrderListForm list = new OrderListForm();
            this.Close();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderControlAddForm add = new OrderControlAddForm();
            this.Close();
            add.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridOrdControl.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridOrdControl.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridOrdControl.Rows)
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

        private void dtGridOrdControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridOrdControl.CurrentRow;

            txtCatename.Text = row.Cells["Place"].Value.ToString();
            txtCatename.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var controlId = (int)txtCatename.Tag;
            control = _db.OrderControls.FirstOrDefault(i => i.Id == controlId);

            control.Place = txtCatename.Text;
            control.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var controlId = (int)dtGridOrdControl.CurrentRow.Cells["Id"].Value;
            control = _db.OrderControls.FirstOrDefault(i => i.Id == controlId);

            _db.OrderControls.Remove(control);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}
