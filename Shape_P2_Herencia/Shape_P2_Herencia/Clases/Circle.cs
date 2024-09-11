using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_P2_Herencia.Clases
{
    internal class Circle : Shape
    {
        public Circle(double radio)
            : base(radio, radio)
        {
        }

        public override double CalculateSurface()
        {
            //Alto y ancho tienen el mismo valor que es el radio.
            return Math.PI * (Alto * Ancho);
        }
    }
}
