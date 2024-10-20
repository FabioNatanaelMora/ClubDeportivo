using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{

    internal class Persona
    {
        // los atributos con el signo de pregunta significa que pueden ser null,
        // por ejemplo, el cliente no nos dio un telefono
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public DateTime nacimiento { get; private set; }
        public string domicilio { get; private set; }
        public string telefono { get; private set; }
        public int documento{ get; private set; }


        // En el constructor nombramos los parametros para que sean opcionales
        public Persona(string nombre, string apellido, DateTime nacimiento, int documento, string domicilio , string telefono )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.documento = documento;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
        public void InscribirPersona()
        {
            string query = "INSERT INTO cliente (dni, apellido, nombre, fecha_nac, domicilio, telefono) VALUES (@dni, @apellido, @nombre, @fecha_nac, @domicilio, @telefono)";
            Conexion conexion = new Conexion();
            using var conn = conexion.PedirConexion(); // Asegúrate de que este método retorne un objeto MySqlConnection
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand(query, conn);

            // Asignar los parámetros
            cmd.Parameters.AddWithValue("@dni", documento);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@fecha_nac", nacimiento);
            cmd.Parameters.AddWithValue("@domicilio", domicilio);
            cmd.Parameters.AddWithValue("@telefono", telefono);

            try
            {
                // Ejecutar el comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Persona inscrita correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show($"Ocurrió un error al inscribir la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

