using audiovisalParcial.Design.Panel.EquipmentType;
using audiovisalParcial.Design.Panel.Maintenances.Brands;
using audiovisalParcial.Design.Panel.Models;
using audiovisalParcial.Design.Panel.Users;
using audiovisalParcial.Design.Panel.TechnologiesConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using audiovisalParcial.Model;
using audiovisalParcial.Design.Panel.Equiment;

namespace audiovisalParcial.Design.Menu.Maintances
{
    public partial class MaintenanceMenuControl : UserControl
    {
        private Form1 form;
        private EquipmentTypeControl equimentType;
        private UsersControl user;
        private BrandControl brand;
        private ModelsControl model;
        private TechnologiesConnectionControl technologies;
        private EquimentControl equipo;

        public MaintenanceMenuControl(Form1 form)
        {
            InitializeComponent();
            this.form = form; 
            equimentType = new EquipmentTypeControl();
            user = new UsersControl();
            brand = new BrandControl();
            model = new ModelsControl();
            technologies = new TechnologiesConnectionControl();
            equipo = new EquimentControl();
        }


        private void btnMaintenanceOption1_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(equimentType);
        }
        private void btnMaintenanceOption2_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(brand);
        }
        private void btnMaintenanceOption3_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(model);
        }
        private void btnMaintenanceOption4_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(technologies);
        }
        private void btnMaintenanceOption5_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(equipo);
        }
        private void btnMaintenanceOption6_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(user);
        }
        private void btnMaintenanceOption7_Click(object sender, EventArgs e)
        {

        }
        private void btnMaintenanceOption8_Click(object sender, EventArgs e)
        {

        }
    }
}
