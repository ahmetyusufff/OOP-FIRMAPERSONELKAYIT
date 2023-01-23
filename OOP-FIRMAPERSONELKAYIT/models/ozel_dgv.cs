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
        public bool EnterTusuSagaGecer { get; set; } = false;

        public ozel_dgv()
        {
            RowHeadersVisible = false;
            InitializeComponent();
            CellMouseDown += sag_click_cms;
            KeyDown += Ozel_dgv_KeyDown;
            
        }

        private void Ozel_dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && CurrentRow != null)
            {
                int rowIndex = CurrentCell.RowIndex;
                int colIndex = CurrentCell.ColumnIndex;
                if (colIndex < CurrentRow.Cells.Count - 1)
                    Rows[rowIndex].Cells[colIndex + 1].Selected = true;
                else if (rowIndex < Rows.Count - 1)
                    Rows[rowIndex + 1].Cells[0].Selected = true;
                else
                    Rows[0].Cells[0].Selected = true;
            }
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
