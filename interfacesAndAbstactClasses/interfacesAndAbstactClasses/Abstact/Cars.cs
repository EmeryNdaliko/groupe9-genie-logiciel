using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using interfacesAndAbstactClasses.Cofig;

namespace interfacesAndAbstactClasses.Abstact
{
    class Cars : Vehicle
    {
        private String ref_number;

        public Cars(String model,String mark, String color,String ref_number):base(model,mark,color)
        {
            this.ref_number = ref_number;
        }

        public String RefNum
        {
            get
            {
                return ref_number;
            }
            set
            {
                ref_number = value;
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
                    if(choix == 1)
                    {
                        String sql = "INSERT INTO cars(model,mark,ref_number)VALUES('"+nameModel+"','"+nameMark+"','"+RefNum+"')";
                        SqlCommand cmd = new SqlCommand(sql, sqlconnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("Cars Inserted Successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Cars Not Inserted!!");
                        }

                    }
                    else
                    {
                        String sql = "INSERT INTO cars(model,mark,ref_number)VALUES('"+nameModel+"','"+nameMark+"','"+RefNum+"')";
                        MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Console.WriteLine("Cars Inserted Successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Cars Not Inserted!!");
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
                        String sql = "SELECT * FROM cars WHERE id='"+id+"'";
                        SqlCommand cmd = new SqlCommand(sql, sqlconnection);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Console.WriteLine("Datails Of the Car "+id);
                            Console.WriteLine("==========================");
                            Console.WriteLine(String.Format("Id => {0}\nModel => {1}\nMark => {2}\nReferense Number => {3}",id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                            Console.WriteLine("==========================");
                        }
                        else
                        {
                            Console.WriteLine("Cars Not found!!");
                        }

                    }
                    else
                    {
                        MySqlDataReader reader;
                        String sql = "SELECT * FROM cars WHERE id='" + id + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Console.WriteLine("Datails Of the Car " + id);
                            Console.WriteLine("==========================");
                            Console.WriteLine(String.Format("Id => {0}\nModel => {1}\nMark => {2}\nReferense Number => {3}", id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                            Console.WriteLine("==========================");
                        }
                        else
                        {
                            Console.WriteLine("Cars Not found!!");
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
