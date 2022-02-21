using static System.Console;
public class Program
{
    static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "William";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }
}