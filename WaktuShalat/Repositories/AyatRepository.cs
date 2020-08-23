using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using WaktuShalat.Model;
using WaktuShalat.Model.Interfaces;

namespace WaktuShalat.Repositories
{
    class AyatRepository : IAyatRepository
    {
        string dbPath = AppDomain.CurrentDomain.BaseDirectory + @"\data\shalat.db";
        private SQLiteConnection db;

        public AyatRepository()
        {
            db = new SQLiteConnection("DataSource=" + dbPath + ";Version=3;");
            if (db.State == System.Data.ConnectionState.Closed) db.Open();
        }

        public async Task<bool> CreateTableIfNotExists()
        {
            SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS ayat(ID INTEGER PRIMARY KEY AUTOINCREMENT" +
                ", surah TEXT, isi TEXT, terjemah TEXT)", db);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<List<Ayat>> GetAyat()
        {
            List<Ayat> listAyat = new List<Ayat>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM ayat", db);

            SQLiteDataReader rd = (SQLiteDataReader)await cmd.ExecuteReaderAsync();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Ayat ayat = new Ayat();

                    ayat.id = int.Parse(rd["id"].ToString());
                    ayat.surah = rd["surah"].ToString();
                    ayat.isi = rd["isi"].ToString();
                    ayat.terjemah = rd["terjemah"].ToString();

                    listAyat.Add(ayat);
                }
            }

            return listAyat;
        }

        public async void Insert(Ayat ayat)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO ayat(surah, isi, terjemah) VALUES(?,?,?)", db);

            cmd.Parameters.AddWithValue("@surah", ayat.surah);
            cmd.Parameters.AddWithValue("@isi", ayat.isi);
            cmd.Parameters.AddWithValue("@terjemah", ayat.terjemah);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to insert to the database");
            }

        }

        public async Task<Ayat> GetRandom()
        {
            Ayat ayat = null;

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM ayat ORDER BY RANDOM() LIMIT 1", db);

            SQLiteDataReader rd = (SQLiteDataReader)await cmd.ExecuteReaderAsync();

            if(rd.HasRows)
            {
                while(rd.Read())
                {
                    ayat = new Ayat();

                    ayat.id = int.Parse(rd["id"].ToString());
                    ayat.surah = rd["surah"].ToString();
                    ayat.isi = rd["isi"].ToString();
                    ayat.terjemah = rd["terjemah"].ToString();
                }
            }

            return ayat;
        }

        public async void RemoveAll()
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM ayat", db);

            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to remove all items from database");
            }
        }
    }
}
