namespace OOP_FIRMAPERSONELKAYIT
{
    partial class form_firmalar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Firmalar = new System.Windows.Forms.DataGridView();
            this.col_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Firmalar
            // 
            this.dgv_Firmalar.AllowUserToAddRows = false;
            this.dgv_Firmalar.AllowUserToDeleteRows = false;
            this.dgv_Firmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Firmalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Firmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Firmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_kodu,
            this.col_unvan});
            this.dgv_Firmalar.Location = new System.Drawing.Point(531, 12);
            this.dgv_Firmalar.MultiSelect = false;
            this.dgv_Firmalar.Name = "dgv_Firmalar";
            this.dgv_Firmalar.ReadOnly = true;
            this.dgv_Firmalar.RowHeadersVisible = false;
            this.dgv_Firmalar.Size = new System.Drawing.Size(257, 318);
            this.dgv_Firmalar.TabIndex = 0;
            // 
            // col_kodu
            // 
            this.col_kodu.HeaderText = "Kodu";
            this.col_kodu.Name = "col_kodu";
            this.col_kodu.ReadOnly = true;
            // 
            // col_unvan
            // 
            this.col_unvan.HeaderText = "Unvanı / Adı-Soyadı";
            this.col_unvan.Name = "col_unvan";
            this.col_unvan.ReadOnly = true;
            // 
            // form_firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Firmalar);
            this.Name = "form_firmalar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Firmalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unvan;
    }
}

