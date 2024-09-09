using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_figuras
{
    internal class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double Area()
        {
            return Math.PI * Radio * Radio;  // Área de un círculo
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Radio;  // Perímetro de un círculo
        }
    }
}
