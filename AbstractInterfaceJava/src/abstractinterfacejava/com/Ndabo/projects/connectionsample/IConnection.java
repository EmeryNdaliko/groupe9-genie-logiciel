/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package abstractinterfacejava.com.Ndabo.projects.connectionsample;

import java.sql.Connection;
import java.sql.SQLException;

/**
 *
 * @author SAM NDABO
 */
public interface IConnection {
    Connection getConnection() throws SQLException;
}
