package abstractinterfacejava.com.Ndabo.project.abstractclasssusage;

import abstractinterfacejava.com.Ndabo.projects.connectionsample.ConnectionFactory;
import java.sql.Connection;
import java.sql.SQLException;

/**
 *
 * @author SAM NDABO
 */
public class TestAbstract {
    public static void main(String[] args) {
        Connection connection = null;
        
        try {
            // Récupération d'une connexion SQL
            connection = ConnectionFactory.getConnection(ConnectionFactory.SQL_SERVER_CONNECTION);
            
            // Création et insertion des employés
            Person e1 = new Employee(1, "SAM", "SHURTZ", "EM230973-220");
            e1.add(e1);
            System.out.println("Employee 1 inserted successfully!");

            Person e2 = new Employee(2, "EMERY", "DESIGN", "EM232353-221");
            e2.add(e2);
            System.out.println("Employee 2 inserted successfully!");

            // Création et insertion des étudiants
            Person s1 = new Student(1, "SAMSON", "NDABO", "23LIAGELJ1070348");
            s1.add(s1);
            System.out.println(" Student 1 inserted successfully!");

            Person s2 = new Student(2, "EMERY", "NDALIKO", "23LIAGELJ293022");
            s2.add(s2);
            System.out.println("Student 2 inserted successfully!");

            // Affichage des employés insérés
            System.out.println("----- Employee Records -----");
            e1.showDynamicIdentity(e1.getId());
            e2.showDynamicIdentity(e2.getId());

            // Affichage des étudiants insérés
            System.out.println("----- Student Records -----");
            s1.showDynamicIdentity(s1.getId());
            s2.showDynamicIdentity(s2.getId());

        } catch (SQLException | ClassNotFoundException e) {
            System.err.println("Failed to insert records into the Database");
            e.printStackTrace();
        } finally {
            closeConnection(connection, "MySQL");
        }
    }

    private static void closeConnection(Connection con, String dbType) {
        if (con != null) {
            try {
                con.close();
                System.out.println("Connection to " + dbType + " closed.");
            } catch (SQLException e) {
                System.err.println("Error while closing the " + dbType + " connection: " + e.getMessage());
            }
        }
    }
}
