﻿using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.Brands
{
    public partial class BrandControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private BrandControlForm brandForm;
        public BrandControl()
        {
            InitializeComponent();
            GetList();
        }

        private void GetList()
        {

            try
            {
                dgvMarca.DataSource = audiovisualEntities.Brands.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    Estado = s.BrandsState.Description,
                    Descripcion = s.Description,
                    Existe = s.Enabled
                }).ToList();
                dgvMarca.Refresh();
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
                var marcas = from data in audiovisualEntities.Brands
                             where (
                                       data.Description.Contains(txtBuscarMarca.Text)
                                    )
                             select data;

                dgvMarca.DataSource = null;
                dgvMarca.DataSource = marcas.ToList();
            }
            catch (Exception ex)
            {

                Common.Util.MessageError("No pudimos ejecutar la consulta " + ex.Message);
            }

        }

        private void btnDeleteMarca_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvMarca.Rows[dgvMarca.CurrentRow.Index].Cells[0].Value.ToString());
                var data = audiovisualEntities.Brands.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Marca eliminada con exito");
                    GetList();
                }
                else
                    MessageBox.Show("Marca no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar la marca");
            }
        }

        private void btnUpdateMarca_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMarca.Rows[dgvMarca.CurrentRow.Index].Cells[0].Value.ToString());
            brandForm = new BrandControlForm(id);
            brandForm.ShowDialog();
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            brandForm = new BrandControlForm();
            brandForm.ShowDialog();
        }

        private void btnRefreshMarca_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnSearchMarca_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            //Configuration file header y declare variable;
            string headerCsv, path = string.Empty;
            headerCsv = "Descripcion,Estado,Activo";

            //open dialog and get pathDirectory
            path = Util.OpenSaveFileDialog();

            if (path != null && !string.IsNullOrWhiteSpace(path))
            {
                ExportCsv exportCsv = new ExportCsv(path);
                exportCsv.WriteFileHeader(headerCsv);
                var brands = audiovisualEntities.Brands.ToList();
                foreach (Brand data in brands)
                {
                    //Data to insert into body
                    string linea = string.Format("{0},{1},{2}",
                        data.Description,
                        data.BrandsState.Description,
                        data.Enabled);

                    exportCsv.WriteFileLine(linea);
                }
            };

        }

    }
}
