using System;

namespace Triangulo
{
    class minhaClasse
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            double maior; 
            double soma; 
            bool triangulo;
            double perimetro = 0.0, area = 0.0;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            if (maior == a)
            {
                soma = b + c;
            }
            else if (maior == b)
            {
                soma = a + c;
            }
            else
            {
                soma = b + a;
            }

            if (soma > maior)
            {
                triangulo = true;
            }
            else
            {
                triangulo = false;
            }

            if (triangulo)
            {
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("N1")}");
            }
            else
            {
                area = (((a + b) * c) / 2) + .0;
                Console.WriteLine($"Area = {area.ToString("N1")}");
            }
        }
    }
}