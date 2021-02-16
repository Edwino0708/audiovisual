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

namespace audiovisalParcial.Design.Panel.Models
{
    public partial class ModelsForm : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private Model.Model model;
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
                model = new Model.Model();

                if (id == 0)
                {

                    model.Description = description;
                    model.BranksId = marca;
                    model.StateId = state;
                    audiovisualEntities.Models.Add(model);
                    audiovisualEntities.SaveChanges();
                    Utils.Utils.Message("Datos fueron insertados correctamente");
                    this.Close();
                }
                else
                {
                    model = audiovisualEntities.Models.Find(id);
                    model.Description = description;
                    model.StateId = state;
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

        private void FindModel()
        {
            var model = audiovisualEntities.Models.Find(id);
            if (model != null)
            {
                txtDescription.Text = model.Description;
                cbxState.SelectedValue = model.StateId;
                cbxMarca.SelectedValue = model.BranksId;
            }
            else
            {
                Utils.Utils.MessageError("Error en buscar este dato");
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

                cbxMarca.DataSource = listMarcas;
                cbxMarca.DisplayMember = "Name";
                cbxMarca.ValueMember = "Value";

                cbxMarca.DataSource = listItem;
                cbxMarca.DisplayMember = "Name";
                cbxMarca.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                Utils.Utils.MessageError(ex.Message);
            }
        }
    }
}
