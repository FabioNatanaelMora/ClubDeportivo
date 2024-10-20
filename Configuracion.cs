using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Configuracion : Form
    {
        string server; string port; string database; string username; string password;
        GestorCSV gestorCSV = new GestorCSV();
        public Conexion conexion = new Conexion();
        public Configuracion()
        {
            InitializeComponent();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {



            (server, port, database, username, password) = gestorCSV.LoadConnectionParams();



            TxtServer.Text = server; TxtPuerto.Text = port; TxtDatabase.Text = database; TxtUsername.Text = username; TxtPassword.Text = password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonActConf_Click(object sender, EventArgs e)
        {
            gestorCSV.SaveConnectionParams(TxtServer.Text, TxtPuerto.Text, TxtDatabase.Text, TxtUsername.Text, TxtPassword.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var a = conexion.PedirConexion();
            try
            {

                a.Open();

                MessageBox.Show("Conexion Exitosa");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                if (a.State == System.Data.ConnectionState.Open)
                {
                    a.Close(); // Asegúrate de cerrar la conexión si está abierta
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
