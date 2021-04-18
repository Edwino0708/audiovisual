using audiovisalParcial.Model;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.RentReturns
{
    public partial class RentReturnsControl : UserControl
    {
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();
        private RentReturnsForm rentReturnForm;
        public RentReturnsControl()
        {
            InitializeComponent();
        }

        private void RentReturnsControl_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            rentReturnForm = new RentReturnsForm();
            rentReturnForm.ShowDialog();
        }
    }
}
