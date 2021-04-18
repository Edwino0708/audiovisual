using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Users
{
    public partial class UsersControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private UsersForm createForm;

        public UsersControl()
        {
            InitializeComponent();
            GetList();
        }

        #region Private Methods
        private void GetList()
        {

            try
            {
                dgvListEquipmentType.DataSource = null;
                dgvListEquipmentType.DataSource = audiovisualEntities.Users.Where(w => w.Enabled == true).Select(s => new
                {
                    Id = s.Id,
                    Nombre = s.FirstName,
                    Apellido = s.LastName,
                    Cedula = s.IdentificationCard,
                    No_Carnet = s.Carnet,
                    Tipo_Usuario = s.UsersType.Description,
                    Tipo_Persona = s.PersonalType.Description,
                    Estado = s.UsersState.Description,
                    Activo = s.Enabled
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

                dgvListEquipmentType.DataSource = null;
                var search = from data in audiovisualEntities.Users
                             where (
                                       data.FirstName.Contains(txtBuscar.Text) ||
                                       data.LastName.Contains(txtBuscar.Text) ||
                                       data.IdentificationCard.Contains(txtBuscar.Text)
                                    )
                             select data;
                dgvListEquipmentType.DataSource = search.ToList();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createForm = new UsersForm();
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new UsersForm(id);
            createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.Users.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Usuario eliminado con exito");
                    GetList();
                }
                else
                    MessageBox.Show("Usuario de tipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Usuario");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Configuration file header y declare variable;
            string headerCsv, path = string.Empty;
            headerCsv = "Nombre,Apellido,Cedula,Carnet,Tipo de personal,Tipo usuario,Estado,Activo";

            //open dialog and get pathDirectory
            path = Util.OpenSaveFileDialog();

            if (path != null && !string.IsNullOrWhiteSpace(path))
            {
                ExportCsv exportCsv = new ExportCsv(path);
                exportCsv.WriteFileHeader(headerCsv);
                var dataToExport = audiovisualEntities.Users.ToList();
                foreach (User data in dataToExport)
                {
                    //Data to insert into body
                    string linea = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                        data.FirstName,
                        data.LastName,
                        data.IdentificationCard,
                        data.Carnet,
                        data.PersonalType.Description,
                        data.UsersType.Description,
                        data.UsersState.Description,
                        data.Enabled);

                    exportCsv.WriteFileLine(linea);
                }
            };

        }
    }
}
