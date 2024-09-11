using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_P2_Herencia.Clases
{
    internal class Rectangle : Shape
    {
        public Rectangle(double ancho, double alto)
            : base(ancho, alto)
        {
        }

        public override double CalculateSurface()
        {
            return Alto * Ancho;
        }
    }
}
