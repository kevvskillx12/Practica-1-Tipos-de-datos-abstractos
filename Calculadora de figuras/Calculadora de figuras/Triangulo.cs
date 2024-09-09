using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TDA_Ejemplo
{
    public class Triangulo : Figura
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        // Constructor para triángulo general (con tres lados)
        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        // Constructor para triángulo con base y altura (por ejemplo, triángulo rectángulo)
        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }
        // Método para calcular el área de un triángulo con base y altura
        public override double Area()
        {
            if (Base > 0 && Altura > 0)
            {
                return (Base * Altura) / 2;  // Área de un triángulo
            }
            else
            {
                // Calcular el área usando la fórmula de Herón para triángulos con tres lados
                double s = (Lado1 + Lado2 + Lado3) / 2; // Semiperímetro
                return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
            }
        }
        // Método para calcular el perímetro de un triángulo con tres lados
        public override double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}