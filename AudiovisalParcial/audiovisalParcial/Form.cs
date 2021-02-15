using audiovisalParcial.Design.Menu.Maintances;
using audiovisalParcial.Design.Panel.Home;
using System;
using System.Windows.Forms;

namespace audiovisalParcial
{
    public partial class Form1 : Form
    {
        private HomeControl pHome;
        private MaintenanceMenuControl maintenanceMenu;

        public Form1()
        {
            InitializeComponent();
            pHome = new HomeControl();
            maintenanceMenu = new MaintenanceMenuControl(this); ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pHeaderMenu.Controls.Clear();
            pHeaderMenu.Controls.Add(maintenanceMenu);
        }

        public Panel getPanelBody() 
        {
            return pSubBody;
        }

    }
}
