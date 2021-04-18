using audiovisalParcial.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace audiovisalParcial.Design.Panel.Maintenances.RentReturns
{
    public partial class RentReturnsControl : UserControl
    {
        private RentReturnsForm createForm;
        private AudiovisualDbEntities audiovisualEntities = new AudiovisualDbEntities();

        public RentReturnsControl()
        {
            InitializeComponent();
            GetList();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            createForm = new RentReturnsForm();
            createForm.ShowDialog();
        }

        private void GetList()
        {

            try
            {
                dgvListRents.DataSource = audiovisualEntities.RentReturns.Where(w => w.Enabled != false).Select(s => new
                {
                    Id = s.Id,
                    NoPrestamo = s.NoPay,
                    Empleado = s.EmployeeId,
                    Equipo = s.EquimentId,
                    Usuario = s.UserId,
                    Renta = s.LoanDate,
                    Devolucion = s.ReturnDate,
                    Comentario = s.Comentary
                }).ToList();
                dgvListRents.Refresh();
            }
            catch (Exception ex)
            {
                Common.Util.MessageError("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvListRents.Rows[dgvListRents.CurrentRow.Index].Cells[3].Value.ToString());

                Model.Equiment f = (from x in audiovisualEntities.Equiments
                                    where x.Id == id
                                    select x).First();
                f.StateId = 1;
                audiovisualEntities.SaveChanges();

                var data = audiovisualEntities.RentReturns.Find(id);
                if (data != null)
                {
                    data.Enabled = false;
                    audiovisualEntities.SaveChanges();
                    Common.Util.Message("Equipo eliminado con exito");
                    GetList();
                }
                else
                    MessageBox.Show("Equipo no existe");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el Equipo");
            }
        }
    }
}
