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

namespace audiovisalParcial
{
    public partial class Login : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            User usuario = (from u in audiovisualEntities.Users
                               where u.FirstName.Equals(txtUsuario.Text) &&
                                     u.IdentificationCard.Equals(txtClave.Text)
                               select u).FirstOrDefault();

            if (usuario == null)
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            else if (usuario.Enabled.Equals("0") && usuario.UsersType.Equals(1))
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                Form1 frmMenu = new Form1();
                this.Hide();
                frmMenu.ShowDialog();
            }
        }
    }
}
