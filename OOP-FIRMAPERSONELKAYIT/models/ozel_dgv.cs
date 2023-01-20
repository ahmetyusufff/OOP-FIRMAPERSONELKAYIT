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
    public partial class ozel_dgv : DataGridView
    {
        public ContextMenuStrip CMS { get; set; }

        public ozel_dgv()
        {
            InitializeComponent();

            CellMouseDown += sag_click_cms;
            
        }

        private void sag_click_cms(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && CMS != null && e.Button == MouseButtons.Right)
            {
                Rows[e.RowIndex].Selected = true;
                CurrentCell = Rows[e.RowIndex].Cells[e.ColumnIndex];
                CMS.Show(Cursor.Position);
            }
        }
    }
}
