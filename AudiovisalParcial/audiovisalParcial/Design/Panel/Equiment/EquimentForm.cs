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

namespace audiovisalParcial.Design.Panel.Equiment
{
    public partial class EquimentForm : Form
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private equipos data;
        private int id = 0;

        public EquimentForm(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id > 0)
            {
                Find();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int marca = int.Parse(cbxMarca.SelectedItem.ToString());
                int model = int.Parse(cbxModel.SelectedItem.ToString());
                int type = int.Parse(cbxType.SelectedItem.ToString());
                int typeTecnologia = int.Parse(cbxTypeTecnology.SelectedItem.ToString());
                int state = int.Parse(cbxState.SelectedItem.ToString());
                string description = txtDescription.Text;
                string serial = txtSerial.Text;
                string serviceTag = txtServiceTag.Text;


                if (id == 0)
                {
                    data = new equipos();
                    data.Descripcion = description;
                    data.Marca = marca;
                    data.Modelo = model;
                    data.TipoEquipo = type;
                    data.TecnologiaConexion = typeTecnologia;
                    data.Descripcion = description;
                    data.Noserial = serial;
                    data.ServiceTag = serviceTag;
                    audiovisualEntities.equipos.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    var data = audiovisualEntities.equipos.Find(id);
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

        private void Find()
        {
            var data = audiovisualEntities.equipos.Find(id);
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
