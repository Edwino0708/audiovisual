using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;

namespace audiovisalParcial.Design.Panel.Maintenances.RentReturns
{
    public partial class RentReturnsForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private RentReturn data;

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
                List<Model.Equiment> listEquipo = audiovisualEntities.Equiments.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<User> listUsuario = audiovisualEntities.Users.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<EquimentsState> listRentState = audiovisualEntities.EquimentsStates.Select(s => s).ToList();

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


                cbxEmpleados.DataSource = listEmpleados;
                cbxEmpleados.DisplayMember = "Name";
                cbxEmpleados.ValueMember = "Value";

                cbxEquipo.DataSource = listEquipos;
                cbxEmpleados.DisplayMember = "Name";
                cbxEmpleados.ValueMember = "Value";

                cbxUsuario.DataSource = listUsuarios;
                cbxUsuario.DisplayMember = "Name";
                cbxUsuario.ValueMember = "Value";

            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item;

                item = (ComboBoxItem)cbxEmpleados.SelectedItem;
                int empleado = item.Value;
                item = (ComboBoxItem)cbxEquipo.SelectedItem;
                int equipo = item.Value;
                item = (ComboBoxItem)cbxUsuario.SelectedItem;
                int usuario = item.Value;
                string noPay = txtNoPrestamo.Text;
                DateTime fechaprestamo = Convert.ToDateTime(dtFechaPrestamo.Text);
                DateTime fechadevolucion = Convert.ToDateTime(dtFechaDevolucion.Text);
                string comentario = txtComentario.Text;

                Model.Equiment f = (from x in audiovisualEntities.Equiments
                                    where x.Id == equipo
                                    select x).First();
                f.StateId = 3;
                audiovisualEntities.SaveChanges();

                data = new RentReturn();
                    data.NoPay = noPay;
                    data.EmployeeId = empleado;
                    data.EquimentId = equipo;
                    data.UserId = usuario;
                    data.LoanDate = fechaprestamo;
                    data.ReturnDate = fechadevolucion;
                    data.Comentary = comentario;
                    audiovisualEntities.RentReturns.Add(data);
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Datos fueron insertados correctamente");
                    this.Close();

            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }
    }
}
