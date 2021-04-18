using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace audiovisalParcial.Common
{
    public static class Util
    {

        public static void Message(string message)
        {
            MessageBox.Show(message, "Exito");
        }

        public static void MessageError(string message)
        {
            MessageBox.Show(message, "Mensage de errro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool ValideIdentificactionCard(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        public static string EncryptionPassowrd(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();

        }

        public static string OpenSaveFileDialog()
        {
            string path = string.Empty;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.Filter = "Csv file (*.csv)|*.csv|Text file (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                }

            }
            catch (Exception ex)
            {
                Message("Hubo un incoveniente al selecional la ubicacion para el guardado del archivo");
            }
            return path;
        }


    }
}
