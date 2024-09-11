using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_P2_Herencia.Clases
{
    internal class Profesor : Persona
    {
        private List<Curso> _cursosImpartidos;

        public Profesor(string nombre, List<Curso> cursoImpartidos)
            : base(nombre)
        {
            CursosImpartidos = cursoImpartidos;
        }

        public List<Curso> CursosImpartidos
        {
            get { return _cursosImpartidos; }
            set { _cursosImpartidos = value; }
        }

        public override string ToString()
        {
            string mensaje = base.ToString() + $"\nCursos impardidos: ";
            if (_cursosImpartidos != null && _cursosImpartidos.Count > 0)
            {
                mensaje += string.Join("\n* ", _cursosImpartidos);
            }
            else
            {
                mensaje += " Ninguno :(";
            }

            return mensaje;

        }

    }
}
