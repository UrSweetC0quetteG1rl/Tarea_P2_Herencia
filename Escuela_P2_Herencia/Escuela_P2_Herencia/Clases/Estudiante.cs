using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_P2_Herencia.Clases
{
    internal class Estudiante : Persona
    {
        private int _id;

        public Estudiante(string nombre, int id)
            : base(nombre)
        {
            ID = id;
        }
        public int ID
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }

        }

        public override string ToString()
        {
            return base.ToString() + $"\nNúmero: {ID}";
        }
    }
}
