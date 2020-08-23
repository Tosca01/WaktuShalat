using System.Data.SQLite;
using System;
using WaktuShalat.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaktuShalat.Model.Interfaces;

namespace WaktuShalat.Repositories
{
    class ShalatRepository : IShalatRepository
    {
        string dbPath = AppDomain.CurrentDomain.BaseDirectory + @"\data\shalat.db";
        SQLiteConnection db;

        public ShalatRepository()
        {
            db = new SQLiteConnection("DataSource=" + dbPath + ";Version=3;");
            if (db.State == System.Data.ConnectionState.Closed) db.Open();
        }

        public async Task<bool> CreateTableIfNotExists()
        {
            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS jadwal(ID INTEGER PRIMARY KEY AUTOINCREMENT, tanggal TEXT, subuh TEXT, " +
            "terbit TEXT, dhuha TEXT, dzuhur TEXT, ashar TEXT, maghrib TEXT, isya TEXT)", db);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            } 
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<List<Shalat>> GetShalat()
        {
            List <Shalat> listShalat = new List<Shalat>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM jadwal", db);

            SQLiteDataReader rd = (SQLiteDataReader)await cmd.ExecuteReaderAsync();

            if(rd.HasRows)
            {
                while (rd.Read()) {
                    Shalat shalat = new Shalat();

                    shalat.id = int.Parse(rd["id"].ToString());
                    shalat.tanggal = rd["tanggal"].ToString();
                    shalat.subuh = rd["subuh"].ToString();
                    shalat.terbit = rd["terbit"].ToString();
                    shalat.dhuha = rd["dhuha"].ToString();
                    shalat.dzuhur = rd["dzuhur"].ToString();
                    shalat.ashar = rd["ashar"].ToString();
                    shalat.maghrib = rd["maghrib"].ToString();
                    shalat.isya = rd["isya"].ToString();

                    listShalat.Add(shalat);
                }
            }

            return listShalat;
        }

        public Shalat GetByDate(string date)
        {
            Shalat shalat = null;

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM jadwal WHERE tanggal='" + date + "' LIMIT 1", db);

            SQLiteDataReader rd = cmd.ExecuteReader();

            if(rd.HasRows)
            {
                while(rd.Read())
                {
                    shalat = new Shalat();

                    shalat.id = int.Parse(rd["id"].ToString());
                    shalat.tanggal = rd["tanggal"].ToString();
                    shalat.subuh = rd["subuh"].ToString();
                    shalat.terbit = rd["terbit"].ToString();
                    shalat.dhuha = rd["dhuha"].ToString();
                    shalat.dzuhur = rd["dzuhur"].ToString();
                    shalat.ashar = rd["ashar"].ToString();
                    shalat.maghrib = rd["maghrib"].ToString();
                    shalat.isya = rd["isya"].ToString();
                }
              
            }

            return shalat;
        }

        public bool CheckIfDataExists(string date)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM jadwal WHERE tanggal='" + date + "'", db);
            int row = 0;

            try
            {
                row = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex)
            {
                return false;
            }

            return (row > 0) ? true : false;

        }

        public async void Insert(Shalat shalat)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO jadwal(tanggal, subuh, terbit, dhuha, dzuhur," +
                "ashar, maghrib, isya) VALUES(?,?,?,?,?,?,?,?)", db);

            cmd.Parameters.AddWithValue("@tanggal", shalat.tanggal);
            cmd.Parameters.AddWithValue("@subuh", shalat.subuh);
            cmd.Parameters.AddWithValue("@terbit", shalat.terbit);
            cmd.Parameters.AddWithValue("@dhuha", shalat.dhuha);
            cmd.Parameters.AddWithValue("@dzuhur", shalat.dzuhur);
            cmd.Parameters.AddWithValue("@ashar", shalat.ashar);
            cmd.Parameters.AddWithValue("@maghrib", shalat.maghrib);
            cmd.Parameters.AddWithValue("@isya", shalat.isya);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to insert to the database");
            }

        }

        public async void Remove(string date)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM jadwal WHERE tanggal='" + date + "'", db);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to remove item from database");
            }
        }

        public async void RemoveAll()
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM jadwal", db);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to remove all item from database");
            }

        }

        
    }
}
