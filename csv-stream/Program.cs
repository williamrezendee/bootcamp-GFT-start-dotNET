using static System.Console;

CriarCsv();
WriteLine("\nPressione [Enter] para finalizar...");
ReadKey();

static void CriarCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "William Rezende",
            Email = "wr@gmail.com",
            Telefone = 99887766,
            Nascimento = new DateOnly(year: 1992, month: 12, day: 6)
        },
        new Pessoa()
        {
            Nome = "Carlos José",
            Email = "cj@gmail.com",
            Telefone = 99552211,
            Nascimento = new DateOnly(year: 1987, month: 3, day: 23)
        },
        new Pessoa()
        {
            Nome = "Josefa Maria",
            Email = "jm@gmail.com",
            Telefone = 88442277,
            Nascimento = new DateOnly(year: 1986, month: 9, day: 21)
        }
    };

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path,"usuarios.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

static void LerCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "usuarios-exportacao.csv");

    using var sr = new StreamReader(path);
    var cabecalho = sr.ReadLine()?.Split(',');

    while (true)
    {
        var registro = sr.ReadLine()?.Split(',');
        if(registro == null) break;
        for (int i = 0; i < registro.Length; i++)
        {
            WriteLine($"{cabecalho?[i]}:{registro[i]}");
        }
        WriteLine("---------------------------");
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}