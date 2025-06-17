
// LoginForm.cs
// Kullanıcı giriş formu

using System;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Sabit kullanıcı adı ve şifre kontrolü
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }
        }
    }
}
