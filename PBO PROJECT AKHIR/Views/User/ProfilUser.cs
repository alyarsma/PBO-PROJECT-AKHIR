using PBO_PROJECT_AKHIR.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views.User
{
    public partial class ProfilUser : Form
    {
        public ProfilUser()
        {
            InitializeComponent();

            if (AppSession.CurrentUser != null)
            {
                tbusername.Text = AppSession.CurrentUser.Username;
                tbemail.Text = AppSession.CurrentUser.Email;

                tbpassword.UseSystemPasswordChar = true;
                tbpassword.Text = new string('*', AppSession.CurrentUser.Password.Length);
            }
        }


        private void ProfilUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MassageBoxYakinProfil popup = new MassageBoxYakinProfil();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
               
            }
        }
    }
}
