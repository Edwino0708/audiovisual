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
    public partial class Modelo : Form
    {
        public AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        public Modelo()
        {
            InitializeComponent();
        }

        private void Modelo_Load(object sender, EventArgs e)
        {
            getModels();
            FillComboBoxMarcar(cbxMarca);
        }

        private void getModels()
        {
            try
            {
                dvgModelo.DataSource = null;
                dvgModelo.DataSource = audiovisualEntities.modelos.ToList();
                dvgModelo.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void getModeloByFilter()
        {
            try
            {
                
                   var modelos = from modelo in audiovisualEntities.modelos
                              where (modelo.Marca == (int)cbxMarca.SelectedValue)
                              select modelo;
                
                dvgModelo.DataSource = null;
                dvgModelo.DataSource = modelos.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No pudimos ejecutar la consulta " + ex.Message);
            }
            
        }

        private void btnModeloBuscar_Click(object sender, EventArgs e)
        {
            getModeloByFilter();
        }

        private void btnModeloEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dvgModelo.Rows[dvgModelo.CurrentRow.Index].Cells[0].Value.ToString());
                var modelo = audiovisualEntities.modelos.Find(id);
                if (modelo != null)
                {
                    audiovisualEntities.modelos.Remove(modelo);
                    audiovisualEntities.SaveChanges();
                    MessageBox.Show("Modelo eliminado con exito");
                }
                else
                    MessageBox.Show("Modelo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el modelo");
            }
        }

        private void Modelo_Activated(object sender, EventArgs e)
        {
            getModels();
        }

        public void FillComboBoxMarcar(ComboBox cbx) 
        {
            try
            {
                cbx.DataSource = audiovisualEntities.marcas.ToList();
                cbx.ValueMember = "Id";
                cbx.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar marcas:" + ex.Message);
            }
            

        }

        private void btnModeloAgregar_Click(object sender, EventArgs e)
        {
            UpsertModelo upsertmodelo = new UpsertModelo();
            upsertmodelo.ModalidadModelo = "C";
            upsertmodelo.Text = "Agregar Modelo";
            upsertmodelo.ShowDialog();
        }

        private void btnModeloEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dvgModelo.Rows[dvgModelo.CurrentRow.Index].Cells[0].Value.ToString());
                var modelo = audiovisualEntities.modelos.Find(id);
                UpsertModelo upsertModeloForm = new UpsertModelo();
                upsertModeloForm.IdModelo = id.ToString();
                upsertModeloForm.IdMarca = modelo.Marca.ToString();
                upsertModeloForm.DescripcionModelo = modelo.Descripcion;
                upsertModeloForm.ModalidadModelo = "U";
                upsertModeloForm.Text = "Actualizar Modelo";
                upsertModeloForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
        }

        private void dvgModelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dvgModelo.SelectedRows[0];
                UpsertModelo upsertModeloForm = new UpsertModelo();
                upsertModeloForm.IdModelo = row.Cells[0].Value.ToString();
                upsertModeloForm.IdMarca = row.Cells[1].Value.ToString();
                upsertModeloForm.DescripcionModelo = row.Cells[2].Value.ToString();
                upsertModeloForm.ModalidadModelo = "U";
                upsertModeloForm.Text = "Actualizar Marca";
                upsertModeloForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
        }

        private void txtModeloBuscar_TextChanged(object sender, EventArgs e)
        {
            var modelos = from modelo in audiovisualEntities.modelos
                          where (modelo.Descripcion.StartsWith(txtModeloBuscar.Text))
                          select modelo;

            dvgModelo.DataSource = null;
            dvgModelo.DataSource = modelos.ToList();
        }
    }
}
