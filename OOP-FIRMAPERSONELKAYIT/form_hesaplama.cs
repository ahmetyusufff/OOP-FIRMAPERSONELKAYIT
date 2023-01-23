using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System;
using System.Collections;
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
    enum Gun_tipi
    {
        Normal = 1,
        Bayram = 2,
        Resmi_Tatil = 3,
        Haftasonu = 4
    }
    public partial class Form_Hesaplama : Form
    {
        readonly Tbl_Personeller personeller;
        const string CalendarId = "tr.turkish#holiday@group.v.calendar.google.com";
        const string ApiKey = "AIzaSyCsZ66wGekS_8DmncWzdm3cPwLlUfgZrtc";
        static readonly List<Event> events = new List<Event>();
        public Form_Hesaplama(string firma_kodu)
        {
            InitializeComponent();
            //google calendar api'den tatil günleri
            var service = new CalendarService(new BaseClientService.Initializer() { ApiKey = ApiKey, ApplicationName = "api-test" });
            var request = service.Events.List(CalendarId);
            DateTime bugun = DateTime.Now;
            DateTime buay = new DateTime(bugun.Year, bugun.Month, 1);
            request.TimeMin = buay;
            request.TimeMax = buay.AddMonths(1);
            var response = request.Execute();
            events.AddRange(response.Items);
            //combobox column ayarı
            var list1 = new List<string>() { "Aylık", "Günlük", "Saatlik" };
            (dgv_puantaj.Columns["personel_calisma_sekli"] as DataGridViewComboBoxColumn).DataSource = list1;
            personeller = new Tbl_Personeller(firma_kodu);
            DgvDoldur();
        }
        Dictionary<int, Gun_tipi> GunleriHesapla(int ay, int yil)
        {
            Dictionary<int, Gun_tipi> response = new Dictionary<int, Gun_tipi>();
            for (int i = 1; i <= DateTime.DaysInMonth(yil, ay); i++)
            {
                DateTime gun = new DateTime(yil, ay, i);
                Event ozelGun = events.FirstOrDefault(x => x.Start.Date.Equals(gun.ToString("yyyy-MM-dd")));
                if (ozelGun != null)
                {
                    if (ozelGun.Summary == "Ramazan Bayramı" || ozelGun.Summary == "Kurban Bayramı")
                        response.Add(i, Gun_tipi.Bayram);
                    else
                        response.Add(i, Gun_tipi.Resmi_Tatil);
                }
                else if (gun.DayOfWeek == DayOfWeek.Saturday || gun.DayOfWeek == DayOfWeek.Sunday)
                    response.Add(i, Gun_tipi.Haftasonu);
                else
                    response.Add(i, Gun_tipi.Normal);
            }
            return response;
        }
        void DgvDoldur()
        {
            dgv_puantaj.Rows.Clear();
            for (int i = 0; i < personeller.Dt_Tablo.Rows.Count; i++)
            {
                var dr_satir = personeller.Dt_Tablo.Rows[i];
                var gunler = GunleriHesapla(DateTime.Now.Month, DateTime.Now.Year);
                var satir = new object[]
                {
                    dr_satir["personel_kodu"],
                    dr_satir["personel_adi"] + " " + dr_satir["personel_soyadi"],
                    dr_satir["personel_tc"],
                    dr_satir["personel_ise_baslama_tarihi"],
                    dr_satir["personel_calisma_sekli"].ToString(),
                    gunler.Count(x=>x.Value==Gun_tipi.Normal),
                    gunler.Count(x=>x.Value==Gun_tipi.Haftasonu),
                    gunler.Count(x=>x.Value==Gun_tipi.Bayram),
                    gunler.Count(x=>x.Value==Gun_tipi.Resmi_Tatil),
                    0,0,0,0
                };
                dgv_puantaj.Rows.Add(satir);
            }

        }

        private void Btn_yeni_kayit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_puantaj.Rows.Count; i++)
            {
                try
                {
                    var personel_kodu = dgv_puantaj.Rows[i].Cells["personel_kodu"].Value.ToString();
                    var personel = personeller.list_personeller.First(x => x.personel_kodu == personel_kodu);
                    var gunlukUcret = personel.personel_ucreti / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    var brutMaas = gunlukUcret * decimal.Parse(dgv_puantaj.Rows[i].Cells["maas_normal_gun"].Value.ToString());
                    var gelir_vergisi = brutMaas * 15 / 100;
                    var bes = brutMaas * 3 / 100;
                    var netMaas = brutMaas - bes - gelir_vergisi;

                    dgv_puantaj.Rows[i].Cells["maas_bes"].Value = bes.ToString("0.00");
                    dgv_puantaj.Rows[i].Cells["maas_gelir_vergisi"].Value = gelir_vergisi.ToString("0.00");
                    dgv_puantaj.Rows[i].Cells["maas_net_ucret"].Value = netMaas.ToString("0.00");
                }
                catch { }
            }
        }


       
    }
}
