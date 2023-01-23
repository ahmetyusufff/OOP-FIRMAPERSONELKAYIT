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
    internal class tbl_firmalar
    {
        string table_name = "firmalar";
        public event EventHandler DataTableChanged;
        private DataTable _dt_Tablo;
        public DataTable dt_Tablo { get { return _dt_Tablo; } set { _dt_Tablo = value; DataTableChanged(this, null); } }
        public tbl_firmalar()
        {
            _dt_Tablo = getTable(table_name);
        }
        public DataView asDataView()
        {
            return dt_Tablo.AsDataView();
        }
        public List<Firma> firma_listesi_getir()
        {
            return dt_Tablo?.Rows?.OfType<DataRow>()?.Select<DataRow, Firma>(x => new Firma(x))?.ToList();
        }
        public bool firma_ekle(Firma firma, out string msg)

        {
            msg = "";
            if (firma == null) return false;
            if (string.IsNullOrEmpty(firma.firma_adi_unvani) || string.IsNullOrEmpty(firma.firma_kodu)) return false;
            try
            {
                int res = updateQuery($"INSERT INTO `firmalar`(`firma_kodu`, " +
                $"`firma_merkez_sube`, `firma_sube_adi`, `firma_adi_unvani`, " +
                $"`firma_eposta`, `firma_kep`, `firma_web`, `firma_adres_bulvar`, " +
                $"`firma_adres_cadde`, `firma_adres_sokak`, `firma_adres_mahalle`, " +
                $"`firma_adres_dis_kapi_no`, `firma_adres_ic_kapi_no`, " +
                $"`firma_adres_sehir`, `firma_adres_ilce`, `firma_telefon`, " +
                $"`firma_fax`, `firma_cep_telefonu`, `firma_posta_kodu`) VALUES ('{firma.firma_kodu}'," +
                $"'{firma.firma_merkez_sube}','{firma.firma_sube_adi}','{firma.firma_adi_unvani}'," +
                $"'{firma.firma_eposta}','{firma.firma_kep}','{firma.firma_web}','{firma.firma_adres_bulvar}'," +
                $"'{firma.firma_adres_cadde}','{firma.firma_adres_sokak}','{firma.firma_adres_mahalle}'," +
                $"'{firma.firma_adres_dis_kapi_no}','{firma.firma_adres_ic_kapi_no}'," +
                $"'{firma.firma_adres_sehir}','{firma.firma_adres_ilce}','{firma.firma_telefon}'," +
                $"'{firma.firma_fax}','{firma.firma_cep_telefonu}','{firma.firma_posta_kodu}')");
                if (res == 0)
                {
                    msg = "Firma eklenemedi.\nVeritabanına bağlı olduğunuzdan emin olunuz.";
                    return false;
                }
                else
                {
                    dt_Tablo = getTable(table_name);
                    return true;
                }
            }
            catch (Exception)
            {
                msg = "Firma eklenirken hata oluştu.\nZaten kayıtlı olan bir firma kodunu kullanmadığınızdan emin olun.";
                return false;
            }


        }

        public bool firma_sil(string _firma_kodu)
        {
            if (string.IsNullOrEmpty(_firma_kodu)) return false;
            int res = updateQuery($"DELETE FROM {table_name} WHERE firma_kodu='{_firma_kodu}'");
            if (res == 0) return false;
            else
            {
                dt_Tablo = getTable(table_name);
                return true;
            }
        }
        public bool firma_duzenle(string _firma_kodu, Firma firma)
        {
            if (string.IsNullOrEmpty(_firma_kodu)) return false;
            int res = dbConnection.updateQuery($"UPDATE `firmalar` SET `firma_kodu`= '{firma.firma_kodu}',`firma_merkez_sube`= '{firma.firma_merkez_sube}'," +
                $"`firma_sube_adi`= '{firma.firma_sube_adi}',`firma_adi_unvani`= '{firma.firma_adi_unvani}'," +
                $"`firma_eposta`= '{firma.firma_eposta}',`firma_kep`= '{firma.firma_kep}',`firma_web`= '{firma.firma_web}'," +
                $"`firma_adres_bulvar`= '{firma.firma_adres_bulvar}',`firma_adres_cadde`= '{firma.firma_adres_cadde}'," +
                $"`firma_adres_sokak`= '{firma.firma_adres_sokak}',`firma_adres_mahalle`= '{firma.firma_adres_mahalle}'," +
                $"`firma_adres_dis_kapi_no`= '{firma.firma_adres_dis_kapi_no}',`firma_adres_ic_kapi_no`= '{firma.firma_adres_ic_kapi_no}'," +
                $"`firma_adres_sehir`= '{firma.firma_adres_sehir}',`firma_adres_ilce`= '{firma.firma_adres_ilce}'," +
                $"`firma_telefon`= '{firma.firma_telefon}',`firma_fax`= '{firma.firma_fax}'," +
                $"`firma_cep_telefonu`= '{firma.firma_cep_telefonu}',`firma_posta_kodu`= '{firma.firma_posta_kodu}' " +
                $"WHERE firma_kodu='{_firma_kodu}'");
            if (res == 0) return false;
            else
            {
                dt_Tablo = getTable(table_name);
                return true;
            }
        }
    }
}
