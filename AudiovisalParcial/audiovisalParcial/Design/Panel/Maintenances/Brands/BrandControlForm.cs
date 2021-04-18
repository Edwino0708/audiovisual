using audiovisalParcial.Common;
using audiovisalParcial.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.Brands
{
    public partial class BrandControlForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Brand data;
        private int id = 0;
        public BrandControlForm(int id = 0)
        {
            InitializeComponent();
            LoadComboBox();
            this.id = id;
            if (id > 0)
            {
                FindBrand();
            }
        }

        private void FindBrand()
        {
            var data = audiovisualEntities.Brands.Find(id);
            if (data != null)
            {
                txtDescriptionMarca.Text = data.Description;
                cbxStateMarca.SelectedValue = data.StateId;
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
                List<BrandsState> listStates = audiovisualEntities.BrandsStates.Select(s => s).Where(w => w.Enabled != false).ToList();
                foreach (var item in listStates)
                {
                    ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Description, item.Id);
                    listItem.Add(comboxBoxItem);
                }

                cbxStateMarca.DataSource = listItem;
                cbxStateMarca.DisplayMember = "Name";
                cbxStateMarca.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Common.Util.MessageError(ex.Message);
            }
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item = (ComboBoxItem)cbxStateMarca.SelectedItem;

                int state = item.Value;
                string description = txtDescriptionMarca.Text;
                data = new Brand();

                if (id == 0)
                {

                    data.Description = description;
                    data.StateId = state;
                    data.Enabled = true;
                    audiovisualEntities.Brands.Add(data);
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    data = audiovisualEntities.Brands.Find(id);
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

        private void txtDescriptionMarca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescriptionMarca.Text.ToString()) && !string.IsNullOrEmpty(cbxStateMarca.SelectedValue.ToString()))
                btnAddMarca.Enabled = true;
        }
    }
}
