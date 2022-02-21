using static System.Console;

class Program
{
    static void AlterarNome(string[] nomes, string nome, string novoNome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
                nomes[i] = novoNome;
        }
    }

    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
                return ref nomes[i];
        }
        throw new Exception("Nome não encontrado.");
    }

    static void Main()
    {
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

        WriteLine($@"A lista de nomes é:
            {string.Join(",\n", nomes)}
        ");

        WriteLine("Digite o nome a ser substituído:");
        var nome = ReadLine();
        WriteLine("Digite o novo nome:");
        var novoNome = ReadLine();

        //AlterarNome(nomes, nome, novoNome);
        ref var nomeAchado = ref LocalizarNome(nomes, nome);

        if(!string.IsNullOrWhiteSpace(nomeAchado))
        {
            nomeAchado = novoNome;

            WriteLine($@"A lista de nomes Alterada é:
                {string.Join(", \n", nomes)}
            ");
        }

        WriteLine($@"A lista de nomes alterados é:
            {string.Join(",\n", nomes)}
        ");
    }
}
