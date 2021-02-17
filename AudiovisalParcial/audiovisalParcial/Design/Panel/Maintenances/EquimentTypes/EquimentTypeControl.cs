using audiovisalParcial.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.EquipmentType
{
    public partial class EquipmentTypeControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private EquipmentTypeControlForm createForm; 

        public EquipmentTypeControl()
        {
            InitializeComponent();
            GetList();
        }

        #region Private Methods
        private void GetList()
         {
    
            try
            {
                dgvListEquipmentType.DataSource = audiovisualEntities.EquimentTypes.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    Estado = s.EquimentTypesState.Description,
                    Descripcion = s.Description,
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


                var modelos = from data in audiovisualEntities.EquimentTypes
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
            Filter();
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            createForm = new EquipmentTypeControlForm();
            createForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnDeleteEquipmentType_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.EquimentTypes.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Equipo de tipo eliminado con exito");
                    GetList();
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
