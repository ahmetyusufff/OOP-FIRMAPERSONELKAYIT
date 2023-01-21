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
            this.cm_secilen_firma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_personeller = new System.Windows.Forms.ToolStripMenuItem();
            this.personelMaaşHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_firma_kodu = new System.Windows.Forms.TextBox();
            this.txt_sube = new System.Windows.Forms.TextBox();
            this.txt_ad_unvan = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_KEP = new System.Windows.Forms.TextBox();
            this.lbl_firma_kodu = new System.Windows.Forms.Label();
            this.lbl_merkez_sube = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.txt_sokak = new System.Windows.Forms.TextBox();
            this.txt_cadde = new System.Windows.Forms.TextBox();
            this.txt_ic_kapi_no = new System.Windows.Forms.TextBox();
            this.txt_posta_kodu = new System.Windows.Forms.TextBox();
            this.txt_dis_kapi_no = new System.Windows.Forms.TextBox();
            this.txt_mahalle = new System.Windows.Forms.TextBox();
            this.txt_bulvar = new System.Windows.Forms.TextBox();
            this.lbl_sokak = new System.Windows.Forms.Label();
            this.lbl_ic_kapi_no = new System.Windows.Forms.Label();
            this.lbl_dis_kapi_no = new System.Windows.Forms.Label();
            this.lbl_cadde = new System.Windows.Forms.Label();
            this.lbl_posta_kodu = new System.Windows.Forms.Label();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.lbl_cep_telefonu = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mahalle = new System.Windows.Forms.Label();
            this.lbl_bulvar = new System.Windows.Forms.Label();
            this.lbl_web = new System.Windows.Forms.Label();
            this.lbl_KEP = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.cmb_merkez_sube = new System.Windows.Forms.ComboBox();
            this.lbl_ad_unvan = new System.Windows.Forms.Label();
            this.txt_web = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_fax = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep_telefonu = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Firmalar = new OOP_FIRMAPERSONELKAYIT.ozel_dgv();
            this.col_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cm_secilen_firma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).BeginInit();
            this.SuspendLayout();
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
            this.txt_sube.TabIndex = 3;
            // 
            // txt_ad_unvan
            // 
            this.txt_ad_unvan.Location = new System.Drawing.Point(138, 86);
            this.txt_ad_unvan.Multiline = true;
            this.txt_ad_unvan.Name = "txt_ad_unvan";
            this.txt_ad_unvan.Size = new System.Drawing.Size(255, 54);
            this.txt_ad_unvan.TabIndex = 4;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(138, 157);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(153, 20);
            this.txt_eposta.TabIndex = 5;
            // 
            // txt_KEP
            // 
            this.txt_KEP.Location = new System.Drawing.Point(138, 183);
            this.txt_KEP.Name = "txt_KEP";
            this.txt_KEP.Size = new System.Drawing.Size(153, 20);
            this.txt_KEP.TabIndex = 6;
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
            this.groupBox1.Controls.Add(this.txt_cep_telefonu);
            this.groupBox1.Controls.Add(this.txt_fax);
            this.groupBox1.Controls.Add(this.txt_telefon);
            this.groupBox1.Controls.Add(this.cmb_ilce);
            this.groupBox1.Controls.Add(this.cmb_sehir);
            this.groupBox1.Controls.Add(this.txt_sokak);
            this.groupBox1.Controls.Add(this.txt_cadde);
            this.groupBox1.Controls.Add(this.txt_ic_kapi_no);
            this.groupBox1.Controls.Add(this.txt_posta_kodu);
            this.groupBox1.Controls.Add(this.txt_dis_kapi_no);
            this.groupBox1.Controls.Add(this.txt_mahalle);
            this.groupBox1.Controls.Add(this.txt_bulvar);
            this.groupBox1.Controls.Add(this.lbl_sokak);
            this.groupBox1.Controls.Add(this.lbl_ic_kapi_no);
            this.groupBox1.Controls.Add(this.lbl_dis_kapi_no);
            this.groupBox1.Controls.Add(this.lbl_cadde);
            this.groupBox1.Controls.Add(this.lbl_posta_kodu);
            this.groupBox1.Controls.Add(this.lbl_fax);
            this.groupBox1.Controls.Add(this.lbl_cep_telefonu);
            this.groupBox1.Controls.Add(this.lbl_telefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_mahalle);
            this.groupBox1.Controls.Add(this.lbl_bulvar);
            this.groupBox1.Controls.Add(this.lbl_web);
            this.groupBox1.Controls.Add(this.lbl_KEP);
            this.groupBox1.Controls.Add(this.lbl_eposta);
            this.groupBox1.Controls.Add(this.cmb_merkez_sube);
            this.groupBox1.Controls.Add(this.lbl_firma_kodu);
            this.groupBox1.Controls.Add(this.lbl_ad_unvan);
            this.groupBox1.Controls.Add(this.lbl_merkez_sube);
            this.groupBox1.Controls.Add(this.txt_firma_kodu);
            this.groupBox1.Controls.Add(this.txt_sube);
            this.groupBox1.Controls.Add(this.txt_web);
            this.groupBox1.Controls.Add(this.txt_KEP);
            this.groupBox1.Controls.Add(this.txt_ad_unvan);
            this.groupBox1.Controls.Add(this.txt_eposta);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 407);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Bilgileri";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.DisplayMember = "ilceAdi";
            this.cmb_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ilce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ilce.FormattingEnabled = true;
            this.cmb_ilce.Location = new System.Drawing.Point(313, 301);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(100, 21);
            this.cmb_ilce.TabIndex = 15;
            this.cmb_ilce.ValueMember = "ilceID";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_sehir.DisplayMember = "ilAdi";
            this.cmb_sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sehir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(138, 301);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(100, 21);
            this.cmb_sehir.TabIndex = 14;
            this.cmb_sehir.ValueMember = "ilID";
            this.cmb_sehir.SelectedValueChanged += new System.EventHandler(this.cmb_sehir_SelectedValueChanged);
            // 
            // txt_sokak
            // 
            this.txt_sokak.Location = new System.Drawing.Point(488, 249);
            this.txt_sokak.Name = "txt_sokak";
            this.txt_sokak.Size = new System.Drawing.Size(100, 20);
            this.txt_sokak.TabIndex = 10;
            // 
            // txt_cadde
            // 
            this.txt_cadde.Location = new System.Drawing.Point(313, 249);
            this.txt_cadde.Name = "txt_cadde";
            this.txt_cadde.Size = new System.Drawing.Size(100, 20);
            this.txt_cadde.TabIndex = 9;
            // 
            // txt_ic_kapi_no
            // 
            this.txt_ic_kapi_no.Location = new System.Drawing.Point(488, 275);
            this.txt_ic_kapi_no.Name = "txt_ic_kapi_no";
            this.txt_ic_kapi_no.Size = new System.Drawing.Size(100, 20);
            this.txt_ic_kapi_no.TabIndex = 13;
            // 
            // txt_posta_kodu
            // 
            this.txt_posta_kodu.Location = new System.Drawing.Point(313, 354);
            this.txt_posta_kodu.Name = "txt_posta_kodu";
            this.txt_posta_kodu.Size = new System.Drawing.Size(100, 20);
            this.txt_posta_kodu.TabIndex = 19;
            // 
            // txt_dis_kapi_no
            // 
            this.txt_dis_kapi_no.Location = new System.Drawing.Point(313, 275);
            this.txt_dis_kapi_no.Name = "txt_dis_kapi_no";
            this.txt_dis_kapi_no.Size = new System.Drawing.Size(100, 20);
            this.txt_dis_kapi_no.TabIndex = 12;
            // 
            // txt_mahalle
            // 
            this.txt_mahalle.Location = new System.Drawing.Point(138, 275);
            this.txt_mahalle.Name = "txt_mahalle";
            this.txt_mahalle.Size = new System.Drawing.Size(100, 20);
            this.txt_mahalle.TabIndex = 11;
            // 
            // txt_bulvar
            // 
            this.txt_bulvar.Location = new System.Drawing.Point(138, 249);
            this.txt_bulvar.Name = "txt_bulvar";
            this.txt_bulvar.Size = new System.Drawing.Size(100, 20);
            this.txt_bulvar.TabIndex = 8;
            // 
            // lbl_sokak
            // 
            this.lbl_sokak.AutoSize = true;
            this.lbl_sokak.Location = new System.Drawing.Point(419, 252);
            this.lbl_sokak.Name = "lbl_sokak";
            this.lbl_sokak.Size = new System.Drawing.Size(38, 13);
            this.lbl_sokak.TabIndex = 5;
            this.lbl_sokak.Text = "Sokak";
            // 
            // lbl_ic_kapi_no
            // 
            this.lbl_ic_kapi_no.AutoSize = true;
            this.lbl_ic_kapi_no.Location = new System.Drawing.Point(419, 278);
            this.lbl_ic_kapi_no.Name = "lbl_ic_kapi_no";
            this.lbl_ic_kapi_no.Size = new System.Drawing.Size(57, 13);
            this.lbl_ic_kapi_no.TabIndex = 5;
            this.lbl_ic_kapi_no.Text = "İç Kapı No";
            // 
            // lbl_dis_kapi_no
            // 
            this.lbl_dis_kapi_no.AutoSize = true;
            this.lbl_dis_kapi_no.Location = new System.Drawing.Point(244, 278);
            this.lbl_dis_kapi_no.Name = "lbl_dis_kapi_no";
            this.lbl_dis_kapi_no.Size = new System.Drawing.Size(63, 13);
            this.lbl_dis_kapi_no.TabIndex = 5;
            this.lbl_dis_kapi_no.Text = "Dış Kapı No";
            // 
            // lbl_cadde
            // 
            this.lbl_cadde.AutoSize = true;
            this.lbl_cadde.Location = new System.Drawing.Point(244, 252);
            this.lbl_cadde.Name = "lbl_cadde";
            this.lbl_cadde.Size = new System.Drawing.Size(38, 13);
            this.lbl_cadde.TabIndex = 5;
            this.lbl_cadde.Text = "Cadde";
            // 
            // lbl_posta_kodu
            // 
            this.lbl_posta_kodu.AutoSize = true;
            this.lbl_posta_kodu.Location = new System.Drawing.Point(244, 357);
            this.lbl_posta_kodu.Name = "lbl_posta_kodu";
            this.lbl_posta_kodu.Size = new System.Drawing.Size(62, 13);
            this.lbl_posta_kodu.TabIndex = 5;
            this.lbl_posta_kodu.Text = "Posta Kodu";
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(244, 331);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(24, 13);
            this.lbl_fax.TabIndex = 5;
            this.lbl_fax.Text = "Fax";
            // 
            // lbl_cep_telefonu
            // 
            this.lbl_cep_telefonu.AutoSize = true;
            this.lbl_cep_telefonu.Location = new System.Drawing.Point(22, 357);
            this.lbl_cep_telefonu.Name = "lbl_cep_telefonu";
            this.lbl_cep_telefonu.Size = new System.Drawing.Size(71, 13);
            this.lbl_cep_telefonu.TabIndex = 5;
            this.lbl_cep_telefonu.Text = "Cep Telefonu";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(22, 331);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(43, 13);
            this.lbl_telefon.TabIndex = 5;
            this.lbl_telefon.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlçe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şehir";
            // 
            // lbl_mahalle
            // 
            this.lbl_mahalle.AutoSize = true;
            this.lbl_mahalle.Location = new System.Drawing.Point(22, 278);
            this.lbl_mahalle.Name = "lbl_mahalle";
            this.lbl_mahalle.Size = new System.Drawing.Size(73, 13);
            this.lbl_mahalle.TabIndex = 5;
            this.lbl_mahalle.Text = "Mahalle / Köy";
            // 
            // lbl_bulvar
            // 
            this.lbl_bulvar.AutoSize = true;
            this.lbl_bulvar.Location = new System.Drawing.Point(22, 252);
            this.lbl_bulvar.Name = "lbl_bulvar";
            this.lbl_bulvar.Size = new System.Drawing.Size(37, 13);
            this.lbl_bulvar.TabIndex = 5;
            this.lbl_bulvar.Text = "Bulvar";
            // 
            // lbl_web
            // 
            this.lbl_web.AutoSize = true;
            this.lbl_web.Location = new System.Drawing.Point(22, 212);
            this.lbl_web.Name = "lbl_web";
            this.lbl_web.Size = new System.Drawing.Size(30, 13);
            this.lbl_web.TabIndex = 4;
            this.lbl_web.Text = "Web";
            // 
            // lbl_KEP
            // 
            this.lbl_KEP.AutoSize = true;
            this.lbl_KEP.Location = new System.Drawing.Point(22, 186);
            this.lbl_KEP.Name = "lbl_KEP";
            this.lbl_KEP.Size = new System.Drawing.Size(28, 13);
            this.lbl_KEP.TabIndex = 4;
            this.lbl_KEP.Text = "KEP";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Location = new System.Drawing.Point(22, 160);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(43, 13);
            this.lbl_eposta.TabIndex = 4;
            this.lbl_eposta.Text = "E-posta";
            // 
            // cmb_merkez_sube
            // 
            this.cmb_merkez_sube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_merkez_sube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_merkez_sube.FormattingEnabled = true;
            this.cmb_merkez_sube.Location = new System.Drawing.Point(138, 59);
            this.cmb_merkez_sube.Name = "cmb_merkez_sube";
            this.cmb_merkez_sube.Size = new System.Drawing.Size(100, 21);
            this.cmb_merkez_sube.TabIndex = 2;
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
            // txt_web
            // 
            this.txt_web.Location = new System.Drawing.Point(138, 209);
            this.txt_web.Name = "txt_web";
            this.txt_web.Size = new System.Drawing.Size(153, 20);
            this.txt_web.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgv_Firmalar);
            this.groupBox2.Location = new System.Drawing.Point(643, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 47);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.delete_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(642, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 224;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.edit_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(433, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 223;
            this.button2.Text = "DÜZENLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::OOP_FIRMAPERSONELKAYIT.Properties.Resources.add_file_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(241, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 222;
            this.button1.Text = "YENİ KAYIT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(138, 328);
            this.txt_telefon.Mask = "(999) 000-0000";
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_telefon.TabIndex = 16;
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(313, 328);
            this.txt_fax.Mask = "(999) 000-0000";
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(100, 20);
            this.txt_fax.TabIndex = 17;
            // 
            // txt_cep_telefonu
            // 
            this.txt_cep_telefonu.Location = new System.Drawing.Point(138, 354);
            this.txt_cep_telefonu.Mask = "(999) 000-0000";
            this.txt_cep_telefonu.Name = "txt_cep_telefonu";
            this.txt_cep_telefonu.Size = new System.Drawing.Size(100, 20);
            this.txt_cep_telefonu.TabIndex = 18;
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
            this.dgv_Firmalar.Size = new System.Drawing.Size(306, 355);
            this.dgv_Firmalar.TabIndex = 0;
            this.dgv_Firmalar.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // form_firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_firmalar";
            this.Text = "Firmalar";
            this.cm_secilen_firma.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OOP_FIRMAPERSONELKAYIT.ozel_dgv dgv_Firmalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unvan;
        private System.Windows.Forms.TextBox txt_firma_kodu;
        private System.Windows.Forms.TextBox txt_sube;
        private System.Windows.Forms.TextBox txt_ad_unvan;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_KEP;
        private System.Windows.Forms.Label lbl_firma_kodu;
        private System.Windows.Forms.Label lbl_merkez_sube;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_merkez_sube;
        private System.Windows.Forms.Label lbl_ad_unvan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip cm_secilen_firma;
        private System.Windows.Forms.ToolStripMenuItem item_personeller;
        private System.Windows.Forms.ToolStripMenuItem personelMaaşHesaplamaToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_sokak;
        private System.Windows.Forms.TextBox txt_cadde;
        private System.Windows.Forms.TextBox txt_ic_kapi_no;
        private System.Windows.Forms.TextBox txt_dis_kapi_no;
        private System.Windows.Forms.TextBox txt_mahalle;
        private System.Windows.Forms.TextBox txt_bulvar;
        private System.Windows.Forms.Label lbl_sokak;
        private System.Windows.Forms.Label lbl_dis_kapi_no;
        private System.Windows.Forms.Label lbl_cadde;
        private System.Windows.Forms.Label lbl_mahalle;
        private System.Windows.Forms.Label lbl_bulvar;
        private System.Windows.Forms.Label lbl_web;
        private System.Windows.Forms.Label lbl_KEP;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.TextBox txt_web;
        private System.Windows.Forms.TextBox txt_posta_kodu;
        private System.Windows.Forms.Label lbl_ic_kapi_no;
        private System.Windows.Forms.Label lbl_posta_kodu;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.Label lbl_cep_telefonu;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txt_cep_telefonu;
        private System.Windows.Forms.MaskedTextBox txt_fax;
        private System.Windows.Forms.MaskedTextBox txt_telefon;
        private System.Windows.Forms.TextBox textBox1;
    }
}

