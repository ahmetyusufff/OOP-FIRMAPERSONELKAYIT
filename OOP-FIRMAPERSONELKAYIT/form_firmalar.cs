using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_FIRMAPERSONELKAYIT.tr_il_ilceler;



namespace OOP_FIRMAPERSONELKAYIT
{
    public partial class form_firmalar : Form
    {
        public form_firmalar()
        {
            InitializeComponent();
            dgv_Firmalar.Rows.Add(new object[] { 41234, "deneme" });
            cmb_sehir.DataSource = illerBindingSource();
        }

        private void cmb_sehir_SelectedValueChanged(object sender, EventArgs e)
        {
            var valID = cmb_sehir.SelectedValue.ToString();
            int ilID = -1;
            Int32.TryParse(valID, out ilID);
            if (ilID != -1)
                cmb_ilce.DataSource = ilcelerBindingSource(ilID);

        }
    }
}
