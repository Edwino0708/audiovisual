using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.RentReturns
{
    public partial class RentReturnsForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        public RentReturnsForm()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listEmpleados = new List<ComboBoxItem>();
            List<ComboBoxItem> listEquipos = new List<ComboBoxItem>();
            List<ComboBoxItem> listUsuarios = new List<ComboBoxItem>();
            List<ComboBoxItem> listRentStates = new List<ComboBoxItem>();

            try
            {
                List<Employee> listEmpleado = audiovisualEntities.Employees.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<Equiments> listEquipo = audiovisualEntities.Equiments.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<Users> listUsuario = audiovisualEntities.Users.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<RentReturnStates> listRentState = audiovisualEntities.RentReturnStates.Select(s => s).Where(w => w.Enabled != false).ToList();

                foreach (var item in listEmpleado)
                {
                    ComboBoxItem comboxBoxEmpleados = new ComboBoxItem(item.FirstName, item.Id);
                    listEmpleados.Add(comboxBoxEmpleados);
                }
                foreach (var item in listEquipo)
                {
                    ComboBoxItem comboxBoxEquipos = new ComboBoxItem(item.Description, item.Id);
                    listEquipos.Add(comboxBoxEquipos);
                }

                foreach (var item in listUsuario)
                {
                    ComboBoxItem comboxBoxUsuarios = new ComboBoxItem(item.FirstName, item.Id);
                    listUsuarios.Add(comboxBoxUsuarios);
                }

                foreach (var item in listRentState)
                {
                    ComboBoxItem comboxBoxRentState = new ComboBoxItem(item.Description, item.Id);
                    listRentStates.Add(comboxBoxRentState);
                }

                cbxEmpleados.DataSource = listEmpleados;
                cbxEmpleados.DisplayMember = "Name";
                cbxEmpleados.ValueMember = "Value";

                cbxEquipo.DataSource = listEquipos;
                cbxEmpleados.DisplayMember = "Name";
                cbxEmpleados.ValueMember = "Value";

                cbxUsuario.DataSource = listUsuarios;
                cbxUsuario.DisplayMember = "Name";
                cbxUsuario.ValueMember = "Value";

                cbxRentEstado.DataSource = listRentStates;
                cbxRentEstado.DisplayMember = "Name";
                cbxRentEstado.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }


        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
