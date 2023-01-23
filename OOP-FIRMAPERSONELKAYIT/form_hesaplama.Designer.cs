namespace OOP_FIRMAPERSONELKAYIT
{
    partial class Form_Hesaplama
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
            this.dgv_puantaj = new OOP_FIRMAPERSONELKAYIT.Ozel_DGV();
            this.personel_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_ise_baslama_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_calisma_sekli = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.maas_normal_gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_haftasonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_bayram_gunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_resmi_tatil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_izin_gunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_gelir_vergisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_bes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas_net_ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_yeni_kayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puantaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_puantaj
            // 
            this.dgv_puantaj.AllowUserToAddRows = false;
            this.dgv_puantaj.AllowUserToDeleteRows = false;
            this.dgv_puantaj.AllowUserToResizeRows = false;
            this.dgv_puantaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_puantaj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_puantaj.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_puantaj.CMS = null;
            this.dgv_puantaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puantaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel_kodu,
            this.personel_adi,
            this.personel_tc,
            this.personel_ise_baslama_tarihi,
            this.personel_calisma_sekli,
            this.maas_normal_gun,
            this.maas_haftasonu,
            this.maas_bayram_gunu,
            this.maas_resmi_tatil,
            this.maas_izin_gunu,
            this.maas_gelir_vergisi,
            this.maas_bes,
            this.maas_net_ucret});
            this.dgv_puantaj.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_puantaj.EnterTusuSagaGecer = true;
            this.dgv_puantaj.Location = new System.Drawing.Point(12, 79);
            this.dgv_puantaj.Name = "dgv_puantaj";
            this.dgv_puantaj.RowHeadersVisible = false;
            this.dgv_puantaj.Size = new System.Drawing.Size(1022, 302);
            this.dgv_puantaj.TabIndex = 1;
            // 
            // personel_kodu
            // 
            this.personel_kodu.HeaderText = "Kodu";
            this.personel_kodu.Name = "personel_kodu";
            this.personel_kodu.ReadOnly = true;
            this.personel_kodu.Width = 57;
            // 
            // personel_adi
            // 
            this.personel_adi.HeaderText = "Adı Soyadı";
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.ReadOnly = true;
            this.personel_adi.Width = 76;
            // 
            // personel_tc
            // 
            this.personel_tc.HeaderText = "T.C. No";
            this.personel_tc.Name = "personel_tc";
            this.personel_tc.ReadOnly = true;
            this.personel_tc.Width = 52;
            // 
            // personel_ise_baslama_tarihi
            // 
            this.personel_ise_baslama_tarihi.HeaderText = "İşe Başlama Tarihi";
            this.personel_ise_baslama_tarihi.Name = "personel_ise_baslama_tarihi";
            this.personel_ise_baslama_tarihi.ReadOnly = true;
            this.personel_ise_baslama_tarihi.Width = 108;
            // 
            // personel_calisma_sekli
            // 
            this.personel_calisma_sekli.HeaderText = "Çalışma Şekli";
            this.personel_calisma_sekli.Name = "personel_calisma_sekli";
            this.personel_calisma_sekli.ReadOnly = true;
            this.personel_calisma_sekli.Width = 68;
            // 
            // maas_normal_gun
            // 
            this.maas_normal_gun.HeaderText = "Normal Gün";
            this.maas_normal_gun.Name = "maas_normal_gun";
            this.maas_normal_gun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maas_normal_gun.Width = 81;
            // 
            // maas_haftasonu
            // 
            this.maas_haftasonu.HeaderText = "Haftasonu";
            this.maas_haftasonu.Name = "maas_haftasonu";
            this.maas_haftasonu.Width = 81;
            // 
            // maas_bayram_gunu
            // 
            this.maas_bayram_gunu.HeaderText = "Bayram Günü";
            this.maas_bayram_gunu.Name = "maas_bayram_gunu";
            this.maas_bayram_gunu.Width = 88;
            // 
            // maas_resmi_tatil
            // 
            this.maas_resmi_tatil.HeaderText = "Resmi Tatil Günü";
            this.maas_resmi_tatil.Name = "maas_resmi_tatil";
            this.maas_resmi_tatil.Width = 104;
            // 
            // maas_izin_gunu
            // 
            this.maas_izin_gunu.HeaderText = "İzin Günü";
            this.maas_izin_gunu.Name = "maas_izin_gunu";
            this.maas_izin_gunu.Width = 71;
            // 
            // maas_gelir_vergisi
            // 
            this.maas_gelir_vergisi.HeaderText = "Gelir Vergisi";
            this.maas_gelir_vergisi.Name = "maas_gelir_vergisi";
            this.maas_gelir_vergisi.ReadOnly = true;
            this.maas_gelir_vergisi.Width = 80;
            // 
            // maas_bes
            // 
            this.maas_bes.HeaderText = "BES";
            this.maas_bes.Name = "maas_bes";
            this.maas_bes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maas_bes.Width = 53;
            // 
            // maas_net_ucret
            // 
            this.maas_net_ucret.HeaderText = "Net Ücret";
            this.maas_net_ucret.Name = "maas_net_ucret";
            this.maas_net_ucret.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maas_net_ucret.Width = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.timecom_logo;
            this.pictureBox1.Location = new System.Drawing.Point(430, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_geri);
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.btn_yeni_kayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 53);
            this.panel2.TabIndex = 10;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.MistyRose;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.back;
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geri.Location = new System.Drawing.Point(12, 7);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(113, 39);
            this.btn_geri.TabIndex = 228;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = false;
            // 
            // btn_sil
            // 
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.delete_24;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(921, 7);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(113, 39);
            this.btn_sil.TabIndex = 227;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_yeni_kayit
            // 
            this.btn_yeni_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yeni_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_kayit.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.calculator_2_24;
            this.btn_yeni_kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yeni_kayit.Location = new System.Drawing.Point(790, 7);
            this.btn_yeni_kayit.Name = "btn_yeni_kayit";
            this.btn_yeni_kayit.Size = new System.Drawing.Size(113, 39);
            this.btn_yeni_kayit.TabIndex = 225;
            this.btn_yeni_kayit.Text = "HESAPLAT";
            this.btn_yeni_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yeni_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_kayit.Click += new System.EventHandler(this.Btn_yeni_kayit_Click);
            // 
            // Form_Hesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_puantaj);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Hesaplama";
            this.Text = "Maaş Hesaplama";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puantaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ozel_DGV dgv_puantaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_yeni_kayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_ise_baslama_tarihi;
        private System.Windows.Forms.DataGridViewComboBoxColumn personel_calisma_sekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_normal_gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_haftasonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_bayram_gunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_resmi_tatil;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_izin_gunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_gelir_vergisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_bes;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas_net_ucret;
    }
}