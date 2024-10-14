using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormGestion : Form
    {
        public FormGestion()
        {
            InitializeComponent();
        }

        private void btnNvoSocio_Click(object sender, EventArgs e)
        {
            FormNvoSocio formNvoSocio = new FormNvoSocio();
            formNvoSocio.ShowDialog();
        }
    }
}
