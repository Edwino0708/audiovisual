using System;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Reports
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void btnequipoRep_Click(object sender, EventArgs e)
        {
            EquimentReport equimentReport = new EquimentReport();
            equimentReport.Show();
        }
    }
}
