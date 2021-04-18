using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.Employees
{
    public partial class EmployeesControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = null;
        public EmployeesControl()
        {
            InitializeComponent();
            audiovisualEntities = new AudiovisualDbEntities();
            GetList();
        }

        #region Private Methods
        private void GetList()
        {
            var state = audiovisualEntities.EmployeesStates.Where(w => w.Enabled != false).ToList();
            //var stateId = state == null ? 0L : state[0].Id;

            try
            {
                dgvListEmployee.DataSource = audiovisualEntities.Employees.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    Nombre = s.FirstName,
                    Apellido = s.LastName,
                    Cedula = s.IdentificationCard,
                    Estado = s.StateId,
                    Fecha_Ingreso = s.HiredDate

                }).ToList();
                dgvListEmployee.Refresh();
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
                var empleados = from data in audiovisualEntities.Employees
                                where (
                                          data.FirstName.Contains(txtBuscar.Text) ||
                                          data.LastName.Contains(txtBuscar.Text) ||
                                          data.IdentificationCard.Contains(txtBuscar.Text)
                                       )
                                select data;

                dgvListEmployee.DataSource = null;
                dgvListEmployee.DataSource = empleados.ToList();
            }
            catch (Exception ex)
            {

                Common.Util.MessageError("No pudimos ejecutar la consulta " + ex.Message);
            }

        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListEmployee.Rows[dgvListEmployee.CurrentRow.Index].Cells[1].Value.ToString());
                var data = audiovisualEntities.Employees.Find(id);
                var state = audiovisualEntities.EmployeesStates.Where(w => w.Description == "Desactivado").ToList();

                if (data != null)
                {
                    data.StateId = state[0].Id;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Empleado de tipo eliminado con exito");
                    GetList();
                }
                else
                    MessageBox.Show("Empleado de tipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Empleado de tipo");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeesForm createForm = new EmployeesForm();
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dgvListEmployee.Rows[dgvListEmployee.CurrentRow.Index].Cells[1].Value.ToString());
            EmployeesForm createForm = new EmployeesForm(id);
            createForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Configuration file header y declare variable;
            string headerCsv, path = string.Empty;
            headerCsv = "Nombre,Apellido,Cedula,Turno de trabajo,Fecha de contratación,Estado,Activo";

            //open dialog and get pathDirectory
            path = Util.OpenSaveFileDialog();

            if (path != null && !string.IsNullOrWhiteSpace(path))
            {
                ExportCsv exportCsv = new ExportCsv(path);
                exportCsv.WriteFileHeader(headerCsv);
                var dataToExport = audiovisualEntities.Employees.ToList();
                foreach (Employee data in dataToExport)
                {
                    //Data to insert into body
                    string linea = string.Format("{0},{1},{2},{4},{5},{6}",
                        data.FirstName,
                        data.LastName,
                        data.IdentificationCard,
                        data.Workshift,
                        data.HiredDate,
                        data.EmployeesState.Description,
                        data.Enabled
                        );

                    exportCsv.WriteFileLine(linea);
                }
            };


        }
    }
}
