using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAudiovisuales
{
    public partial class EditTechs : Form
    {
        public int? id;
        tecnologias_conexion tecnologia = null;
        AUDIOVISUALESEntities db = new AUDIOVISUALESEntities();

        public EditTechs(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {
                tecnologia = db.tecnologias_conexion.Find(id);
                txtDescripcion.Text = tecnologia.Descripcion;
                cbxEstado.Text = tecnologia.Estado.ToString();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (id == null)
                tecnologia = new tecnologias_conexion();

            tecnologia.Descripcion = txtDescripcion.Text;
            tecnologia.Estado = int.Parse(cbxEstado.Text);

            if (id == null)
                db.tecnologias_conexion.Add(tecnologia);
            else
            {
                db.Entry(tecnologia).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();

            this.Close();
        }

        private void EditTechs_Load(object sender, EventArgs e)
        {

        }
    }
}
