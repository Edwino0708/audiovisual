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

namespace audiovisalParcial.Design.Panel.Maintenances.Brands
{
    public partial class BrandControlForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Brand brand;
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
            var brand = audiovisualEntities.Brands.Find(id);
            if (brand != null)
            {
                txtDescriptionMarca.Text = brand.Description;
                cbxStateMarca.SelectedValue = brand.StateId;
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
                Utils.Utils.MessageError(ex.Message);
            }
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem item = (ComboBoxItem)cbxStateMarca.SelectedItem;

                int state = item.Value;
                string description = txtDescriptionMarca.Text;
                brand = new Brand();

                if (id == 0)
                {

                    brand.Description = description;
                    brand.StateId = state;
                    audiovisualEntities.Brands.Add(brand);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    brand = audiovisualEntities.Brands.Find(id);
                    brand.Description = description;
                    brand.StateId = state;
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
