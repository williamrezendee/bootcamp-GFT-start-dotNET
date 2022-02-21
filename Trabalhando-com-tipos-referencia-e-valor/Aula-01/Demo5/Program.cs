using static System.Console;

public class Program
{
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == pessoa.Nome)
                return true;
        }
        return false;
    }
    public static void Main()
    {
        //BuscarPorValor();
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Ricardo"},
            new Pessoa(){Nome = "William"},
            new Pessoa(){Nome = "Bruna"},
            new Pessoa(){Nome = "Cecília"}, 
            new Pessoa(){Nome = "Matheus"}
        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if (encontrado)
            WriteLine("Pessoa localizada!");
        else
            WriteLine("Pessoa não localizada!");
    }

    private static void BuscarPorValor()
    {
        int[] numeros = new int[] { 0, 2, 4, 6, 8 };
        WriteLine($"Digite o número que gostaria de encontrar: ");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if (idxEncontrado >= 0)
        {
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine("O número digitado não foi encontrado!");
        }
    }
}
