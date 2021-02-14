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
    public partial class TechnologiesConnectionForm : Form
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private tecnologias_conexion data;
        private int id = 0;

        public TechnologiesConnectionForm(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id > 0)
            {
                FindData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int state = int.Parse(cbxState.SelectedItem.ToString());
                string description = txtDescription.Text;

                if (id == 0)
                {
                    data = new tecnologias_conexion();
                    data.Descripcion = description;
                    data.Estado = state;
                    audiovisualEntities.tecnologias_conexion.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    var data = audiovisualEntities.tecnologias_conexion.Find(id);
                    data.Descripcion = description;
                    data.Estado = state;
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron actualizado correctamente");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }
        }

        private void FindData()
        {
            var data = audiovisualEntities.tipo_equipos.Find(id);
            if (data != null)
            {
                txtDescription.Text = data.Descripcion;
                cbxState.SelectedValue = data.Estado;
            }
            else
            {
                Utils.Utils.MessageError("Error en buscar este dato");
            }
        }
    }
}
