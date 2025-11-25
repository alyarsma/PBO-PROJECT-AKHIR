using System;
using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_AKHIR.Views
{
    public partial class Register : Form
    {
        private AuthController controller;
        public Register()
        {
            InitializeComponent();
            controller = new AuthController();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbusername.Text;
                string email = tbemail.Text;
                string password = PasswordHelper.HashPassword(tbpassword.Text);

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Semua field harus diisi!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UserModel userRegister = new UserModel
                    {
                        Username = username,
                        Email = email,
                        Password = password,
                        Role = UserRole.admin
                    };
                    var success = controller.Register(userRegister);
                    if (success)
                    {
                        MessageBox.Show("Registrasi berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login loginView = new Login();
                        loginView.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        loginView.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan pendaftaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}