using audiovisalParcial.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using audiovisalParcial.Common;

namespace audiovisalParcial
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        private string role;
        private HomeControl home;
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        
        public Login()
        {
            InitializeComponent(); 
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                username = $@"" + txbUsername.Text.ToString();
                password = Common.Util.EncryptionPassowrd($@""+txbPassword.Text.ToString());

                UserLogin userLogin = audiovisualEntities.UserLogins.Where(w =>
                w.username.Equals(this.username) &&
                w.password.Equals(password) &&
                w.isActive == true
                ).Select(s => s).FirstOrDefault();
                
                if (userLogin == null)
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
                else
                {
                    Storage.Role = userLogin.role;
                    Storage.Login = this;
                    Storage.UserName = userLogin.username;
                    home = new HomeControl();
                    home.Show();
                    this.Hide();
                }

            } 
            catch(Exception ex) 
            { }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbUsername.Text.ToString()) && !string.IsNullOrEmpty(txbPassword.Text.ToString()))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbUsername.Text.ToString()) && !string.IsNullOrEmpty(txbPassword.Text.ToString()))
            {
                btnLogin.Enabled = true;
            }
            else 
            {
                btnLogin.Enabled = false;
            }

        }
    }
}
