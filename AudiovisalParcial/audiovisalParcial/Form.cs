using audiovisalParcial.Design.Panel.EquipmentType;
using audiovisalParcial.Design.Panel.Home;
using audiovisalParcial.Design.Panel.TechnologiesConnection;
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
    public partial class Form1 : Form
    {
        private HomeControl pHome;
        private TechnologiesConnectionControl pTech;
        private EquipmentTypeControl pEquipmentType;

        public Form1()
        {
            InitializeComponent();
            pHome = new HomeControl();
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pHome);
        }

        private void pMenuTech_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pTech);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMenuOption1_MouseClick(object sender, MouseEventArgs e)
        {
            pEquipmentType = new EquipmentTypeControl(); 
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pEquipmentType);
        }

        private void btnMenuOption4_MouseClick(object sender, MouseEventArgs e)
        {
            pTech = new TechnologiesConnectionControl();
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pTech);
        }
    }
}
