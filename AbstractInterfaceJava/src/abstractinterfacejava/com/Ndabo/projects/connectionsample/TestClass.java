package abstractinterfacejava.com.Ndabo.projects.connectionsample;

import java.sql.Connection;
import java.sql.SQLException;

/**
 *
 * @author SAM NDABO
 */
public class TestClass {
    public static void main(String[] args) {
        Connection sqlServerCon = null;
        Connection mySqlCon = null;

        try {
            // Connexion à SQL Server
            sqlServerCon = ConnectionFactory.getConnection(ConnectionFactory.SQL_SERVER_CONNECTION);
            System.out.println(" Successfully connected to SQL Server: " 
                    + sqlServerCon.getMetaData().getDatabaseProductName());
            System.out.println("SQL Server Connection details: " + sqlServerCon.toString());

            // Connexion à MySQL
            mySqlCon = ConnectionFactory.getConnection(ConnectionFactory.MYSQL_CONNECTION);
            System.out.println(" Successfully connected to MySQL: " 
                    + mySqlCon.getMetaData().getDatabaseProductName());
            System.out.println("MySQL Connection details: " + mySqlCon.toString());

        } catch (SQLException e) {
            System.err.println(" Unable to connect to the Database. SQLException: " + e.getMessage());
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            System.err.println(" Database driver not found. ClassNotFoundException: " + e.getMessage());
            e.printStackTrace();
        } 
    }
}
