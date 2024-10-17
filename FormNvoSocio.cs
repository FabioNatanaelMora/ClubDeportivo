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
    public partial class FormNvoSocio : Form
    {
        public FormNvoSocio()
        {
            InitializeComponent();
           // this.nAltaBtn = nAltaBtn;
        }

        private void NnombreLbl(object sender, EventArgs e)
        {

        }

        private void NnombreTxtBx(object sender, EventArgs e)
        {

        }

        private void FormNvoSocio_Load(object sender, EventArgs e)
        {

        }

        private void nDomicilioLbl_Click(object sender, EventArgs e)
        {

        }

        private void nAltaBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Listas.numSocio++;
            Listas.listaSocios.Add(new Socio(Listas.numSocio, nNombreTxt.Text,nApellidoTxt.Text,DateTime.Parse(nFechaNacTxt.Text),nDomicilioTxt.Text,nTelefonoTxt.Text ));
            MessageBox.Show($"Legajo: {Listas.listaSocios[0].numSocio}   Socio:  {Listas.listaSocios[0].apellido}, {Listas.listaSocios[0].nombre}     ");
        }

        private void nDomicilioLbl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
