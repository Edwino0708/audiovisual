using audiovisalParcial.Model;
using audiovisalParcial.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.Employees
{
    public partial class EmployeesForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private int id = 0;
     
        public EmployeesForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;

            if (this.id != 0)  
                FindEmployee(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                var apellido = txtApellido.Text;
                var nombre = txtNombre.Text;
                ComboBoxItem item = (ComboBoxItem)comboBox1.SelectedItem;
                var fecha = dtFecha.Value;
                var cedula = txtCedula.Text;
                var state = item.Value;
                Employee data = new Employee();
                if (!Utils.Utils.ValideIdentificactionCard(cedula))
                {
                    Utils.Utils.MessageError("Cedula Invalida");
                    return;
                }
                if (id == 0)
                {
                    data.FirstName = nombre;
                    data.LastName = apellido;
                    data.IdentificationCard = cedula;
                    data.StateId = state;
                    data.HiredDate = fecha;
                    data.Workshift = "-";
                    data.Enabled = true;
                    audiovisualEntities.Employees.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    data = audiovisualEntities.Employees.Find(id);
                    data.FirstName = nombre;
                    data.LastName = apellido;
                    data.IdentificationCard = cedula;
                    data.StateId = state;
                    data.HiredDate = fecha;
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron actualizado correctamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }

        }

        private void FindEmployee()
        {
            var employe = audiovisualEntities.Employees.Find(id);
            if (employe != null)
            {
                txtNombre.Text = employe.FirstName;
                txtApellido.Text = employe.LastName;
                txtCedula.Text = employe.IdentificationCard;

            }
            else
            {
                Utils.Utils.MessageError("Error en buscar este dato");
            }
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();

            try
            {
                List<EmployeesState> listStates = audiovisualEntities.EmployeesStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                comboBox1.DataSource = listItem;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }



}
