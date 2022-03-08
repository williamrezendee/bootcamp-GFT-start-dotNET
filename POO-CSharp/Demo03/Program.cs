using Demo03.Interfaces;
using Demo03.Models;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new CalculadoraComum();
            System.Console.WriteLine(calc.Somar(10, 30));
        }
    }
}