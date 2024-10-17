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
        string server; string database; string username; string password;
        GestorCSV gestorCSV = new GestorCSV();
        public Configuracion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            
           

            ( server,  database,  username,  password) = gestorCSV.LoadConnectionParams();



            TxtServer.Text = server; TxtDatabase.Text = database; TxtUsername.Text = username; TxtPassword.Text = password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonActConf_Click(object sender, EventArgs e)
        {
            gestorCSV.SaveConnectionParams(TxtServer.Text, TxtDatabase.Text, TxtUsername.Text, TxtPassword.Text);
        }
    }
}
