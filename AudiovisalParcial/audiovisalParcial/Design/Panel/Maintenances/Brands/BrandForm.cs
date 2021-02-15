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

namespace audiovisalParcial.Design.Panel.Brand
{
    public partial class BrandForm : Form
    {
        //private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        //private marca data;
        private int id = 0;


        public BrandForm(int id = 0)
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
                    //data = new marca();
                    //data.Descripcion = description;
                    //data.Estado = state;
                    //audiovisualEntities.marcas.Add(data);
                    //audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    int state = int.Parse(cbxState.SelectedItem.ToString());
                    string description = txtDescription.Text;
                    //var data = audiovisualEntities.marcas.Find(id);
                    //data.Descripcion = description;
                    //data.Estado = state;
                    //audiovisualEntities.SaveChanges();
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
            //var data = audiovisualEntities.marcas.Find(id);
            //if (data != null)
            //{
            //    txtDescription.Text = data.Descripcion;
            //    cbxState.SelectedValue = data.Estado;
            //}
            //else
            //{
            //    Utils.Utils.MessageError("Error en buscar este dato");
            //}
        }
    }
}
