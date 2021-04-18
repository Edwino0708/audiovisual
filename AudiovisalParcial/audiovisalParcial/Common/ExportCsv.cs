using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audiovisalParcial.Common
{
    public class ExportCsv
    {
        private string path = string.Empty;
        public ExportCsv(string pathFile)
        {
            path = pathFile;
        }

        public void WriteFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(path))
            {
                w.WriteLine(pLine);
            }
        }
        public void WriteFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(path))
            {
                w.WriteLine(pLine);
            }
        }
    }
}
