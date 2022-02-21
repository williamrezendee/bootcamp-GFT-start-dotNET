using static System.Console;

public class Program
{
    public static void Main()
    {
        string nome = "William";
        TrocarNome(nome, "José");
        WriteLine($"O novo nome é {nome}");
    }

    static void TrocarNome(string nome, string novoNome)
    {
        nome = novoNome;
    }
}
