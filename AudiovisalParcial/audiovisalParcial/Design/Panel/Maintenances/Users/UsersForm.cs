using audiovisalParcial.Model;
using audiovisalParcial.Common;
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
                ComboBoxItem item, itemState, itemUserType, itemPersonalTtype;
                string firstName = txbFirstName.Text;
                string lastName = txbLastName.Text;
                string identificactionCard = string.Empty;
                if (Common.Util.ValideIdentificactionCard(txbIdentificationCard.Text) != false)
                {
                    identificactionCard = txbIdentificationCard.Text;
                }
                else 
                {
                    Common.Util.MessageError("La cedula esta incorrecta");
                    return;
                }
                string carnet = txbCarnet.Text;
                itemState = (ComboBoxItem)cbxState.SelectedItem;
                int stateId = itemState.Value;
                itemUserType = (ComboBoxItem)cbxUserType.SelectedItem;
                int userTypeId = itemUserType.Value;
                itemPersonalTtype = (ComboBoxItem)cbxPersonalTtype.SelectedItem;
                int personalTypeId = itemPersonalTtype.Value;
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

                    UserLogin login = new UserLogin();
                    login.username = data.FirstName;
                    login.password = Util.EncryptionPassowrd(data.IdentificationCard);
                    login.isActive = true;
                    login.role = itemUserType.Name;
                    audiovisualEntities.UserLogins.Add(login);
                    audiovisualEntities.SaveChanges();

                    Common.Util.Message("Datos fueron insertados correctamente");
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
                    Common.Util.Message("Datos fueron actualizado correctamente");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
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
                Common.Util.MessageError("Error en buscar este dato");
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
                Common.Util.MessageError(ex.Message);
            }
        }

    }
}
