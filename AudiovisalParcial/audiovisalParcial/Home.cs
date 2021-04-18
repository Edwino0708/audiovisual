using audiovisalParcial.Common;
using audiovisalParcial.Design.Menu.Maintances;
using audiovisalParcial.Design.Panel.Home;
using audiovisalParcial.Design.Panel.Reports;
using System;
using System.Windows.Forms;

namespace audiovisalParcial
{
    public partial class HomeControl : Form
    {
        private MaintenanceMenuControl maintenanceMenu;
        private ReportControl resportMenu;

        public HomeControl()
        {
            InitializeComponent();
            HideByRole();
            maintenanceMenu = new MaintenanceMenuControl(this);
            resportMenu = new ReportControl();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Storage.Login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pHeaderMenu.Controls.Clear();
            pHeaderMenu.Controls.Add(maintenanceMenu);
        }

        public Panel getPanelBody()
        {
            return pSubBody;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pBody.Controls.Clear();
            pBody.Controls.Add(resportMenu);
        }

        private void HideByRole()
        {
            switch (Storage.Role)
            {
                case "admin":
                    btnMenuMantinance.Visible = true;
                    btnReport.Visible = true;
                    btnMenuService.Visible = true;
                    HomeAdminControl homeAdmin = new HomeAdminControl();
                    pSubBody.Controls.Clear();
                    pSubBody.Controls.Add(homeAdmin);
                    break;

                case "estudiante":
                    btnMenuService.Visible = true;
                    HomeStudentControl homeStudent = new HomeStudentControl();
                    pSubBody.Controls.Clear();
                    pSubBody.Controls.Add(homeStudent);
                    break;

                case "profesor":
                    btnMenuService.Visible = true;
                    HomeTeacherControl homeTeacher = new HomeTeacherControl();
                    pSubBody.Controls.Clear();
                    pSubBody.Controls.Add(homeTeacher);
                    break;

                case "empleado":
                    btnMenuService.Visible = true;
                    HomeEmployeeControl homeEmployee = new HomeEmployeeControl();
                    pSubBody.Controls.Clear();
                    pSubBody.Controls.Add(homeEmployee);
                    break;
            }
        }

    }
}
