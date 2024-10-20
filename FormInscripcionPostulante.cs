using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormInscripcionPostulante : Form
    {   // declaramos variable a nivel d clase
        string nombre;
        string apellido;
        DateTime nacimiento;
        int dni;
        string telefono;
        string domicilio;

        public FormInscripcionPostulante()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

             nombre=txtNombre.Text;
           apellido=txtApellido.Text;
            nacimiento=pickerNac.Value;
             dni=int.Parse(maskedDocumento.Text.Replace(" ", "").Trim());
            MessageBox.Show(dni.ToString());
            telefono=txtDomicilio.Text;
            domicilio = txtDomicilio.Text;
            Persona p = new Persona( nombre,  apellido,  nacimiento, dni,  domicilio = "", telefono = "");
            p.InscribirPersona();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal mMenu = new FormPrincipal();
            mMenu.Show();
        }

        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void FormInscripcionPostulante_Load(object sender, EventArgs e)
        {

        }
    }
}
