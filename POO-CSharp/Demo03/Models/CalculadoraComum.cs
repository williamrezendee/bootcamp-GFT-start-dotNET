using System.Reflection.Metadata.Ecma335;
using Demo03.Interfaces;

namespace Demo03.Models
{
    public class CalculadoraComum : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}