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
    public partial class UpsertBrand : Form
    {
        public string IdBrand { get; set; }
        public string DescripcionBrand { get; set; }
        public string ModalidadBrand { get; set; }
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        public UpsertBrand()
        {
            InitializeComponent();
        }

        private void UpsertBrand_Load(object sender, EventArgs e)
        {
            try
            {
                if (IdBrand != null)
                {
                    txtBrandDescripcion.Text = DescripcionBrand;
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void btnBrandGuardar_Click(object sender, EventArgs e)
        {
            if (ModalidadBrand == "C")
            {
                audiovisualEntities.marcas.Add(new marcas
                {
                    Descripcion = txtBrandDescripcion.Text,
                    Estado = 1
                });
            }
            else 
            {
                this.Text = "Actualizar Marca";
                var marca = audiovisualEntities.marcas.Find(Int32.Parse(IdBrand));
                marca.Descripcion = txtBrandDescripcion.Text;
                audiovisualEntities.Entry(marca).State = System.Data.Entity.EntityState.Modified;
            }
            audiovisualEntities.SaveChanges();
            MessageBox.Show("Marca " + txtBrandDescripcion.Text + " guardada con exito!");
            this.Close();

        }

        private void btnBrandEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var marca = audiovisualEntities.marcas.Find(Int32.Parse(IdBrand));
                if (marca != null)
                {
                    audiovisualEntities.marcas.Remove(marca);
                    audiovisualEntities.SaveChanges();
                    MessageBox.Show("Marca eliminada con exito");
                }
                else
                    MessageBox.Show("Marca no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar la marca");
            }
            
        }
    }
}
