using audiovisalParcial.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Reports
{
    public partial class EquimentReport : Form
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();

        public EquimentReport()
        {
            InitializeComponent();
        }

        private void EquimentReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportEquiment.rdlc";
            var equimentList = audiovisualEntities.Equiments.ToList();

            List<EquimentReportModel> dataSource = new List<EquimentReportModel>();
            foreach (var item in equimentList)
            {
                EquimentReportModel equiment = new EquimentReportModel();
                equiment.Description = item.Description;
                equiment.Serial = item.Serial;
                equiment.EquimentType = (item.EquimentType != null) ? item.EquimentType.Description : string.Empty;
                equiment.Brand = (item.Brand != null) ? item.Brand.Description : string.Empty;
                equiment.Model = (item.Model != null) ? item.Model.Description : string.Empty;
                equiment.TechnologiesConnection = (item.TechnologiesConnection != null) ? item.TechnologiesConnection.Description : string.Empty;
                equiment.State = (item.EquimentsState != null) ? item.EquimentsState.Description : string.Empty;
                equiment.Enabled = item.Enabled;
                dataSource.Add(equiment);
            }
            ReportDataSource rds = new ReportDataSource("ReportEquiment", dataSource);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

        }
    }
}
