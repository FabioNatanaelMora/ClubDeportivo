using System;
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


        // En el constructor nombramos los parametros para que sean opcionales
        public Persona(string nombre, string apellido, DateTime nacimiento , string domicilio = "", string telefono = "")
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
    }
}

