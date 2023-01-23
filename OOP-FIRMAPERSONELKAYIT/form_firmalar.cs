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
        tbl_firmalar firmalar = new tbl_firmalar();


        public form_firmalar()
        {
            InitializeComponent();
            cmb_sehir.DataSource = illerBindingSource();
            dgv_Firmalar.AutoGenerateColumns = false;
            dgv_Firmalar.DataSource = firmalar.dt_Tablo;
            firmalar.DataTableChanged += refreshDGV;
            dgv_Firmalar.ClearSelection();
        }

        void refreshDGV(object sender = null, EventArgs e = null)
        {
            (dgv_Firmalar.DataSource as DataTable).Dispose();
            dgv_Firmalar.DataSource = firmalar.dt_Tablo;
            firmalar.dt_Tablo.DefaultView.Sort = "firma_kodu";
            dgv_Firmalar.ClearSelection();
        }

        private void cmb_sehir_SelectedValueChanged(object sender, EventArgs e)
        {
            var valID = cmb_sehir.SelectedValue.ToString();
            int ilID = -1;
            int.TryParse(valID, out ilID);
            if (ilID != -1)
            {
                cmb_ilce.DataSource = ilcelerBindingSource(ilID);
            }
        }

        private void btn_yeni_kayit_Click(object sender, EventArgs e)
        {
            Firma yeni_Firma = new Firma();
            yeni_Firma.firma_kodu = txt_firma_kodu.Text;
            yeni_Firma.firma_adi_unvani = txt_ad_unvan.Text;
            yeni_Firma.firma_adres_bulvar = txt_bulvar.Text;
            yeni_Firma.firma_adres_cadde = txt_cadde.Text;
            yeni_Firma.firma_adres_dis_kapi_no = txt_dis_kapi_no.Text;
            yeni_Firma.firma_adres_ic_kapi_no = txt_ic_kapi_no.Text;
            yeni_Firma.firma_adres_ilce = ((ilce)cmb_ilce.SelectedItem).ilceAdi;
            yeni_Firma.firma_adres_mahalle = txt_mahalle.Text;
            yeni_Firma.firma_adres_sehir = ((il)cmb_sehir.SelectedItem).ilAdi;
            yeni_Firma.firma_adres_sokak = txt_sokak.Text;
            yeni_Firma.firma_cep_telefonu = txt_cep_telefonu.Text;
            yeni_Firma.firma_eposta = txt_eposta.Text;
            yeni_Firma.firma_fax = txt_fax.Text;
            yeni_Firma.firma_kep = txt_KEP.Text;
            yeni_Firma.firma_merkez_sube = cmb_merkez_sube.SelectedItem?.ToString();
            yeni_Firma.firma_posta_kodu = txt_posta_kodu.Text;
            yeni_Firma.firma_sube_adi = txt_sube.Text;
            yeni_Firma.firma_telefon = txt_telefon.Text;
            yeni_Firma.firma_web = txt_web.Text;

            string msg = "";
            if (firmalar.firma_ekle(yeni_Firma,out msg))
            {
                MessageBox.Show("Firma başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            Firma yeni_Firma = new Firma();
            yeni_Firma.firma_kodu = txt_firma_kodu.Text;
            yeni_Firma.firma_adi_unvani = txt_ad_unvan.Text;
            yeni_Firma.firma_adres_bulvar = txt_bulvar.Text;
            yeni_Firma.firma_adres_cadde = txt_cadde.Text;
            yeni_Firma.firma_adres_dis_kapi_no = txt_dis_kapi_no.Text;
            yeni_Firma.firma_adres_ic_kapi_no = txt_ic_kapi_no.Text;
            yeni_Firma.firma_adres_ilce = ((ilce)cmb_ilce.SelectedItem).ilceAdi;
            yeni_Firma.firma_adres_mahalle = txt_mahalle.Text;
            yeni_Firma.firma_adres_sehir = ((il)cmb_sehir.SelectedItem).ilAdi;
            yeni_Firma.firma_adres_sokak = txt_sokak.Text;
            yeni_Firma.firma_cep_telefonu = txt_cep_telefonu.Text;
            yeni_Firma.firma_eposta = txt_eposta.Text;
            yeni_Firma.firma_fax = txt_fax.Text;
            yeni_Firma.firma_kep = txt_KEP.Text;
            yeni_Firma.firma_merkez_sube = cmb_merkez_sube.SelectedItem?.ToString();
            yeni_Firma.firma_posta_kodu = txt_posta_kodu.Text;
            yeni_Firma.firma_sube_adi = txt_sube.Text;
            yeni_Firma.firma_telefon = txt_telefon.Text;
            yeni_Firma.firma_web = txt_web.Text;
            if (firmalar.firma_duzenle(dgv_Firmalar.SelectedRows[0].Cells["firma_kodu"].Value.ToString(), yeni_Firma))
            {
                MessageBox.Show("Firma başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Firma düzenlenirken bir hata oluştu.\nGerekli alanları doldurduğunuzdan ve veritabanı bağlantınızın çalıştığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Firmalar_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgv_Firmalar.SelectedRows.Count == 0)
            {
                List<Control> textboxlar = gb_firma_bilgileri.Controls.Cast<Control>().Where<Control>(x => x.GetType() == typeof(TextBox) || x.GetType() == typeof(MaskedTextBox)).ToList();
                textboxlar.ForEach(x => x.Text="");
                cmb_ilce.SelectedIndex = 0;
                cmb_sehir.SelectedIndex = 0;
                cmb_merkez_sube.SelectedIndex = 0;
                return;
            }
            var drv_firma = dgv_Firmalar.CurrentRow.DataBoundItem as DataRowView;
            var dr_firma = drv_firma.Row;

            Firma yeni_Firma = new Firma(dr_firma);
            var secili_il = iller.First(x => x.ilAdi == yeni_Firma.firma_adres_sehir);
            var secili_ilce = secili_il.ilceler.First(x => x.ilceAdi == yeni_Firma.firma_adres_ilce);
            txt_firma_kodu.Text = yeni_Firma.firma_kodu;
            txt_ad_unvan.Text = yeni_Firma.firma_adi_unvani;
            txt_bulvar.Text = yeni_Firma.firma_adres_bulvar;
            txt_cadde.Text = yeni_Firma.firma_adres_cadde;
            txt_dis_kapi_no.Text = yeni_Firma.firma_adres_dis_kapi_no;
            txt_ic_kapi_no.Text = yeni_Firma.firma_adres_ic_kapi_no;
            cmb_sehir.SelectedIndex = cmb_sehir.Items.IndexOf(secili_il);
            cmb_ilce.SelectedIndex = cmb_ilce.Items.IndexOf(secili_ilce);
            txt_mahalle.Text = yeni_Firma.firma_adres_mahalle;
            yeni_Firma.firma_adres_sehir = ((il)cmb_sehir.SelectedItem).ilAdi;
            txt_sokak.Text = yeni_Firma.firma_adres_sokak;
            txt_cep_telefonu.Text = yeni_Firma.firma_cep_telefonu;
            txt_eposta.Text = yeni_Firma.firma_eposta = txt_eposta.Text;
            txt_fax.Text = yeni_Firma.firma_fax = txt_fax.Text;
            txt_KEP.Text = yeni_Firma.firma_kep = txt_KEP.Text;
            cmb_merkez_sube.SelectedItem = yeni_Firma.firma_merkez_sube;
            txt_posta_kodu.Text = yeni_Firma.firma_posta_kodu;
            txt_sube.Text = yeni_Firma.firma_sube_adi;
            txt_telefon.Text = yeni_Firma.firma_telefon;
            txt_web.Text = yeni_Firma.firma_web;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_Firmalar.SelectedRows.Count == 0) { return; }
            var result = MessageBox.Show("Firmayı silmek istediğinize emin misiniz?", "Onay Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (firmalar.firma_sil(dgv_Firmalar.SelectedRows[0].Cells["firma_kodu"].Value.ToString()))
                {
                    MessageBox.Show("Firma silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Firma silinemedi.\nVeritabanı bağlantınızın çalıştığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { return; }
        }

        private void cmb_merkez_sube_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_merkez_sube.SelectedIndex == 1) { txt_sube.Enabled = true; }
            else { txt_sube.Clear(); txt_sube.Enabled = false; }
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            firmalar.dt_Tablo.DefaultView.RowFilter = string.Format("firma_kodu LIKE '%{0}%' OR firma_adi_unvani LIKE '%{0}%'", txt_arama.Text);
            dgv_Firmalar.ClearSelection();
        }

        private void btn_secimi_temizle_Click(object sender, EventArgs e)
        {
            dgv_Firmalar.ClearSelection();
        }

        private void item_personeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_personeller(dgv_Firmalar.SelectedRows[0].Cells["firma_kodu"].Value.ToString()).ShowDialog();
            this.Show();
        }
    }
}
