namespace Demo02.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base._saldo = valor;
        }
    }
}