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

namespace audiovisalParcial.Design.Panel.TechnologiesConnection
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
        }

        AUDIOVISUALESEntities db = new AUDIOVISUALESEntities();
        tecnologias_conexion tecnologia = new tecnologias_conexion();

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
