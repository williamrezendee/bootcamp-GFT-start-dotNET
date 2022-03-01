CriarDiretorioGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America", "Brasil");
MoverArquivo(origem, destino);

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe.");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta destino.");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using (var sw = File.CreateText(path))
        {
            sw.WriteLine("População: 213MM");
            sw.WriteLine("IDH: 0,901");
            sw.WriteLine("Dados atualizados em: 23/02/2022");
        }
    }
}

static void CriarDiretorioGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmerica = dirGlobo.CreateSubdirectory("America");
        var dirEuropa = dirGlobo.CreateSubdirectory("Europa");
        var dirAfrica = dirGlobo.CreateSubdirectory("Africa");

        dirAmerica.CreateSubdirectory("Brasil");
        dirAmerica.CreateSubdirectory("Canada");

        dirEuropa.CreateSubdirectory("Estonia");
        dirEuropa.CreateSubdirectory("Holanda");

        dirAfrica.CreateSubdirectory("Mocambique");
        dirAfrica.CreateSubdirectory("Angola");
    }
}