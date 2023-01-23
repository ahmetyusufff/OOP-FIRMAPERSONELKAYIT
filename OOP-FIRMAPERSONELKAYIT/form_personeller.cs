using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Calendar;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
namespace OOP_FIRMAPERSONELKAYIT
{
    public partial class form_personeller : Form
    {
        tbl_personeller personeller;
        static string firma_kodu;
        public form_personeller(string _firma_kodu)
        {
            firma_kodu = _firma_kodu;
            personeller = new tbl_personeller(_firma_kodu);
            personeller.DataTableChanged += refreshDGV;
            InitializeComponent();
            refreshDGV();
        }

        void refreshDGV(object sender=null,EventArgs e =null)
        {
            var dtPersoneller = personeller.personel_dt_getir(firma_kodu);
            dgv_personeller.Rows.Clear();
            foreach (DataRow x in dtPersoneller.Rows)
            {
                dgv_personeller.Rows.Add(x.ItemArray);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yeni_kayit_Click(object sender, EventArgs e)
        {
            string msg = "";
            Personel personel = new Personel();
            try
            {
                personel.personel_kodu = txt_personel_kodu.Text;
                personel.personel_adi = txt_adi.Text;
                personel.personel_soyadi = txt_soyadi.Text;
                personel.personel_tc = txt_tc.Text;
                personel.personel_calisma_sekli = cmb_calisma_sekli.SelectedItem?.ToString();
                personel.personel_engellilik = cmb_durumu.SelectedItem?.ToString();
                personel.personel_cinsiyeti = cmb_cinsiyeti.SelectedItem?.ToString();
                personel.personel_ise_baslama_tarihi = txt_ise_baslama_tarihi.Text;
                personel.personel_ucreti = Decimal.Parse(txt_ucreti.Text);
                personel.personel_firma = firma_kodu;
            }
            catch { msg = "Gerekli alanları doldurduğunuza emin olunuz."; }

            if (msg == "" && personeller.personel_ekle(personel, out msg))
            {
                MessageBox.Show("Personel başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            string _personel_kodu = dgv_personeller.SelectedRows?[0].Cells["personel_kodu"].Value.ToString();
            Personel personel = new Personel();
            personel.personel_kodu = txt_personel_kodu.Text;
            personel.personel_adi = txt_adi.Text;
            personel.personel_soyadi = txt_soyadi.Text;
            personel.personel_tc = txt_tc.Text;
            personel.personel_calisma_sekli = cmb_calisma_sekli.SelectedItem.ToString();
            personel.personel_engellilik = cmb_durumu.SelectedItem.ToString();
            personel.personel_cinsiyeti = cmb_cinsiyeti.SelectedItem.ToString();
            personel.personel_ise_baslama_tarihi = txt_ise_baslama_tarihi.Text;
            personel.personel_ucreti = Decimal.Parse(txt_ucreti.Text);
            personel.personel_firma = firma_kodu;
            if (personeller.firma_duzenle(dgv_personeller.SelectedRows[0].Cells["personel_kodu"].Value.ToString(), personel))
            {
                MessageBox.Show("Personel başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel düzenlenirken bir hata oluştu.\nGerekli alanları doldurduğunuzdan ve veritabanı bağlantınızın çalıştığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personeller.SelectedRows.Count == 0) { return; }
            var result = MessageBox.Show("Personeli silmek istediğinize emin misiniz?", "Onay Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (personeller.personel_sil(dgv_personeller.SelectedRows[0].Cells["personel_kodu"].Value.ToString()))
                {
                    MessageBox.Show("Personel silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Personel silinemedi.\nVeritabanı bağlantınızın çalıştığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { return; }
        }

        private void dgv_personeller_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_personeller.SelectedRows.Count==0)
            {
                List<Control> textboxlar = gb_personel_bilgileri.Controls.Cast<Control>().Where<Control>(x => x.GetType() == typeof(TextBox) || x.GetType() == typeof(MaskedTextBox)).ToList();
                textboxlar.ForEach(x => x.Text = "");
                cmb_calisma_sekli.SelectedIndex = 0;
                cmb_cinsiyeti.SelectedIndex = 0;
                cmb_durumu.SelectedIndex = 0;
                return;
            }
            else
            {
                DataRow dr_personel = personeller.dt_Tablo.Rows.Cast<DataRow>().FirstOrDefault(x => x["personel_kodu"].Equals(dgv_personeller.SelectedRows[0].Cells["personel_kodu"].Value));
                txt_personel_kodu.Text = dr_personel["personel_kodu"].ToString();
                txt_adi.Text = dr_personel["personel_adi"].ToString();
                txt_soyadi.Text = dr_personel["personel_soyadi"].ToString();
                txt_tc.Text = dr_personel["personel_tc"].ToString();
                cmb_cinsiyeti.SelectedItem = dr_personel["personel_cinsiyeti"].ToString();
                txt_ise_baslama_tarihi.Text = dr_personel["personel_ise_baslama_tarihi"].ToString();
                cmb_calisma_sekli.SelectedItem = dr_personel["personel_calisma_sekli"].ToString() ;
                cmb_durumu.SelectedItem = dr_personel["personel_engellilik"].ToString() ;
                txt_ucreti.Text = dr_personel["personel_ucreti"].ToString();



            }
        }
    }
}
