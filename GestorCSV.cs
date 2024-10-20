using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClubDeportivo
{

    public class GestorCSV
    {
        private string _filePath;

        // Constructor: Set the file path for the CSV
        public GestorCSV()
        {
            // Define the relative path for the CSV file
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "configuracion.csv");

            // Ensure the directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
        }

        // Method to save connection parameters to CSV
        public void SaveConnectionParams(string server, string port, string database, string username, string password)
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.WriteLine("Server,Port,Database,Username,Password"); // Write header
                writer.WriteLine($"{server},{port},{database},{username},{password}"); // Write parameters
                MessageBox.Show("Parametros Actualizados con Exito");
            }
        }

        // Method to read connection parameters from CSV
        public  (string server, string port, string database, string username, string password) LoadConnectionParams()
        {
            if (!File.Exists(_filePath))
            {
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    writer.WriteLine("Server,Port,Database,Username,Password"); // Write header
                    writer.WriteLine($"{"server"},{"port"},{"database"},{"username"},{"password"}"); // Write parameters 
                }
                
            }

            using (StreamReader reader = new StreamReader(_filePath))
            {
                reader.ReadLine(); // Skip header
                string[] values = reader.ReadLine().Split(',');

                // Return the parameters as a tuple
                return (values[0], values[1], values[2], values[3], values[4]);
            }
        }
    }
}