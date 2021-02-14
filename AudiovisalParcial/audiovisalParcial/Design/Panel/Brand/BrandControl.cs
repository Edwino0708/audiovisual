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
    public partial class BrandControl : UserControl
    {

        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();

        private BrandForm createForm;
        public BrandControl()
        {
            InitializeComponent();
            getList();
        }


        #region Private Methods
        private void getList()
        {

            try
            {
                dgvListEquipmentType.DataSource = null;
                dgvListEquipmentType.DataSource = audiovisualEntities.marcas.ToList();
                dgvListEquipmentType.Refresh();
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void filter()
        {
            try
            {

                var modelos = from data in audiovisualEntities.marcas
                              where (

                                        data.Id == int.Parse(txtBuscar.Text) ||
                                        data.Descripcion.Contains(txtBuscar.Text) ||
                                        data.Estado == int.Parse(txtBuscar.Text)
                                     )
                              select data;

                dgvListEquipmentType.DataSource = null;
                dgvListEquipmentType.DataSource = modelos.ToList();
            }
            catch (Exception ex)
            {

                Utils.Utils.MessageError("No pudimos ejecutar la consulta " + ex.Message);
            }

        }
        #endregion
   
        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createForm = new BrandForm();
            createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.marcas.Find(id);
                if (data != null)
                {
                    audiovisualEntities.marcas.Remove(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Marca eliminado con exito");
                    getList();
                }
                else
                    MessageBox.Show("Marca no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Marca");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new BrandForm(id);
            createForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getList();
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter();
        }
    }
}
