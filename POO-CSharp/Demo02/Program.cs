using Demo02.Models;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente conta = new Corrente();
            conta.Creditar(100);
            conta.ExibirSaldo();
        }
    }
}
