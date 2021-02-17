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
       private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
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
                Utils.Utils.MessageError("Error al cargar datos: " + ex.Message);
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
                    Utils.Utils.Message("Modelo eliminada con exito");
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
    }
}
