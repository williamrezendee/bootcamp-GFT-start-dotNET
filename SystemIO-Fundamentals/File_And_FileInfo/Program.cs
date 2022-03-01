using System;
using System.Security.AccessControl;
using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nomeArquivo = ReadLine();
nomeArquivo = LimparNome(nomeArquivo);

var path = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");

static void CriarArquivo(string path)
{
    try
    {
        using (var sw = File.CreateText(path))
        {
            sw.WriteLine("Esta é a 1ª linha do arquivo.");
            sw.WriteLine("Esta é a 2ª linha do arquivo.");
            sw.WriteLine("Esta é a 3ª linha do arquivo.");
        }
    }
    catch
    {
        WriteLine("O nome do arquivo é inválido.");
    }   
}

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

CriarArquivo(path);
WriteLine("Digite Enter para finalizar...");
ReadLine();