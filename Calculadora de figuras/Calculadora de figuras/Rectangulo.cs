using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Ejemplo
{
    public class Rectangulo : Figura
    {
        public double Bases { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double bases, double altura)
        {
            Bases = bases;
            Altura = altura;
        }

        public override double Area()
        {
            return Bases * Altura;  // Área de un rectángulo
        }

        public override double Perimetro()
        {
            return 2 * (Bases + Altura);  // Perímetro de un rectángulo
        }
    }
}

