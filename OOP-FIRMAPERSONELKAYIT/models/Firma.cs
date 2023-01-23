using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal class Firma
    {
        public string firma_kodu { get; set; }
        public string firma_adi_unvani { get; set; }
        public string firma_merkez_sube { get; set; }
        public string firma_sube_adi { get; set; }
        public string firma_eposta { get; set; }
        public string firma_kep { get; set; }
        public string firma_web { get; set; }
        public string firma_adres_bulvar { get; set; }
        public string firma_adres_cadde { get; set; }
        public string firma_adres_sokak { get; set; }
        public string firma_adres_mahalle { get; set; }
        public string firma_adres_dis_kapi_no { get; set; }
        public string firma_adres_ic_kapi_no { get; set; }
        public string firma_adres_sehir { get; set; }
        public string firma_adres_ilce { get; set; }
        public string firma_telefon { get; set; }
        public string firma_fax { get; set; }
        public string firma_cep_telefonu { get; set; }
        public string firma_posta_kodu { get; set; }
        public Firma() { }
        public Firma(DataRow drFirma)
        {
            firma_kodu = drFirma["firma_kodu"].ToString();
            firma_adi_unvani = drFirma["firma_adi_unvani"].ToString();
            firma_sube_adi = drFirma["firma_sube_adi"].ToString();
            firma_merkez_sube = drFirma["firma_merkez_sube"].ToString();
            firma_eposta = drFirma["firma_eposta"].ToString();
            firma_kep = drFirma["firma_kep"].ToString();
            firma_web = drFirma["firma_web"].ToString();
            firma_adres_bulvar = drFirma["firma_adres_bulvar"].ToString();
            firma_adres_cadde = drFirma["firma_adres_cadde"].ToString();
            firma_adres_sokak = drFirma["firma_adres_sokak"].ToString();
            firma_adres_mahalle = drFirma["firma_adres_mahalle"].ToString();
            firma_adres_dis_kapi_no = drFirma["firma_adres_dis_kapi_no"].ToString();
            firma_adres_ic_kapi_no = drFirma["firma_adres_ic_kapi_no"].ToString();
            firma_adres_sehir = drFirma["firma_adres_sehir"].ToString();
            firma_adres_ilce = drFirma["firma_adres_ilce"].ToString();
            firma_telefon = drFirma["firma_telefon"].ToString();
            firma_fax = drFirma["firma_fax"].ToString();
            firma_cep_telefonu = drFirma["firma_cep_telefonu"].ToString();
            firma_posta_kodu = drFirma["firma_posta_kodu"].ToString();
        }

    }
}
