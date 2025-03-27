using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using interfacesAndAbstactClasses.Cofig;

namespace interfacesAndAbstactClasses.Interface
{
    class Motorcycle : IVehicle
    {
        private String roll_number;
        protected String Mark, Model, Color;
        public Motorcycle(String model, String mark, String color, String roll_number)
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
            this.roll_number = roll_number;
        }

        public String nameMark
        {
            get
            {
                return Mark;
            }
            set
            {
                Mark = value;
            }
        }

        public String nameModel
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }

        public String nameColor
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
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

        public void showDetails(int choix, int id)
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
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('" + nameModel + "','" + nameMark + "','" + RollNum + "')";
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
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('" + nameModel + "','" + nameMark + "','" + RollNum + "')";
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
            Console.WriteLine("Datails Of this Motorcycle");
            Console.WriteLine("==========================");
            Console.WriteLine(String.Format("Model => {0}\nMark => {1}\nColor => {2}\nSerial Number => {3}", nameMark, nameModel, nameColor, RollNum));
            Console.WriteLine("==========================");
        }

        public void Add(int choix)
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
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('" + nameModel + "','" + nameMark + "','" + RollNum + "')";
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
                        String sql = "INSERT INTO motorcycle(model,mark,roll_number) VALUES('" + nameModel + "','" + nameMark + "','" + RollNum + "')";
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
    }
}
