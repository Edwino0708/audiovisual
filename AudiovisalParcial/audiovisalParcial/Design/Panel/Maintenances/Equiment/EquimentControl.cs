using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Data;
using System.Linq;
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
                }).ToList();
                dgvListEquipmentType.Refresh();
            }
            catch (Exception ex)
            {
                Common.Util.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void Filter()
        {
            try
            {

                var equipos = from data in audiovisualEntities.Equiments
                              where (
                                        data.Description.Contains(txtBuscar.Text) ||
                                        data.Serial.Contains(txtBuscar.Text) ||
                                        data.ServiceTag.Contains(txtBuscar.Text)
                                     )
                              select data;

                dgvListEquipmentType.DataSource = null;
                dgvListEquipmentType.DataSource = equipos.ToList();
            }
            catch (Exception ex)
            {

                Common.Util.MessageError("No pudimos ejecutar la consulta " + ex.Message);
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new EquimentForm(id);
            createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.Equiments.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Equipo eliminado con exito");
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Configuration file header y declare variable;
            string headerCsv, path = string.Empty;
            headerCsv = "Descripcion,Serial,Tag Servicio,Modelo,Marca,Tecnologia Conexion,Estado,Activo";

            //open dialog and get pathDirectory
            path = Util.OpenSaveFileDialog();

            if (path != null && !string.IsNullOrWhiteSpace(path))
            {
                ExportCsv exportCsv = new ExportCsv(path);
                exportCsv.WriteFileHeader(headerCsv);
                var dataToExport = audiovisualEntities.Equiments.ToList();
                foreach (Model.Equiment data in dataToExport)
                {
                    //Data to insert into body
                    string linea = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                        data.Description,
                        data.Serial,
                        data.ServiceTag,
                        data.Model.Description,
                        data.Brand.Description,
                        data.TechnologiesConnection.Description,
                        data.EquimentsState.Description
                        );

                    exportCsv.WriteFileLine(linea);
                }
            };

        }
    }
}
