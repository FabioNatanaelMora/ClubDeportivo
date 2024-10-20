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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {

            FormGestion formGestion = new FormGestion();
            formGestion.Show();
            this.Hide();


        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            FormInscripcionPostulante formInscripcion = new FormInscripcionPostulante();
            formInscripcion.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
