﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsLaptopok
{

    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sql;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = ConfigurationManager.AppSettings.Get("databaseHost");
            sb.UserID = ConfigurationManager.AppSettings.Get("databaseUser");
            sb.Password = ConfigurationManager.AppSettings.Get("databasePassword");
            sb.Database = ConfigurationManager.AppSettings.Get("databaseName");
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            sql = conn.CreateCommand();
            try
            {
                kapcsolatnyit();
            }
            catch (MySqlException ex)
            {
                string uzenet = Environment.NewLine + Environment.NewLine + "A program leáll!";
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Nem sikerült kapcsolódni az adatbázishoz!" + uzenet);
                        break;
                    case 1045:
                        Console.WriteLine("Hibás felhasználónév vagy jelszó!" + uzenet);
                        break;
                    default:
                        Console.WriteLine(ex.Message + uzenet);
                        break;
                }
                Console.ReadLine();
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatcsuk();
            }

        }
        void kapcsolatnyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        void kapcsolatcsuk()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public List<Laptop> getAllLaptops()
        {
            List<Laptop> laptopok = new List<Laptop>();
            try
            {
                kapcsolatnyit();
                sql.CommandText = "SELECT * FROM `laptop` WHERE 1 ORDER BY `marka`";
                MySqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    ulong laptopId = reader.GetUInt64("laptopId");
                    string marka = reader["marka"].ToString();
                    string modell = reader["model"].ToString();
                    string szin = reader["szin"].ToString();
                    string processzor = reader["processzor"].ToString();
                    int memoria = (int)reader["memoria"];
                    int kepernyomeret = (int)reader["kepernyomeret"];
                    string felbontas = reader["felbontas"].ToString();
                    int merevlemezkapacitas = (int)reader["merevlemezkapacitas"];
                    int ar = (int)reader["ar"];
                    Laptop laptop = new Laptop(laptopId, marka, szin, processzor, memoria, kepernyomeret, felbontas, merevlemezkapacitas, ar, modell);
                    laptopok.Add(laptop);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatcsuk();
            }
            return laptopok;
        }
        public void addLaptop(Laptop laptop)
        {
            try
            {
                kapcsolatnyit();
                sql.CommandText = "INSERT INTO `laptop` (`marka`, `model`, `szin`, `processzor`, `memoria`, `kepernyomeret`, `felbontas`, `merevlemezkapacitas`, `ar`) VALUES (@marka, @model, @szin, @processzor, @memoria, @kepernyomeret, @felbontas, @merevlemezkapacitas, @ar)";
                sql.Parameters.AddWithValue("@marka", laptop.Marka);
                sql.Parameters.AddWithValue("@model", laptop.Modell);
                sql.Parameters.AddWithValue("@szin", laptop.Szin);
                sql.Parameters.AddWithValue("@processzor", laptop.Processzor);
                sql.Parameters.AddWithValue("@memoria", laptop.Memoria);
                sql.Parameters.AddWithValue("@kepernyomeret", laptop.Kepernyomeret);
                sql.Parameters.AddWithValue("@felbontas", laptop.Felbontas);
                sql.Parameters.AddWithValue("@merevlemezkapacitas", laptop.Merevlemezkapacitas);
                sql.Parameters.AddWithValue("@ar", laptop.Ar);
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatcsuk();
            }
        }

        internal void updateLaptop(Laptop laptop)
        {
            try
            {
                kapcsolatnyit();
                sql.CommandText = "UPDATE `laptop` SET `marka`=@marka,`model`=@model,`szin`=@szin,`processzor`=@processzor,`memoria`=@memoria,`kepernyomeret`=@kepernyomeret,`felbontas`=@felbontas,`merevlemezkapacitas`=@merevlemezkapacitas,`ar`=@ar WHERE `laptopId`=@laptopid";
sql.Parameters.AddWithValue("@laptopid", laptop.LaptopId);
                sql.Parameters.AddWithValue("@marka", laptop.Marka);
                sql.Parameters.AddWithValue("@model", laptop.Modell);
                sql.Parameters.AddWithValue("@szin", laptop.Szin);
                sql.Parameters.AddWithValue("@processzor", laptop.Processzor);
                sql.Parameters.AddWithValue("@memoria", laptop.Memoria);
                sql.Parameters.AddWithValue("@kepernyomeret", laptop.Kepernyomeret);
                sql.Parameters.AddWithValue("@felbontas", laptop.Felbontas);
                sql.Parameters.AddWithValue("@merevlemezkapacitas", laptop.Merevlemezkapacitas);
                sql.Parameters.AddWithValue("@ar", laptop.Ar);
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatcsuk();
            }
        }
    }
}
