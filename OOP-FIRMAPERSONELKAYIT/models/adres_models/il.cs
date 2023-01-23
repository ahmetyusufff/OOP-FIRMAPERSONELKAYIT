using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal class il
    {
        public int ilID { get; set; }
        public string ilAdi { get; set; }
        public List<ilce> ilceler { get; set; }
        public il() { }
        public il(int ilID, string ilAdi, List<ilce> ilceler)
        {
            this.ilID = ilID;
            this.ilAdi = ilAdi;
            this.ilceler = ilceler;
        }
    }
}
