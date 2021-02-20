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
    public partial class PasswordForm : Form
    {
        ApplicationDbContext _db;
        SetPassword set = new SetPassword();

        public PasswordForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtMail.Clear();
            txtPassword.Clear();
            txtSearch.Clear();
            txtUsername.Clear();
            cmbRole.SelectedValue = "";
        }

        void FormLoad()
        {
            dtGridPassword.DataSource = _db.SetPasswords.Include("Role").Select(i => new
            {
                i.Id,
                i.Username,
                i.Password,
                i.EMail,
                RoleName = i.Role.RolName,
                i.CreatedDate,
                i.UpdatedDate,
                i.RoleId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridPassword.DataSource = _db.SetPasswords.Include("Role").Select(i => new
            {
                i.Id,
                i.Username,
                i.Password,
                i.EMail,
                RoleName = i.Role.RolName,
                i.CreatedDate,
                i.UpdatedDate,
                i.RoleId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            FormLoad();
            cmbRole.DataSource = _db.Roles.Include("SetPasswords").OrderBy(i => i.SetPasswords.Count()).ToList();
            cmbRole.ValueMember = "Id";
            cmbRole.DisplayMember = "RolName";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridPassword.DataSource = _db.SetPasswords.Include("Role").Select(i => new
            {
                i.Id,
                i.Username,
                i.Password,
                i.EMail,
                RoleName = i.Role.RolName,
                i.CreatedDate,
                i.UpdatedDate,
                i.RoleId
            }).Where(i => i.Username.Contains(txtSearch.Text)).ToList();
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

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUser.Checked)
            {
                dtGridPassword.DataSource = _db.SetPasswords.Include("Role").Select(i => new
                {
                    i.Id,
                    i.Username,
                    i.Password,
                    i.EMail,
                    RoleName = i.Role.RolName,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.RoleId
                }).OrderBy(i => i.RoleName).ToList();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            RolAuth auth = new RolAuth();
            this.Close();
            auth.Show();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridPassword.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                // pdfTablosu.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn sutun in dtGridPassword.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    //pdfHucresi.BackgroundColor = Color.LIGHT_GRAY;
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridPassword.Rows)
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

        private void dtGridPassword_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridPassword.CurrentRow;
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtUsername.Tag = row.Cells["Id"].Value;
            txtPassword.Text = row.Cells["Password"].Value.ToString();
            txtMail.Text = row.Cells["EMail"].Value.ToString();
            cmbRole.SelectedValue = row.Cells["RoleId"].Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            set.Username = txtUsername.Text;
            set.Password = txtPassword.Text;
            set.EMail = txtMail.Text;
            set.RoleId = (int)cmbRole.SelectedValue;
            set.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SetPasswords.Add(set);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var passwordId = (int)txtUsername.Tag;
            set = _db.SetPasswords.FirstOrDefault(i => i.Id == passwordId);

            set.Username = txtUsername.Text;
            set.Password = txtPassword.Text;
            set.EMail = txtMail.Text;
            set.RoleId = (int)cmbRole.SelectedValue;
            set.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var passwordId = (int)dtGridPassword.CurrentRow.Cells["Id"].Value;
            set = _db.SetPasswords.FirstOrDefault(i => i.Id == passwordId);

            _db.SetPasswords.Remove(set);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}
