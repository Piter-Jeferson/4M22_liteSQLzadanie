using System.Data.SQLite;
using System.Reflection;

namespace _4M22_liteSQLzadanie
{
    public partial class MainPage : ContentPage
    {
        static string dbname = "kolekcja.db";
        static string dbpath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        static string dbase = Path.Combine(dbpath, dbname);
        static string connStr = $"DataSource={dbase}";
        static SQLiteConnection conn;
        public MainPage()
        {
           conn = new SQLiteConnection(connStr);
            conn.Open();
            string q = "CREATE TABLE kubki(id INT, firma VARCHAR(20), kolor VARCHAR(20), rozmiar VARCHAR(20));";
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            InitializeComponent();
            lblWynik.Text = "Utworzono Tabele";
           
        }
        private void btnPoprzedniClicked(object sender, EventArgs e)
        {

        }
        private void btnNastpenyClicked(object sender, EventArgs e)
        {

        }
        private void btnWyswietlClicked(object sender, EventArgs e)
        {

        }
        private void btnUsunClicked(object sender, EventArgs e)
        {

        }
    }
}