using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal class ilce
    {
        public int ilceID { get; set; }
        public string ilceAdi { get; set; }
        public ilce() { }
        public ilce(int ilceID, string ilceAdi)
        {
            this.ilceID = ilceID;
            this.ilceAdi = ilceAdi;
        }
    }
}
