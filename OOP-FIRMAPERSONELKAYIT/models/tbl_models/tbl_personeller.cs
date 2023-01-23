using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_FIRMAPERSONELKAYIT.dbConnection;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal class tbl_personeller
    {
        string table_name = "personeller";
        public event EventHandler DataTableChanged;
        private DataTable _dt_Tablo;
        public DataTable dt_Tablo { get { return _dt_Tablo; } set { _dt_Tablo = value; if(DataTableChanged!=null) DataTableChanged(this, null); } }
        public tbl_personeller(string firma_kodu)
        {
            _dt_Tablo = selectQuery($"select * from {table_name} where `personel_firma`='{firma_kodu}'");
        }
        public DataView asDataView()
        {
            return dt_Tablo.AsDataView();
        }
        public DataTable personel_dt_getir(string firma_kodu)
        {
            return selectQuery($"select * from {table_name} where `personel_firma`='{firma_kodu}'");
        }

        public bool personel_ekle(Personel personel, out string msg)

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
                int res = updateQuery($"INSERT INTO `personeller`(" +
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
                    dt_Tablo = getTable(table_name);
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

        public bool personel_sil(string _personel_kodu)
        {
            if (string.IsNullOrEmpty(_personel_kodu)) return false;
            int res = updateQuery($"DELETE FROM {table_name} WHERE firma_kodu='{_personel_kodu}'");
            if (res == 0) return false;
            else
            {
                dt_Tablo = getTable(table_name);
                return true;
            }
        }
        public bool firma_duzenle(string _personel_kodu, Personel personel)
        {
            if (string.IsNullOrEmpty(_personel_kodu)) return false;
                int res = dbConnection.updateQuery($"UPDATE `personeller` SET " +
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
                dt_Tablo = getTable(table_name);
                return true;
            }
        }
    }
}
