namespace Demo01.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}