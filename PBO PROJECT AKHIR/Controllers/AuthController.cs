using Npgsql;
using PBO_PROJECT_AKHIR.Database;
using PBO_PROJECT_AKHIR.Helpers;
using PBO_PROJECT_AKHIR.Models;
using PBO_PROJECT_AKHIR.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Controllers
{
    public class AuthController
    {
        private DbContext _dbContext;
        public AuthController()
        {
            _dbContext = new DbContext();
        }
        public UserModel Login(UserModel   user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT role, username, email, password FROM users WHERE username = @username AND password = @password LIMIT 1 ";

                    string hashedPassword = PasswordHelper.HashPassword(user.Password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                string role = read.GetString(0);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), role);

                                UserModel LoggedInuser = new UserModel
                                {
                                    Role = roleEnum,
                                    Username = read.GetString(1),
                                    Email = read.GetString(2),
                                    Password = read.GetString(3)
                                };

                                return LoggedInuser;
                            }

                            return null;
                        }
                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Register(UserModel user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO users (username, email, password, role) VALUES (@username, @email, @password, @role::role_user)";

                    string hashPassword = PasswordHelper.HashPassword(user.Password);

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@password", hashPassword);
                        cmd.Parameters.AddWithValue("@role", user.Role.ToString());

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Register ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void showLogin(Form form)
        {
            form.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        public void showRegister(Form form)
        {
            form.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}
