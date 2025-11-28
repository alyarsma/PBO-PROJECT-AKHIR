
using PBO_PROJECT_AKHIR.Controllers;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Models;
using PBO_PROJECT_AKHIR.Views;
using PBO_PROJECT_AKHIR.Views.User;
using PBO_PROJECT_AKHIR.Views.Admin;

namespace PBO_PROJECT_AKHIR.Views
{
    public partial class Login : Form
    {
        private AuthController _authController;
        public Login()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username & Password harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }

            try
            {
                string hashPassword = PasswordHelper.HashPassword(password);
                UserModel user = new UserModel
                {
                    Username = username,
                    Password = hashPassword
                };

                var auth = _authController.Login(user);

                if (auth != null)
                {
                    AppSession.CurrentUser = auth;

                    MessageBox.Show(
                        $"Login Berhasil. Selamat datang {user.Username}",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    if (AppSession.CurrentUser.Role == UserRole.admin)
                    {
                        BerandaAdmin admin = new BerandaAdmin ();
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        BerandaCustomer userView = new BerandaCustomer();
                        userView.FormClosed += (s, args) => this.Close();
                        userView.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show(
                        "Username atau Password salah. Silahkan periksa kredensial akun anda!!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }

        private void lbregister_Click(object sender, EventArgs e)
        {
           _authController.showRegister(this);
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
