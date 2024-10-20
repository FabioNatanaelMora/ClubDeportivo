using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;


namespace ClubDeportivo
{
    public class Conexion
    

    {
        MySqlConnection conexion;
        public Conexion()
        {
            GestorCSV gestorCSV = new GestorCSV();
            var (server,port, database, username, password) = gestorCSV.LoadConnectionParams();
            

            string cadenaConn = "Server=" + server + ";Port=" + port + ";Database=" + database + ";User ID=" + username + ";Password=" + password + ";";
            Debug.WriteLine(cadenaConn);
             conexion = new MySqlConnection(cadenaConn);

        }

        public MySqlConnection PedirConexion() {
            
            return conexion;
                }

        

    }
}
       
