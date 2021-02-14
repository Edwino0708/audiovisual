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
        HomeControl pHome;
        TechnologiesConnectionControl pTech;

        public Form1()
        {
            InitializeComponent();
            pHome = new HomeControl();
            pTech = new TechnologiesConnectionControl();
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pHome);
        }

        private void pMenuTech_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pTech);
        }

        private void pMenuHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pBodySub.Controls.Clear();
            pBodySub.Controls.Add(pHome);
        }
    }
}
