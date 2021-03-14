using audiovisalParcial.Design.Panel.EquipmentType;
using audiovisalParcial.Design.Panel.Reports;
using audiovisalParcial.Design.Panel.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Menu.Maintances
{
    public partial class ReportMenuControl : UserControl
    {
        private HomeControl form;
        EquimentTypeReportControl equimentTypeReportControl;
        public ReportMenuControl(HomeControl form)
        {
            InitializeComponent(); 
            this.form = form;
            equimentTypeReportControl = new EquimentTypeReportControl();
        }


        private void btnReportOption1_Click(object sender, EventArgs e)
        {
            var body = this.form.getPanelBody();
            body.Controls.Clear();
            body.Controls.Add(equimentTypeReportControl);
        }
        private void btnReportOption2_Click(object sender, EventArgs e)
        {

        }
        private void btnReportOption3_Click(object sender, EventArgs e)
        {

        }
        private void btnReportOption4_Click(object sender, EventArgs e)
        {

        }
        private void btnReportOption5_Click(object sender, EventArgs e)
        {

        }
        private void btnReportOption6_Click(object sender, EventArgs e)
        {
        
        }
        private void btnReportOption7_Click(object sender, EventArgs e)
        {

        }
        private void btnReportOption8_Click(object sender, EventArgs e)
        {

        }
    }
}
