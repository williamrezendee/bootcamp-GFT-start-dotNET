namespace Demo01.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"olá! Meu nome é {Nome} e tenho um salário de {Salario}");
        }
    }
}