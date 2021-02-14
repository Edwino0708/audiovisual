﻿using audiovisalParcial.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Users
{
    public partial class UsersControl : UserControl
    {
        private AUDIOVISUALESEntities audiovisualEntities = new AUDIOVISUALESEntities();
        private UsersForm createForm;
        public UsersControl()
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
                dgvListEquipmentType.DataSource = audiovisualEntities.usuarios.ToList();
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

                //var modelos = from data in audiovisualEntities.usuarios
                //              where (
                //                        data.Id == int.Parse(txtBuscar.Text) ||
                //                        data.Descripcion.Contains(txtBuscar.Text) ||
                //                        data.Estado == int.Parse(txtBuscar.Text)
                //                     )
                //              select data;

                //dgvListEquipmentType.DataSource = null;
                //dgvListEquipmentType.DataSource = modelos.ToList();
            }
            catch (Exception ex)
            {

                Utils.Utils.MessageError("No pudimos ejecutar la consulta " + ex.Message);
            }

        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListEquipmentType.Rows[dgvListEquipmentType.CurrentRow.Index].Cells[0].Value.ToString());
            //createForm = new UsersForm(id);
            //createForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
