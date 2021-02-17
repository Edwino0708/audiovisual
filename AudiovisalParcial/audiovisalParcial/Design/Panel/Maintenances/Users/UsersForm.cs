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

namespace audiovisalParcial.Design.Panel.Users
{
    public partial class UsersForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private int id;

        public UsersForm(int id = 0)
        {
            InitializeComponent(); 
            LoadComboBox();
            this.id = id;
            if (id > 0)
            {
                Find();
            }
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item;
                string firstName = txbFirstName.Text;
                string lastName = txbLastName.Text;
                string identificactionCard = string.Empty;
                if (Utils.Utils.ValideIdentificactionCard(txbIdentificationCard.Text) != false)
                {
                    identificactionCard = txbIdentificationCard.Text;
                }
                else 
                {
                    Utils.Utils.MessageError("La cedula no se cuentra en el formato correcto, por favor vuelva intentarlo");
                    return;
                }
                string carnet = txbCarnet.Text;
                item = (ComboBoxItem)cbxState.SelectedItem;
                int stateId = item.Value;
                item = (ComboBoxItem)cbxUserType.SelectedItem;
                int userTypeId = item.Value;
                item = (ComboBoxItem)cbxPersonalTtype.SelectedItem;
                int personalTypeId = item.Value;
                User data = new User();

                if (id == 0)
                {

                    data.FirstName = firstName;
                    data.LastName = lastName;
                    data.IdentificationCard = identificactionCard;
                    data.Carnet = carnet;
                    data.FirstName = firstName;
                    data.UsersTypesId = userTypeId;
                    data.PersonalTypesID = personalTypeId;
                    data.StateId = stateId;
                    data.Enabled = true;
                    audiovisualEntities.Users.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {

                    data.FirstName = firstName;
                    data.LastName = lastName;
                    data.IdentificationCard = identificactionCard;
                    data.Carnet = carnet;
                    data.FirstName = firstName;
                    data.UsersTypesId = userTypeId;
                    data.PersonalTypesID = personalTypeId;
                    data.StateId = stateId;
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

        private void Find()
        {
            var search = audiovisualEntities.Users.Find(this.id);
            if (search != null)
            {
                txbFirstName.Text = search.FirstName;
                txbLastName.Text = search.LastName;
                txbIdentificationCard.Text = search.IdentificationCard;
                txbCarnet.Text = search.Carnet;
                cbxPersonalTtype.SelectedValue = search.PersonalTypesID;
                cbxUserType.SelectedValue = search.UsersTypesId;
                cbxState.SelectedValue = search.StateId;
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
                List<UsersType> listUserTypeStates = audiovisualEntities.UsersTypes.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listUserTypeStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxUserType.DataSource = listItem;
                cbxUserType.DisplayMember = "Name";
                cbxUserType.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<PersonalType> listPersonalTypeStates = audiovisualEntities.PersonalTypes.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listPersonalTypeStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxPersonalTtype.DataSource = listItem;
                cbxPersonalTtype.DisplayMember = "Name";
                cbxPersonalTtype.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<UsersState> listStates = audiovisualEntities.UsersStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxState.DataSource = listItem;
                cbxState.DisplayMember = "Name";
                cbxState.ValueMember = "Value";

            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }
        }

    }
}
