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
    public partial class Brand : Form
    {
        
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            getBrands();
        }

        private void getBrands() {
            try
            {
                dvgBrand.DataSource = null;
                dvgBrand.DataSource = audiovisualEntities.marcas.ToList();
                dvgBrand.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            
        }

        private void getBrandByFilter()
        {
            var brands = from marca in audiovisualEntities.marcas
                            where (marca.Descripcion.StartsWith(txtBrandBuscar.Text))
                            select marca;
            dvgBrand.DataSource = null;
            dvgBrand.DataSource = brands.ToList();
        }

        private void btnBrandBuscar_Click(object sender, EventArgs e)
        {
            dvgBrand.DataSource = null;
            getBrandByFilter();
        }

        private void btnBrandAgregar_Click(object sender, EventArgs e)
        {
            UpsertBrand upsertbrand = new UpsertBrand();
            upsertbrand.ModalidadBrand = "C";
            upsertbrand.Text = "Agregar Marca";
            upsertbrand.ShowDialog();
        }

        private void Brand_Activated(object sender, EventArgs e)
        {
            dvgBrand.DataSource = null;
            getBrands();
            
        }

        private void dvgBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dvgBrand.SelectedRows[0];
                UpsertBrand upsertBrandForm = new UpsertBrand();
                upsertBrandForm.IdBrand = row.Cells[0].Value.ToString();
                upsertBrandForm.DescripcionBrand = row.Cells[1].Value.ToString();
                upsertBrandForm.ModalidadBrand = "U";
                upsertBrandForm.Text = "Actualizar Marca";
                upsertBrandForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
            
        }
    }
}
