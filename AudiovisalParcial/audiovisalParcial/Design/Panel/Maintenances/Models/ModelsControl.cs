using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Models
{
    public partial class ModelsControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private ModelsForm createForm;

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
                dgvModelo.DataSource = audiovisualEntities.Models.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    Estado = s.ModelsState.Description,
                    Descripcion = s.Description,
                    Existe = s.Enabled
                }).ToList();
                dgvModelo.Refresh();
            }
            catch (Exception ex)
            {
                Common.Util.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void filter()
        {
            try
            {
                dgvModelo.DataSource = null;
                var modelos = from data in audiovisualEntities.Models
                              where (
                                        data.Description.Contains(txtBuscarModelo.Text)
                                      )
                              select data;

                dgvModelo.DataSource = modelos.ToList();
            }
            catch (Exception ex)
            {

                Common.Util.MessageError("No pudimos ejecutar la consulta " + ex.Message);
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
            int id = int.Parse(dgvModelo.Rows[dgvModelo.CurrentRow.Index].Cells[0].Value.ToString());
            createForm = new ModelsForm(id);
            createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvModelo.Rows[dgvModelo.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.Models.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Modelo eliminada con exito");
                    getList();
                }
                else
                    MessageBox.Show("Modelo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el modelo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Configuration file header y declare variable;
            string headerCsv, path = string.Empty;
            headerCsv = "Descripcion,Marca,Estado,Activo";

            //open dialog and get pathDirectory
            path = Util.OpenSaveFileDialog();

            if (path != null && !string.IsNullOrWhiteSpace(path))
            {
                ExportCsv exportCsv = new ExportCsv(path);
                exportCsv.WriteFileHeader(headerCsv);
                var dataToExport = audiovisualEntities.Models.ToList();
                foreach (Model.Model data in dataToExport)
                {
                    //Data to insert into body
                    string linea = string.Format("{0},{1},{2},{3}",
                        data.Description,
                        data.Brand.Description,
                        data.ModelsState.Description,
                        data.Enabled);

                    exportCsv.WriteFileLine(linea);
                }
            };

        }
    }
}
