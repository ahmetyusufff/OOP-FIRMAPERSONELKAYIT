using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_FIRMAPERSONELKAYIT.DbConnection;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal class Tbl_Personeller
    {
        readonly string table_name = "personeller";
        readonly string firma_kodu = "";
        public event EventHandler DataTableChanged;
        private DataTable _Dt_Tablo;
        public List<Personel> list_personeller= new List<Personel>();
        public DataTable Dt_Tablo { get { return _Dt_Tablo; } set { _Dt_Tablo = value; DataTableChanged?.Invoke(this, null); } }
        public Tbl_Personeller(string firma_kodu)
        {
            this.firma_kodu=firma_kodu;
            Guncelle();
        }
        public DataView AsDataView()
        {
            return Dt_Tablo.AsDataView();
        }
        public void Guncelle()
        {
            _Dt_Tablo = SelectQuery($"select * from {table_name} where `personel_firma`='{firma_kodu}'");
            foreach (DataRow item in Dt_Tablo.Rows)
            {
                Personel p = new Personel();
                Global_Functions.SetItemFromRow(p, item);
                list_personeller.Add(p);
            }
        }

        public bool Personel_ekle(Personel personel, out string msg)

        {
            msg = "";
            if (personel == null) return false;
            if (string.IsNullOrEmpty(personel.personel_kodu)                    || 
                string.IsNullOrEmpty(personel.personel_adi)                     ||
                string.IsNullOrEmpty(personel.personel_soyadi)                  ||
                string.IsNullOrEmpty(personel.personel_tc)                      ||
                string.IsNullOrEmpty(personel.personel_cinsiyeti)               ||
                string.IsNullOrEmpty(personel.personel_ise_baslama_tarihi)      ||
                string.IsNullOrEmpty(personel.personel_engellilik)              ||
                string.IsNullOrEmpty(personel.personel_calisma_sekli)  
                ) return false;
            try
            {
                int res = UpdateQuery($"INSERT INTO `personeller`(" +
                    $"`personel_kodu`, `personel_adi`, `personel_soyadi`," +
                    $" `personel_tc`, `personel_cinsiyeti`, `personel_ise_baslama_tarihi`," +
                    $" `personel_engellilik`, `personel_calisma_sekli`, `personel_ucreti`, `personel_firma`)" +
                    $" VALUES (" +
                    $"'{personel.personel_kodu}'," +
                    $"'{personel.personel_adi}'," +
                    $"'{personel.personel_soyadi}'," +
                    $"'{personel.personel_tc}'," +
                    $"'{personel.personel_cinsiyeti}'," +
                    $"'{personel.personel_ise_baslama_tarihi}'," +
                    $"'{personel.personel_engellilik}'," +
                    $"'{personel.personel_calisma_sekli}'," +
                    $"'{personel.personel_ucreti}'," +
                    $"'{personel.personel_firma}')");
                if (res > 0)
                {
                    Dt_Tablo = GetTable(table_name);
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                msg = "Personel eklenirken hata oluştu.\nZaten kayıtlı olan bir personel kodunu kullanmadığınızdan emin olun.";
                return false;
            }


        }

        public bool Personel_sil(string _personel_kodu)
        {
            if (string.IsNullOrEmpty(_personel_kodu)) return false;
            int res = UpdateQuery($"DELETE FROM {table_name} WHERE personel_kodu='{_personel_kodu}'");
            if (res == 0) return false;
            else
            {
                Dt_Tablo = GetTable(table_name);
                return true;
            }
        }
        public bool Firma_duzenle(string _personel_kodu, Personel personel)
        {
            if (string.IsNullOrEmpty(_personel_kodu)) return false;
                int res = DbConnection.UpdateQuery($"UPDATE `personeller` SET " +
                    $"`personel_kodu`='{personel.personel_kodu}'," +
                    $"`personel_adi`='{personel.personel_adi}'," +
                    $"`personel_soyadi`='{personel.personel_soyadi}'," +
                    $"`personel_tc`='{personel.personel_tc}'," +
                    $"`personel_cinsiyeti`='{personel.personel_cinsiyeti}'," +
                    $"`personel_ise_baslama_tarihi`='{personel.personel_ise_baslama_tarihi}'," +
                    $"`personel_engellilik`='{personel.personel_engellilik}'," +
                    $"`personel_calisma_sekli`='{personel.personel_calisma_sekli}'," +
                    $"`personel_ucreti`='{personel.personel_ucreti}'," +
                    $"`personel_firma`='{personel.personel_firma}' " +
                    $"WHERE personel_kodu='{_personel_kodu}'");
            if (res == 0) return false;
            else
            {
                Dt_Tablo = GetTable(table_name);
                return true;
            }
        }
    }
}
