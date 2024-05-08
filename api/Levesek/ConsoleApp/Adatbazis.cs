using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp
{
    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost"; //hol található az adatbázis
            builder.UserID = "root"; //felhasználó azonosító
            builder.Password = ""; //jelszó
            builder.Database = "etelek"; //adatbázis
            conn = new MySqlConnection(builder.ConnectionString); //adatok rendezése
            sqlCommand = conn.CreateCommand(); //kapcsolat létrehozása
            try
            { //kapcsolat biztosítása
                kapcsolatNyit();
                kapcsolatZar();
            }
            catch (MySqlException ex)
            { //ha nincs akkor hibaüzenet
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed) //megvizsgáljuk hogy zárt e a kapcsolat
            {
                conn.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open) //megvizsgáljuk hogy nyitott e a kapcsolat
            {
                conn.Open();
            }
        }

        internal List<Leves> getLevesek()
        {
            List<Leves> levesek = new List<Leves>();
            sqlCommand.CommandText = "SELECT * FROM `levesek`"; //adatok hozzáadása az adatbázisból lekérdezéssel
            kapcsolatNyit();
            using (MySqlDataReader dr = sqlCommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    Leves leves = new Leves(dr.GetInt32("levesekkod"), dr.GetString("megnevezes"), dr.GetInt32("kaloria"),dr.GetDouble("feherje"), dr.GetDouble("zsir"), dr.GetDouble("szenhidrat"), dr.GetDouble("hamu"), dr.GetDouble("rost"));
                    levesek.Add(leves);
                }
                return levesek;
            }
            kapcsolatZar();
        }
    }
}
