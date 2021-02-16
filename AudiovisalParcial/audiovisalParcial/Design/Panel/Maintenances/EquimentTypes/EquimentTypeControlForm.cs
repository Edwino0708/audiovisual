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
        private EquimentType data;
        private int id = 0;
        public EquipmentTypeControlForm(int id = 0)
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
                ComboBoxItem item = (ComboBoxItem)cbxState.SelectedItem;
                
                int state = item.Value;
                string description = txtDescription.Text;
                data = new EquimentType();

                if (id == 0)
                {
                    
                    data.Description = description;
                    data.StateId = state;
                    audiovisualEntities.EquimentTypes.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    data = audiovisualEntities.EquimentTypes.Find(id);
                    data.Description = description;
                    data.StateId = state;
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
            var search = audiovisualEntities.EquimentTypes.Find(id);
            if (search != null)
            {
                txtDescription.Text = search.Description;
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
                List<EquimentType> listStates = audiovisualEntities.EquimentTypes.Select(s => s).Where(w => w.Enabled != false).ToList();
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
