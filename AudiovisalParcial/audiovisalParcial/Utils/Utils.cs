using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audiovisalParcial.Utils
{
    public static class Utils
    {

        public static void Message(string message)
        {
            MessageBox.Show(message, "Exito");
        }

        public static void MessageError(string message)
        {
            MessageBox.Show(message, "Mensage de errro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
