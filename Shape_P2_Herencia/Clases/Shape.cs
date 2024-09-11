using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_P2_Herencia.Clases
{
    abstract class Shape
    {
        private double _ancho;
        private double _alto;

        public Shape(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public double Ancho { get { return _ancho; } set { _ancho = value; } }
        public double Alto { get { return _alto; } set { _alto = value; } }

        public abstract double CalculateSurface();

    }
}
