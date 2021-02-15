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

namespace audiovisalParcial.Design.Panel.EquipmentType
{
    public partial class EquipmentTypeControlForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private EquimentType equimentTypes;
        private int id = 0;
        public EquipmentTypeControlForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;
            if (id > 0) 
            {
                FindEquimentType();
            }
        }

        private void btnAddEquipmentType_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item = (ComboBoxItem)cbxState.SelectedItem;
                
                int state = item.Value;
                string description = txtDescription.Text;
                equimentTypes = new EquimentType();

                if (id == 0)
                {
                    
                    equimentTypes.Description = description;
                    equimentTypes.StateId = state;
                    audiovisualEntities.EquimentTypes.Add(equimentTypes);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    equimentTypes = audiovisualEntities.EquimentTypes.Find(id);
                    equimentTypes.Description = description;
                    equimentTypes.StateId = state;
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

        private void FindEquimentType() 
        {
            var equimentTypes = audiovisualEntities.EquimentTypes.Find(id);
            if (equimentTypes != null)
            {
                txtDescription.Text = equimentTypes.Description;
                cbxState.SelectedValue = equimentTypes.StateId;
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
                List<EquimentTypesState> listStates = audiovisualEntities.EquimentTypesStates.Select(s => s).Where(w => w.Enabled != false).ToList();
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
