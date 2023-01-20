using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_FIRMAPERSONELKAYIT
{
    public partial class form_firmalar : Form
    {
        public form_firmalar()
        {
            InitializeComponent();
            dgv_Firmalar.Rows.Add(new object[] { 41234, "deneme" });
            tbl t=new DataTable();
        }
       

    }
}
