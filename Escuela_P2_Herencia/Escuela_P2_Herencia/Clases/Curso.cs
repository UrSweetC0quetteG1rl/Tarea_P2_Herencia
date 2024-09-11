using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_P2_Herencia.Clases
{
    internal class Curso
    {
        //Los cursos tienen nombre, recuento de clases y recuento de ejercicios
        private string _nombreCurso;
        private int _recuentoClase;
        private int _recuentoEjercicios;

        public Curso(string nombreCurso, int recuentoClase, int recuentoEjercicios)
        {
            NombreCurso = nombreCurso;
            RecuentoClase = recuentoClase;
            RecuentoEjercicios = recuentoEjercicios;

        }

        public string NombreCurso
        {
            get { return _nombreCurso; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombreCurso = value;
                }
            }

        }

        public int RecuentoClase
        {
            get { return _recuentoClase; }
            set { if (value > 0) { _recuentoClase = value; } }
        }

        public int RecuentoEjercicios
        {
            get { return _recuentoEjercicios; }
            set { if (value > 0) { _recuentoEjercicios = value; } }
        }
        public override string ToString()
        {
            return $"\n{NombreCurso} \n* Recuentos de la clase: {RecuentoClase} \n* Recuentos de los Ejercicios: {RecuentoEjercicios}";
        }
    }
}
