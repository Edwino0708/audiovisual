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
    public partial class UpsertModelo : Form
    {
        public string IdModelo { get; set; }
        public string IdMarca { get; set; }
        public string DescripcionModelo { get; set; }
        public string ModalidadModelo { get; set; }
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private Modelo modelo = new Modelo();
        public UpsertModelo()
        {
            InitializeComponent();
        }

        private void UpsertModelo_Load(object sender, EventArgs e)
        {
            try
            {
                if (IdModelo != null)
                {
                    modelo.FillComboBoxMarcar(cbxUpsertMarcas);
                    txtModeloDescripcion.Text = DescripcionModelo;
                    cbxUpsertMarcas.SelectedValue = int.Parse(IdMarca);
                }

                if (ModalidadModelo == "C")
                {

                    modelo.FillComboBoxMarcar(cbxUpsertMarcas);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores a editar");
            }
        }

        private void btnBrandGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModalidadModelo == "C")
                {
                    if (txtModeloDescripcion.Text == "")
                    {
                        MessageBox.Show("Descripcion es un campo requerido");
                        return;
                    }
                    else if (cbxUpsertMarcas.Items.Count == 0)
                    {
                        MessageBox.Show("Descripcion es un campo requerido");
                        return;
                    }
                    audiovisualEntities.modelos.Add(new modelos
                    {
                        Marca = (int)cbxUpsertMarcas.SelectedValue,
                        Descripcion = txtModeloDescripcion.Text,
                        Estado = 1
                    });
                }
                else 
                {
                    this.Text = "Actualizar Modelo";
                    var modelo = audiovisualEntities.modelos.Find(Int32.Parse(IdModelo));
                    modelo.Marca = (int)cbxUpsertMarcas.SelectedValue;
                    modelo.Descripcion = txtModeloDescripcion.Text;
                    audiovisualEntities.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                }
                audiovisualEntities.SaveChanges();
                MessageBox.Show("Modelo " + txtModeloDescripcion.Text + " guardada con exito!");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("no pudimos crear el modelo");
            }
            
        }
    }
}
