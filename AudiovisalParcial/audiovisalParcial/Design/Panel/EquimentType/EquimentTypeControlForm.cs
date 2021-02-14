using audiovisalParcial.Model;
using audiovisalParcial.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.EquipmentType
{
    public partial class EquipmentTypeControlForm : Form
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private tipo_equipos equimentTypes;
        private int id = 0;
        public EquipmentTypeControlForm(int id = 0)
        {
            InitializeComponent();
            this.id = id;
            if (id > 0) 
            {
                FindEquimentType();
            }
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    int state = int.Parse(cbxState.SelectedItem.ToString());
                    string description = txtDescription.Text;
                    equimentTypes = new tipo_equipos();
                    equimentTypes.Descripcion = description;
                    equimentTypes.Estado = state;
                    audiovisualEntities.tipo_equipos.Add(equimentTypes);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    int state = int.Parse(cbxState.SelectedItem.ToString());
                    string description = txtDescription.Text;
                    var equimentTypes = audiovisualEntities.tipo_equipos.Find(id);
                    equimentTypes.Descripcion = description;
                    equimentTypes.Estado = state;
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

        private void FindEquimentType() 
        {
            var equimentTypes = audiovisualEntities.tipo_equipos.Find(id);
            if (equimentTypes != null)
            {
                txtDescription.Text = equimentTypes.Descripcion;
                cbxState.SelectedValue = equimentTypes.Estado;
            }
            else
            {
                Utils.Utils.MessageError("Error en buscar este dato");
            }
        }
    }
}
