namespace Demo02.Models
{
    public abstract class Conta
    {
        protected double _saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: "+ _saldo);
        }
    }
}