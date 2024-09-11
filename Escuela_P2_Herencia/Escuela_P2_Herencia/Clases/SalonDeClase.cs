using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_P2_Herencia.Clases
{
    internal class SalonDeClase
    {
        private char _idSalonDeClase;
        private List<Profesor> _conjuntoDeProfesores;
        private List<Estudiante> _conjuntoDeEstudiantes;

        public SalonDeClase(char idSalonDeClase, List<Profesor> conjuntoDeProfesores, List<Estudiante> conjuntoDeEstudiantes)
        {
            IdSalonDeClase = idSalonDeClase;
            ConjuntoDeProfesores = conjuntoDeProfesores;
            ConjuntoDeEstudiantes = conjuntoDeEstudiantes;
        }
        public char IdSalonDeClase
        {
            get { return _idSalonDeClase; }
            set { _idSalonDeClase = value; }
        }

        public List<Profesor> ConjuntoDeProfesores
        {
            get => _conjuntoDeProfesores;
            set { _conjuntoDeProfesores = value; }
        }
        public List<Estudiante> ConjuntoDeEstudiantes
        {
            get => _conjuntoDeEstudiantes;
            set { _conjuntoDeEstudiantes = value; }
        }

        public override string ToString()
        {
            string mensaje = $"Este es el salón de clases [{IdSalonDeClase}], donde imparten los siguientes profesores: \n";

            if (ConjuntoDeProfesores.Count > 0) { mensaje += string.Join("\n* ", ConjuntoDeProfesores); }
            else { mensaje += " Ninguno :("; }

            mensaje += "\n\nLos estudiantes del salon son: ";
            if (ConjuntoDeEstudiantes.Count > 0) { mensaje += string.Join("\n", ConjuntoDeEstudiantes); }

            return mensaje;
        }
    }
}
