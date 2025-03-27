package abstractinterfacejava.com.Ndabo.project.interfaceusage;

import java.sql.SQLException;

public class TestInterface {
    public static void main(String[] args) {
        try {
            IPerson e3 = new Employee();
            ((Employee) e3).setId(3);
            ((Employee) e3).setFirstName("Shabani");
            ((Employee) e3).setLastName("Wabo");
            ((Employee) e3).setCnss("6738RBHJ989363");

            e3.add();
            System.out.println("Employee inserted successfully!");

            IPerson e4 = new Employee();
            ((Employee) e4).setId(4);
            ((Employee) e4).setFirstName("Roger");
            ((Employee) e4).setLastName("Alain");
            ((Employee) e4).setCnss("512389ASGYIUE9374");

            e4.add();
            System.out.println("Employee inserted successfully!");

            IPerson s3 = new Student(3, "Marie", "Rose", "521984ESGTH8476");
            s3.add();
            System.out.println("Student inserted successfully!");

            IPerson s4 = new Student(4, "Jenny", "Dupont", "9825367GKQG7520983");
            s4.add();
            System.out.println("Student inserted successfully!");

            e3.showDynamicIdentity(((Employee) e3).getId());
            System.out.println("-----------------------------------------");
            e4.showDynamicIdentity(((Employee) e4).getId());
            System.out.println("-----------------------------------------");

            s3.showDynamicIdentity(((Student) s3).getId());
            System.out.println("------------------------------------------");
            s4.showDynamicIdentity(((Student) s4).getId());
            System.out.println("-----------------------------------------");

        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Failed to insert records into the Database");
            e.printStackTrace();
        } 
    }
}
