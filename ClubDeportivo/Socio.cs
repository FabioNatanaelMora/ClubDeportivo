using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Socio : Persona


    {

        public uint numSocio { get; private set; }
         
     
        public Socio(uint numSocio, string nombre, string apellido, DateTime nacimiento, string domicilio = "", string telefono = "")
            : base(nombre, apellido, nacimiento, domicilio, telefono) {
            this.numSocio = numSocio;
        }

          

        }


    }

