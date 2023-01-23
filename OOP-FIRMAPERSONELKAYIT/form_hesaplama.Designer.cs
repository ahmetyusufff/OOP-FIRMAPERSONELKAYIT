namespace OOP_FIRMAPERSONELKAYIT
{
    partial class form_hesaplama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ozel_dgv1 = new OOP_FIRMAPERSONELKAYIT.ozel_dgv();
            this.personel_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_cinsiyeti = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personel_ise_baslama_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_engellilik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personel_calisma_sekli = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personel_ucreti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ozel_dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ozel_dgv1
            // 
            this.ozel_dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ozel_dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ozel_dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ozel_dgv1.CMS = null;
            this.ozel_dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ozel_dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel_kodu,
            this.personel_adi,
            this.personel_soyadi,
            this.personel_tc,
            this.personel_cinsiyeti,
            this.personel_ise_baslama_tarihi,
            this.personel_engellilik,
            this.personel_calisma_sekli,
            this.personel_ucreti});
            this.ozel_dgv1.Location = new System.Drawing.Point(126, 104);
            this.ozel_dgv1.Name = "ozel_dgv1";
            this.ozel_dgv1.RowHeadersVisible = false;
            this.ozel_dgv1.Size = new System.Drawing.Size(795, 243);
            this.ozel_dgv1.TabIndex = 1;
            // 
            // personel_kodu
            // 
            this.personel_kodu.HeaderText = "Kodu";
            this.personel_kodu.Name = "personel_kodu";
            this.personel_kodu.Width = 57;
            // 
            // personel_adi
            // 
            this.personel_adi.HeaderText = "Adı";
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.Width = 47;
            // 
            // personel_soyadi
            // 
            this.personel_soyadi.HeaderText = "Soyadı";
            this.personel_soyadi.Name = "personel_soyadi";
            this.personel_soyadi.Width = 64;
            // 
            // personel_tc
            // 
            this.personel_tc.HeaderText = "T.C. No";
            this.personel_tc.Name = "personel_tc";
            this.personel_tc.Width = 52;
            // 
            // personel_cinsiyeti
            // 
            this.personel_cinsiyeti.HeaderText = "Personel Cinsiyeti";
            this.personel_cinsiyeti.Name = "personel_cinsiyeti";
            this.personel_cinsiyeti.Width = 86;
            // 
            // personel_ise_baslama_tarihi
            // 
            this.personel_ise_baslama_tarihi.HeaderText = "İşe Başlama Tarihi";
            this.personel_ise_baslama_tarihi.Name = "personel_ise_baslama_tarihi";
            this.personel_ise_baslama_tarihi.Width = 108;
            // 
            // personel_engellilik
            // 
            this.personel_engellilik.HeaderText = "Durum";
            this.personel_engellilik.Name = "personel_engellilik";
            this.personel_engellilik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personel_engellilik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.personel_engellilik.Width = 63;
            // 
            // personel_calisma_sekli
            // 
            this.personel_calisma_sekli.HeaderText = "Çalışma Şekli";
            this.personel_calisma_sekli.Name = "personel_calisma_sekli";
            this.personel_calisma_sekli.Width = 68;
            // 
            // personel_ucreti
            // 
            this.personel_ucreti.HeaderText = "Ücreti";
            this.personel_ucreti.Name = "personel_ucreti";
            this.personel_ucreti.Width = 60;
            // 
            // form_hesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.ozel_dgv1);
            this.Name = "form_hesaplama";
            this.Text = "form_hesaplama";
            ((System.ComponentModel.ISupportInitialize)(this.ozel_dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ozel_dgv ozel_dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_tc;
        private System.Windows.Forms.DataGridViewComboBoxColumn personel_cinsiyeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_ise_baslama_tarihi;
        private System.Windows.Forms.DataGridViewComboBoxColumn personel_engellilik;
        private System.Windows.Forms.DataGridViewComboBoxColumn personel_calisma_sekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_ucreti;
    }
}