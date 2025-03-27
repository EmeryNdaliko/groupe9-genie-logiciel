using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using interfacesAndAbstactClasses.Cofig;

namespace interfacesAndAbstactClasses.Abstact
{
    class Motorcycle : Vehicle
    {
        private String roll_number;
        public Motorcycle(String model, String mark, String color,String roll_number):base(model,mark,color)
        {
            this.roll_number = roll_number;
        }

        public String RollNum
        {
            get
            {
                return roll_number;
            }
            set
            {
                roll_number = value;
            }
        }

        public override void Add(int choix)
        {
            ConfigurationBd config = new ConfigurationBd();
            SqlConnection sqlconnection = config.GetSqlConnection();
            MySqlConnection mysqlconnection = config.GetMySqlConnection();
            sqlconnection.Open();
            mysqlconnection.Open();
            try
            {
                if (sqlconnection.State == ConnectionState.Open && mysqlconnection.State == ConnectionState.Open)
                {
                    if (choix == 1)
                    {
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('"+nameModel + "','" + nameMark + "','" + RollNum + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlconnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("Motorcycle Inserted Successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Motorcycle Not Inserted!!");
                        }

                    }
                    else
                    {
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('"+ nameModel +"','"+ nameMark +"','"+ RollNum +"')";
                        MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("Motorcycle Inserted Successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Motorcycle Not Inserted!!");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Error to connect to Sql Server Or Mysql");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open && mysqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                    mysqlconnection.Close();
                }
            }
        }

        public override void showDetails(int choix, int id)
        {
            ConfigurationBd config = new ConfigurationBd();
            SqlConnection sqlconnection = config.GetSqlConnection();
            MySqlConnection mysqlconnection = config.GetMySqlConnection();
            sqlconnection.Open();
            mysqlconnection.Open();
            try
            {
                if (sqlconnection.State == ConnectionState.Open && mysqlconnection.State == ConnectionState.Open)
                {
                    if (choix == 1)
                    {
                        SqlDataReader reader;
                        String sql = "SELECT * FROM motorcycle WHERE id='" + id + "'";
                        SqlCommand cmd = new SqlCommand(sql, sqlconnection);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Console.WriteLine("Datails Of the Motorcycle " + id);
                            Console.WriteLine("==========================");
                            Console.WriteLine(String.Format("Id => {0}\nModel => {1}\nMark => {2}\nRoll Number => {3}", id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                            Console.WriteLine("==========================");
                        }
                        else
                        {
                            Console.WriteLine("Motorcycle Not found!!");
                        }

                    }
                    else
                    {
                        MySqlDataReader reader;
                        String sql = "SELECT * FROM motorcycle WHERE id='" + id + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Console.WriteLine("Datails Of the Motorcycle " + id);
                            Console.WriteLine("==========================");
                            Console.WriteLine(String.Format("Id => {0}\nModel => {1}\nMark => {2}\nRoll Number => {3}", id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                            Console.WriteLine("==========================");
                        }
                        else
                        {
                            Console.WriteLine("Motorcycle Not found!!");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Error to connect to Sql Server Or Mysql");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open && mysqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                    mysqlconnection.Close();
                }
            }
        }
    }
}
