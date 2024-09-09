using System;
using System.Windows.Forms;
using TDA_Ejemplo;

namespace Calculadora_de_figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Conectar los eventos de los botones con los métodos respectivos
            button1.Click += new EventHandler(button1_Click); // Para Rectángulo (Área)
            button2.Click += new EventHandler(button2_Click); // Para Rectángulo (Perímetro)
            button6.Click += new EventHandler(button6_Click); // Para Círculo (Área)
            button7.Click += new EventHandler(button7_Click); // Para Círculo (Perímetro)
            button3.Click += new EventHandler(button3_Click); // Para Cuadrado (Área)
            button4.Click += new EventHandler(button4_Click); // Para Cuadrado (Perímetro)
            button5.Click += new EventHandler(button5_Click); // Para Triángulo (Área)
            button8.Click += new EventHandler(button8_Click); // Para Triángulo (Perímetro)
        }

        // Evento para calcular el área del rectángulo cuando se hace clic en button1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRectangulo = double.Parse(textBox2.Text);
                double alturaRectangulo = double.Parse(textBox1.Text);
                Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                double area = rectangulo.Area();
                textBox3.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la base y la altura.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el perímetro del rectángulo cuando se hace clic en button2
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRectangulo = double.Parse(textBox6.Text);
                double alturaRectangulo = double.Parse(textBox7.Text);
                Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                double perimetro = rectangulo.Perimetro();
                textBox5.Text = perimetro.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la base y la altura.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el área del círculo cuando se hace clic en button6
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = double.Parse(textBox9.Text);
                Circulo circulo = new Circulo(radio);
                double area = circulo.Area();
                textBox13.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el radio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el perímetro del círculo cuando se hace clic en button7
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = double.Parse(textBox14.Text);
                Circulo circulo = new Circulo(radio);
                double perimetro = circulo.Perimetro();
                textBox15.Text = perimetro.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el radio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el área del cuadrado cuando se hace clic en button3
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(textBox8.Text);
                Cuadrado cuadrado = new Cuadrado(lado);
                double area = cuadrado.Area();
                textBox10.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el lado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el perímetro del cuadrado cuando se hace clic en button4
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = double.Parse(textBox11.Text);
                Cuadrado cuadrado = new Cuadrado(lado);
                double perimetro = cuadrado.Perimetro();
                textBox12.Text = perimetro.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el lado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el área del triángulo cuando se hace clic en button5
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double baseTriangulo = double.Parse(textBox17.Text); // textBox17 es la base
                double alturaTriangulo = double.Parse(textBox16.Text); // textBox16 es la altura

                Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                double area = triangulo.Area();
                textBox22.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la base y la altura.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento para calcular el perímetro del triángulo cuando se hace clic en button8
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = double.Parse(textBox18.Text); // Primer lado
                double lado2 = double.Parse(textBox19.Text); // Segundo lado
                double lado3 = double.Parse(textBox20.Text); // Tercer lado

                // Crear el triángulo con los tres lados
                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
                double perimetro = triangulo.Perimetro();
                textBox21.Text = perimetro.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados del triángulo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Otros métodos no modificados
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void button6_Click_1(object sender, EventArgs e) { }
        private void button7_Click_1(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void textBox16_TextChanged(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
    }
}
