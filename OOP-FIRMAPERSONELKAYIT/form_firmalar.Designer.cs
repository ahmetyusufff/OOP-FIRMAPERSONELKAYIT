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
            this.components = new System.ComponentModel.Container();
            this.dgv_Firmalar = new OOP_FIRMAPERSONELKAYIT.ozel_dgv();
            this.col_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_firma_kodu = new System.Windows.Forms.TextBox();
            this.txt_sube = new System.Windows.Forms.TextBox();
            this.txt_ad_unvan = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_firma_kodu = new System.Windows.Forms.Label();
            this.lbl_merkez_sube = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_merkez_sube = new System.Windows.Forms.ComboBox();
            this.lbl_ad_unvan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cm_secilen_firma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_personeller = new System.Windows.Forms.ToolStripMenuItem();
            this.personelMaaşHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cm_secilen_firma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Firmalar
            // 
            this.dgv_Firmalar.AllowUserToAddRows = false;
            this.dgv_Firmalar.AllowUserToDeleteRows = false;
            this.dgv_Firmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Firmalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Firmalar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Firmalar.CMS = this.cm_secilen_firma;
            this.dgv_Firmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Firmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_kodu,
            this.col_unvan});
            this.dgv_Firmalar.Location = new System.Drawing.Point(5, 19);
            this.dgv_Firmalar.MultiSelect = false;
            this.dgv_Firmalar.Name = "dgv_Firmalar";
            this.dgv_Firmalar.ReadOnly = true;
            this.dgv_Firmalar.RowHeadersVisible = false;
            this.dgv_Firmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Firmalar.Size = new System.Drawing.Size(306, 356);
            this.dgv_Firmalar.TabIndex = 0;
            // 
            // col_kodu
            // 
            this.col_kodu.FillWeight = 60F;
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
            // txt_firma_kodu
            // 
            this.txt_firma_kodu.Location = new System.Drawing.Point(138, 33);
            this.txt_firma_kodu.Name = "txt_firma_kodu";
            this.txt_firma_kodu.Size = new System.Drawing.Size(100, 20);
            this.txt_firma_kodu.TabIndex = 1;
            // 
            // txt_sube
            // 
            this.txt_sube.Location = new System.Drawing.Point(253, 59);
            this.txt_sube.Name = "txt_sube";
            this.txt_sube.Size = new System.Drawing.Size(140, 20);
            this.txt_sube.TabIndex = 1;
            // 
            // txt_ad_unvan
            // 
            this.txt_ad_unvan.Location = new System.Drawing.Point(138, 86);
            this.txt_ad_unvan.Multiline = true;
            this.txt_ad_unvan.Name = "txt_ad_unvan";
            this.txt_ad_unvan.Size = new System.Drawing.Size(255, 54);
            this.txt_ad_unvan.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // lbl_firma_kodu
            // 
            this.lbl_firma_kodu.AutoSize = true;
            this.lbl_firma_kodu.Location = new System.Drawing.Point(22, 36);
            this.lbl_firma_kodu.Name = "lbl_firma_kodu";
            this.lbl_firma_kodu.Size = new System.Drawing.Size(113, 13);
            this.lbl_firma_kodu.TabIndex = 2;
            this.lbl_firma_kodu.Text = "Firma Kodu: (12 Hane)";
            // 
            // lbl_merkez_sube
            // 
            this.lbl_merkez_sube.AutoSize = true;
            this.lbl_merkez_sube.Location = new System.Drawing.Point(22, 62);
            this.lbl_merkez_sube.Name = "lbl_merkez_sube";
            this.lbl_merkez_sube.Size = new System.Drawing.Size(81, 13);
            this.lbl_merkez_sube.TabIndex = 2;
            this.lbl_merkez_sube.Text = "Merkez / Şube:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_merkez_sube);
            this.groupBox1.Controls.Add(this.lbl_firma_kodu);
            this.groupBox1.Controls.Add(this.lbl_ad_unvan);
            this.groupBox1.Controls.Add(this.lbl_merkez_sube);
            this.groupBox1.Controls.Add(this.txt_firma_kodu);
            this.groupBox1.Controls.Add(this.txt_sube);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.txt_ad_unvan);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Bilgileri";
            // 
            // cmb_merkez_sube
            // 
            this.cmb_merkez_sube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_merkez_sube.FormattingEnabled = true;
            this.cmb_merkez_sube.Location = new System.Drawing.Point(138, 59);
            this.cmb_merkez_sube.Name = "cmb_merkez_sube";
            this.cmb_merkez_sube.Size = new System.Drawing.Size(100, 21);
            this.cmb_merkez_sube.TabIndex = 3;
            // 
            // lbl_ad_unvan
            // 
            this.lbl_ad_unvan.AutoSize = true;
            this.lbl_ad_unvan.Location = new System.Drawing.Point(22, 89);
            this.lbl_ad_unvan.Name = "lbl_ad_unvan";
            this.lbl_ad_unvan.Size = new System.Drawing.Size(102, 13);
            this.lbl_ad_unvan.TabIndex = 2;
            this.lbl_ad_unvan.Text = "Adı Soyadı / Unvanı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Firmalar);
            this.groupBox2.Location = new System.Drawing.Point(567, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cm_secilen_firma
            // 
            this.cm_secilen_firma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_personeller,
            this.personelMaaşHesaplamaToolStripMenuItem});
            this.cm_secilen_firma.Name = "cm_secilen_firma";
            this.cm_secilen_firma.Size = new System.Drawing.Size(217, 48);
            // 
            // item_personeller
            // 
            this.item_personeller.Name = "item_personeller";
            this.item_personeller.Size = new System.Drawing.Size(216, 22);
            this.item_personeller.Text = "Firmanın Personellerine Git";
            // 
            // personelMaaşHesaplamaToolStripMenuItem
            // 
            this.personelMaaşHesaplamaToolStripMenuItem.Name = "personelMaaşHesaplamaToolStripMenuItem";
            this.personelMaaşHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.personelMaaşHesaplamaToolStripMenuItem.Text = "Personel Maaş Hesaplama";
            // 
            // form_firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_firmalar";
            this.Text = "Firmalar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.cm_secilen_firma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OOP_FIRMAPERSONELKAYIT.ozel_dgv dgv_Firmalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unvan;
        private System.Windows.Forms.TextBox txt_firma_kodu;
        private System.Windows.Forms.TextBox txt_sube;
        private System.Windows.Forms.TextBox txt_ad_unvan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_firma_kodu;
        private System.Windows.Forms.Label lbl_merkez_sube;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_merkez_sube;
        private System.Windows.Forms.Label lbl_ad_unvan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip cm_secilen_firma;
        private System.Windows.Forms.ToolStripMenuItem item_personeller;
        private System.Windows.Forms.ToolStripMenuItem personelMaaşHesaplamaToolStripMenuItem;
    }
}

