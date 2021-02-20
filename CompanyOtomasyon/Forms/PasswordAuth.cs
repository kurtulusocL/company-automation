using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyOtomasyon.Forms
{
    public partial class PasswordAuth : Form
    {
        string username = "admin";
        string password = "123";

        PasswordForm pass = new PasswordForm();
        ControlForm control = new ControlForm();

        public PasswordAuth()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (username == txtUsername.Text && password == txtPassword.Text)
            {
                this.Close();
                pass.Show();
            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz yanlış. Lüten kontrol edin ya da yetkiliye başvurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            control.Show();
        }
    }
}
