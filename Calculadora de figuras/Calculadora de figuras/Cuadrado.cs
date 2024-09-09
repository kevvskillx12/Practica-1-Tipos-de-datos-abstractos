using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Ejemplo
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;  // Área de un cuadrado
        }

        public override double Perimetro()
        {
            return 4 * Lado;  // Perímetro de un cuadrado
        }
    }
}
