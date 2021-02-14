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

namespace audiovisalParcial.Design.Panel.EquipmentType
{
    public partial class EquipmentTypeControl : UserControl
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();


        private EquipmentTypeControlForm createForm; 
        public EquipmentTypeControl()
        {
            InitializeComponent();
            getListEquimentType();
        }

        #region Private Methods
        private void getListEquimentType()
         {
    
            try
            {
                dgvListEquipmentType.DataSource = null;
                dgvListEquipmentType.DataSource = audiovisualEntities.tipo_equipos.ToList();
                dgvListEquipmentType.Refresh();
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void getFilterEquimentType()
        {
            try
            {

                var modelos = from data in audiovisualEntities.modelos
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

        #endregion

        private void btnUpdateEquipmentType_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new EquipmentTypeControlForm(id);
            createForm.ShowDialog();
        }

        private void btnSearchEquipmentType_Click(object sender, EventArgs e)
        {
            getFilterEquimentType();
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            createForm = new EquipmentTypeControlForm();
            createForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getListEquimentType();
        }

        private void btnDeleteEquipmentType_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.tipo_equipos.Find(id);
                if (data != null)
                {
                    audiovisualEntities.tipo_equipos.Remove(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Equipo de tipo eliminado con exito");
                    getListEquimentType();
                }
                else
                    MessageBox.Show("Equipo de tipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Equipo de tipo");
            }
        }
    }
}
