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

namespace audiovisalParcial.Design.Panel.TechnologiesConnection
{
    public partial class TechnologiesConnectionForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Model.TechnologiesConnection data;
        private int id = 0;

        public TechnologiesConnectionForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;
            if (id > 0)
            {
                FindData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            { 
                ComboBoxItem item = (ComboBoxItem)cbxState.SelectedItem;

                int state = item.Value;
                string description = txtDescription.Text;
                data = new Model.TechnologiesConnection();

                if (id == 0)
                {
                    data.Description = description;
                    data.StateId = state;
                    data.Enabled = true;
                    audiovisualEntities.TechnologiesConnections.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    var data = audiovisualEntities.TechnologiesConnections.Find(id);
                    data.Description = description;
                    data.StateId = state;
                    data.Enabled = true;
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

        private void FindData()
        {
            var data = audiovisualEntities.TechnologiesConnections.Find(id);
            if (data != null)
            {
                txtDescription.Text = data.Description;
                cbxState.SelectedValue = data.StateId;
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
                List<TechnologiesConnectionState> listStates = audiovisualEntities.TechnologiesConnectionStates.Select(s => s).Where(w => w.Enabled != false).ToList();
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
