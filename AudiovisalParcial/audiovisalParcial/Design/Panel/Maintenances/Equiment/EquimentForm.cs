using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            cbxModel.Enabled = false;
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
                Common.Util.MessageError("Error en buscar este dato");
            }
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem;
            try
            {
                listItem = new List<ComboBoxItem>();
                List<Brand> listBrand = audiovisualEntities.Brands.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listBrand)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxMarca.DataSource = listItem;
                cbxMarca.DisplayMember = "Name";
                cbxMarca.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.TechnologiesConnection> listTech = audiovisualEntities.TechnologiesConnections.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listTech)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxTypeTecnology.DataSource = listItem;
                cbxTypeTecnology.DisplayMember = "Name";
                cbxTypeTecnology.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.EquimentType> listTypes = audiovisualEntities.EquimentTypes.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listTypes)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxType.DataSource = listItem;
                cbxType.DisplayMember = "Name";
                cbxType.ValueMember = "Value";

                listItem = new List<ComboBoxItem>();
                List<Model.EquimentsState> listEquiments = audiovisualEntities.EquimentsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listEquiments)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxState.DataSource = listItem;
                cbxState.DisplayMember = "Name";
                cbxState.ValueMember = "Value";

                

                //listItem = new List<ComboBoxItem>();
                //List<Model.EmployeesState> listStates = audiovisualEntities.EmployeesStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                //foreach (var item in listStates)
                //{
                //    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                //    listItem.Add(comboxBoxItem);
                //}

                //cbxState.DataSource = listItem;
                //cbxState.DisplayMember = "Name";
                //cbxState.ValueMember = "Value";


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

                item = (ComboBoxItem)cbxState.SelectedItem;
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
                    Common.Util.Message("Datos fueron insertados correctamente");
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
                    Common.Util.Message("Datos fueron actualizado correctamente");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int brandBoxId = int.Parse(cbxMarca.SelectedValue.ToString());

            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            List<Model.Model> listModel = audiovisualEntities.Models.Select(s => s).Where(w => w.Enabled != false && w.BranksId == brandBoxId).ToList();
            foreach (var item in listModel)
            {
                ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                listItem.Add(comboxBoxItem);
            }

            cbxModel.DataSource = listItem;
            cbxModel.DisplayMember = "Name";
            cbxModel.ValueMember = "Value";
            cbxModel.Enabled = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void txtServiceTag_TextChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void cbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void cbxTypeTecnology_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidForm();
        }

        private void ValidForm()
        {
            if (!string.IsNullOrEmpty(txtDescription.Text.ToString()) &&
                !string.IsNullOrEmpty(txtSerial.Text.ToString()) &&
                !string.IsNullOrEmpty(txtServiceTag.Text.ToString()) &&
                !string.IsNullOrEmpty(cbxMarca.SelectedValue.ToString()) &&
                !string.IsNullOrEmpty(cbxState.SelectedValue.ToString()) &&
                !string.IsNullOrEmpty(cbxModel.SelectedValue.ToString()) &&
                !string.IsNullOrEmpty(cbxTypeTecnology.SelectedValue.ToString()))
                btnSave.Enabled = true;

        }
    }
}
