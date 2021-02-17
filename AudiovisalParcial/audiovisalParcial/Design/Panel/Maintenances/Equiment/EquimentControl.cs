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

namespace audiovisalParcial.Design.Panel.Equiment
{
    public partial class EquimentControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private EquimentForm createForm;

        public EquimentControl()
        {
            InitializeComponent();
            GetList();

        }
        #region Private Methods
        private void GetList()
        {

            try
            {
                dgvListEquipmentType.DataSource = audiovisualEntities.Equiments.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    Descripcion = s.Description,
                    Marca = s.BrandId,
                    Modelo = s.ModelsId,
                    Serial = s.Serial,
                    ServiceTag = s.ServiceTag,
                    TechnologyConexion = s.TechnologiesConnectionId,
                    EquipmentType = s.EquimentTypesId,
                    Estado = s.EquimentsState.Description,
                    Existe = s.Enabled
                }).ToList();
                dgvListEquipmentType.Refresh();
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void Filter()
        {
            try
            {

                var modelos = from data in audiovisualEntities.Equiments
                              where (
                                        data.Description.Contains(txtBuscar.Text) 
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createForm = new EquimentForm();
            createForm.ShowDialog();
        }


        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new EquimentForm(id);
            createForm.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.Equiments.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Equipo eliminado con exito");
                    GetList();
                }
                else
                    MessageBox.Show("Equipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Equipo");
            }
        }
    }
}
