using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace interfacesAndAbstactClasses.Cofig
{
    class ConfigurationBd
    {

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection("Data source=JAMES-MAT;Initial catalog=db_vehicule;User=sa;Password=james");
        }

        public MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection("Server=localhost;Database=db_vehicule;UserID=root;Password=");
            //return new MySqlConnection("datasource=localhost;port=3306;Initial catalog=db_vehicule;username=root;Password=");
        }
    }
}
