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
    public partial class ModelsControl : UserControl
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private  ModelsForm createForm;

        public ModelsControl()
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
                dgvListEquipmentType.DataSource = audiovisualEntities.modelos.ToList();
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

                var modelos = from data in audiovisualEntities.modelos
                              where (
                                        data.Id == int.Parse(txtBuscar.Text) ||
                                        data.Marca == int.Parse(txtBuscar.Text) ||
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createForm = new ModelsForm();
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new ModelsForm(id);
            createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.modelos.Find(id);
                if (data != null)
                {
                    audiovisualEntities.modelos.Remove(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Equipo de tipo eliminado con exito");
                    getList();
                }
                else
                    MessageBox.Show("Equipo de tipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Equipo de tipo");
            }
         }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter();
        }
    }
}
