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

namespace audiovisalParcial.Design.Panel.Models
{
    public partial class ModelsForm : Form
    {
        //private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        //private modelo data;
        private int id = 0;

        public ModelsForm(int id = 0)
        {
            InitializeComponent();
            InitializeComponent();
            this.id = id;
            if (id > 0)
            {
                FindEquimentType();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int marca = int.Parse(cbxState.SelectedItem.ToString());
                int state = int.Parse(cbxState.SelectedItem.ToString());
                string description = txtDescription.Text;
                //if (id == 0)
                //{
                 
                //    data = new modelo();
                //    data.Descripcion = description;
                //    data.Estado = state;
                //    data.Marca = marca;
                //    audiovisualEntities.modelos.Add(data);
                //    audiovisualEntities.SaveChanges();
                //    Utils.Utils.Message("Datos fueron insertados correctamente");
                //    this.Close();
                //}
                //else
                //{
                //    data = audiovisualEntities.modelos.Find(id);
                //    data.Descripcion = description;
                //    data.Estado = state;
                //    data.Marca = marca;
                //    audiovisualEntities.SaveChanges();
                //    Utils.Utils.Message("Datos fueron actualizado correctamente");
                //    this.Close();
                //}

            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }
        }

        private void FindEquimentType()
        {
            //var search = audiovisualEntities.modelos.Find(id);
            //if (search != null)
            //{
            //    txtDescription.Text = search.Descripcion;
            //    cbxMarca.SelectedValue = search.Marca;
            //    cbxState.SelectedValue = search.Estado;
            //}
            //else
            //{
            //    Utils.Utils.MessageError("Error en buscar este dato");
            //}
        }
    }
}
