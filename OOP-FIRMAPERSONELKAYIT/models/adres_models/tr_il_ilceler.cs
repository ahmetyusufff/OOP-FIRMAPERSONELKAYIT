using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal static class tr_il_ilceler
    {
        //json formatı {"ilID":"1","ilAdi":"Adana","ilceler":[{"ilceID":"1","ilceAdi":"Seyhan"}]} şeklinde olmalıdır
        public static List<il> iller = JsonConvert.DeserializeObject<List<il>>(File.ReadAllText("data/il-ilceler.json"));
        [Description("Şehirleri BindingSource olarak getirir.")]
        public static BindingSource illerBindingSource()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = iller;
            return bindingSource;
        }
        [Description("İl IDsine göre ilçeleri BindingSource olarak getirir.")]
        public static BindingSource ilcelerBindingSource(int id)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = iller.Find(x => x.ilID == id)?.ilceler;
            return bindingSource;
        }
    }
}

