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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AUDIOVISUALESEntities db = new AUDIOVISUALESEntities();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            EditTechs formedit = new EditTechs();
            formedit.ShowDialog();
            Refrescar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if(MessageBox.Show("Quieres eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(id != null)
                {
                    tecnologias_conexion tecnologia = db.tecnologias_conexion.Find(id);
                    db.tecnologias_conexion.Remove(tecnologia);

                    db.SaveChanges();
                    Refrescar();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                EditTechs edform = new EditTechs(id);
                edform.ShowDialog();

                Refrescar();
            }
        }


        // Funciones

        private void consultarPorCriterio()
        {
            var tecnologias = from em in db.tecnologias_conexion
                              where (em.Id.ToString().StartsWith(txtBuscar.Text) ||
                                     em.Descripcion.StartsWith(txtBuscar.Text)
                                    )
                              select em;
            dgvResultados.DataSource = tecnologias.ToList();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvResultados.Rows[dgvResultados.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        public void Refrescar()
        {
            var lst = from d in db.tecnologias_conexion
                      select d;
            dgvResultados.DataSource = lst.ToList();
        }

    }
}
