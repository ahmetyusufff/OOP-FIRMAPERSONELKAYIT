using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;
using Org.BouncyCastle.Asn1.Cms;

namespace OOP_FIRMAPERSONELKAYIT
{
    internal static class dbConnection
    {
        static string connString = "Server=localhost;Database=timecom-test;Uid=root;Pwd=;";
        public static MySqlConnection conn = new MySqlConnection(connString);

        // genel metodlar
        public static int updateQuery(string srQuery)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            if (string.IsNullOrEmpty(srQuery)) return 0;
            return new MySqlCommand(srQuery, conn).ExecuteNonQuery();
        }
        public static DataTable selectQuery(string srQuery)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            if (string.IsNullOrEmpty(srQuery)) return null;
            var dt = new DataTable();
            dt.Load(new MySqlCommand(srQuery, conn).ExecuteReader());
            return dt;
        }
        // tüm tabloyu tablo getir
        public static DataTable getTable(string tableName)
        {
            return selectQuery($"SELECT * FROM {tableName}");
        }


        //  eklenecek özellik - db connection bağlantısı kesilirse hata ekranı verecek ve uygulamayı durduracak
        /*static void dbConnectionCheck(Action action, int seconds,  CancellationToken token)
        {
            if (action == null)
                return;
            Task.Run(async () => {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                }
            }, token);
        }*/
    }
}

