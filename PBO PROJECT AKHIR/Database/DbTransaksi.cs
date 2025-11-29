using Npgsql;
using System;
using System.Collections.Generic;
using PBO_PROJECT_AKHIR.Models;
using DotNetEnv; // import DotNetEnv

namespace PBO_PROJECT_AKHIR.Database
{
    public class DbTransaksi
    {
        private string connStr;

        public DbTransaksi()
        {
            // Load .env file
            Env.Load();  // otomatis load .env di root
            connStr = Env.GetString("CONN_STR"); // ambil variable CONN_STR
        }

        public List<transaksi> GetAllTransaksi()
        {
            var list = new List<transaksi>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                // ambil transaksi
                string queryTrx = "SELECT transaksi_id, user_id, tanggal_transaksi, total_harga, pembayaran_id FROM transaksi ORDER BY transaksi_id DESC";

                using (var cmd = new NpgsqlCommand(queryTrx, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new transaksi
                            {
                                transaksi_id = reader.GetInt32(0),
                                user_id = reader.GetInt32(1),
                                tanggal_transaksi = reader.GetDateTime(2),
                                total_harga = reader.GetInt32(3),
                                pembayaran_id = reader.GetInt32(4),
                                DetailTransaksiList = new List<detail_transaksi>()
                            });
                        }
                    }
                }

                // ambil detail
                foreach (var trx in list)
                {
                    string queryDetail = "SELECT detail_id, transaksi_id, product_id, product_name, jumlah_item, price FROM detail_transaksi WHERE transaksi_id = @idTransaksi";
                    using (var cmd = new NpgsqlCommand(queryDetail, conn))
                    {
                        cmd.Parameters.AddWithValue("idTransaksi", trx.transaksi_id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trx.DetailTransaksiList.Add(new detail_transaksi
                                {
                                    detail_id = reader.GetInt32(0),
                                    transaksi_id = reader.GetInt32(1),
                                    product_id = reader.GetInt32(2),
                                    product_name = reader.GetString(3),
                                    jumlah_item = reader.GetInt32(4),
                                    price = reader.GetInt32(5)
                                });
                            }
                        }
                    }
                }
            }

            return list;
        }
    }
}
