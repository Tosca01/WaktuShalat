using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
namespace WaktuShalat.Helper
{
    class DatabaseHelper
    {
        public string DatabasePath = AppDomain.CurrentDomain.BaseDirectory + @"\data\shalat.db";
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public DatabaseHelper(String DatabasePath)
        {
            this.DatabasePath = DatabasePath;
            connection = new SQLiteConnection("DataSource=" + DatabasePath + ";Version=3;");
        }

        public DatabaseHelper()
        {

        }

        public void CreateDatabaseIfNotExists()
        {
            if (!Directory.Exists("data")){
                Directory.CreateDirectory("data");
            }

            if(!File.Exists(this.DatabasePath)) SQLiteConnection.CreateFile(this.DatabasePath);

        }

        public void DestroyDatabase()
        {
            if (File.Exists(this.DatabasePath))
            {
                try
                {
                    File.Delete(this.DatabasePath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Terjadi error saat menghapus database" + Environment.NewLine + ex.Message, "An error occured when deleting database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
