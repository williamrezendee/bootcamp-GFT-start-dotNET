using Demo01.Models;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Bob";
            aluno.Idade = 20;
            aluno.Nota = 10;
            aluno.Apresentar();

            Professor professor = new Professor();
            professor.Nome = "Marco";
            professor.Idade = 34;
            professor.Salario = 10000.0;
            professor.Apresentar();

            // Retangulo retangulo = new Retangulo();
            // retangulo.DefinirMedidas(30, 30);
            // var area = retangulo.ObterArea();
            // Console.WriteLine($"Area: {area}");

            // Retangulo retangulo1 = new Retangulo();
            // retangulo1.DefinirMedidas(0, 0);
            // area = retangulo1.ObterArea();
            // Console.WriteLine($"Area: {area}");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
