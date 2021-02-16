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

namespace audiovisalParcial.Design.Panel.Equiment
{
    public partial class EquimentForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Model.Equiment data;
        private int id = 0;

        public EquimentForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;
            if (id > 0)
            {
                Find();
            }
        }


        private void Find()
        {
            var data = audiovisualEntities.Equiments.Find(id);
            if (data != null)
            {
                txtDescription.Text = data.Description;
                cbxState.SelectedValue = data.StateId;
                txtSerial.Text = data.Serial;
                txtServiceTag.Text = data.ServiceTag;
            }
            else
            {
                Utils.Utils.MessageError("Error en buscar este dato");
            }
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem;
            try
            {
                listItem = new List<ComboBoxItem>();
                List<BrandsState> listBrand = audiovisualEntities.BrandsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listBrand)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxMarca.DataSource = listItem;
                cbxMarca.DisplayMember = "Name";
                cbxMarca.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.ModelsState> listModel = audiovisualEntities.ModelsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listModel)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxModel.DataSource = listItem;
                cbxModel.DisplayMember = "Name";
                cbxModel.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.TechnologiesConnectionState> listTech = audiovisualEntities.TechnologiesConnectionStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listTech)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxTypeTecnology.DataSource = listItem;
                cbxTypeTecnology.DisplayMember = "Name";
                cbxTypeTecnology.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.EquimentTypesState> listTypes = audiovisualEntities.EquimentTypesStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listTypes)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxType.DataSource = listItem;
                cbxType.DisplayMember = "Name";
                cbxType.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.EquimentsState> listStates = audiovisualEntities.EquimentsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item;
                
                item =(ComboBoxItem)cbxState.SelectedItem;
                int state = item.Value;
                item = (ComboBoxItem)cbxMarca.SelectedItem;
                int marca = item.Value;
                item = (ComboBoxItem)cbxModel.SelectedItem;
                int model = item.Value;
                item = (ComboBoxItem)cbxType.SelectedItem;
                int type = item.Value;
                item = (ComboBoxItem)cbxTypeTecnology.SelectedItem;
                int typeTecnologia = item.Value;
                string description = txtDescription.Text;
                string serial = txtSerial.Text;
                string serviceTag = txtServiceTag.Text;


                if (id == 0)
                {
                    data = new Model.Equiment();
                    data.Description = description;
                    data.BrandId = marca;
                    data.ModelsId = model;
                    data.EquimentTypesId = type;
                    data.TechnologiesConnectionId = typeTecnologia;
                    data.Serial = serial;
                    data.ServiceTag = serviceTag;
                    data.StateId = state;
                    data.Enabled = true;
                    audiovisualEntities.Equiments.Add(data);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    var data = audiovisualEntities.Equiments.Find(id);
                    data.Description = description;
                    data.BrandId = marca;
                    data.ModelsId = model;
                    data.EquimentTypesId = type;
                    data.TechnologiesConnectionId = typeTecnologia;
                    data.Serial = serial;
                    data.ServiceTag = serviceTag;
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
    }
}
