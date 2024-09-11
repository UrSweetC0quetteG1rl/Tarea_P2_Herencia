using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_P2_Herencia.Clases
{
    public class Persona
    {
        private string _nombre;

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }

        }

        public override string ToString()
        {
            return $"ᯓ\n{Nombre}";
        }
    }
}
