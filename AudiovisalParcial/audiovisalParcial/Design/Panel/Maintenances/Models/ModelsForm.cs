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

namespace audiovisalParcial.Design.Panel.Models
{
    public partial class ModelsForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Model.Model data;
        private int id = 0;

        public ModelsForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;
            if (id > 0)
            {
                FindModel();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item = (ComboBoxItem)cbxState.SelectedItem;
                ComboBoxItem item2 = (ComboBoxItem)cbxMarca.SelectedItem;

                int state = item.Value;
                int marca = item2.Value;
                string description = txtDescription.Text;
                data = new Model.Model();

                if (id == 0)
                {

                    data.Description = description;
                    data.BranksId = marca;
                    data.StateId = state;
                    data.Enabled = true;
                    audiovisualEntities.Models.Add(data);
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    data = audiovisualEntities.Models.Find(id);
                    data.Description = description;
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

        private void FindModel()
        {
            var data = audiovisualEntities.Models.Find(id);
            if (data != null)
            {
                txtDescription.Text = data.Description;
                cbxState.SelectedValue = data.StateId;
                cbxMarca.SelectedValue = data.BranksId;
            }
            else
            {
                Common.Util.MessageError("Error en buscar este dato");
            }
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            List<ComboBoxItem> listMarcas = new List<ComboBoxItem>();

            try
            {
                List<BrandsState> listStates = audiovisualEntities.BrandsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                List<Brand> listBrands = audiovisualEntities.Brands.Select(s => s).Where(w => w.Enabled != false).ToList();

                foreach (var item in listStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                foreach (var item in listBrands)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listMarcas.Add(comboxBoxItem);
                }

                cbxState.DataSource = listItem;
                cbxState.DisplayMember = "Name";
                cbxState.ValueMember = "Value";

                cbxMarca.DataSource = listMarcas ;
                cbxMarca.DisplayMember = "Name";
                cbxMarca.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if (!string.IsNullOrEmpty(txtDescription.Text.ToString()) && !string.IsNullOrEmpty(cbxMarca.Text.ToString()) && !string.IsNullOrEmpty(cbxState.SelectedValue.ToString()))
                btnCreate.Enabled = true;
            
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text.ToString()) && !string.IsNullOrEmpty(cbxMarca.Text.ToString()) && !string.IsNullOrEmpty(cbxState.SelectedValue.ToString()))
                btnCreate.Enabled = true;
        }

        private void cbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text.ToString()) && !string.IsNullOrEmpty(cbxMarca.Text.ToString()) && !string.IsNullOrEmpty(cbxState.SelectedValue.ToString()))
                btnCreate.Enabled = true;
        }
    }
}
