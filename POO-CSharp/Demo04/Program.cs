using System.Collections.Generic;
namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = @"C:\temp";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta1");
            var caminhoArquivo = Path.Combine(caminho, "arquivoTeste-stream.txt");
            var listaString = new List<string>() {"Linha1","Linha2", "Linha3"};
            var listaStringContinuacao = new List<string>() {"Linha4","Linha5","Linha6"};

            FileHelper helper = new FileHelper();

            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarAquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
            //helper.CriarAquivoTextoStream(caminhoArquivo, ListaString);
            //helper.AdicionarTexto(caminho, listaString);
            //helper.AdicionarTextoStream(caminho, listaStringContinuacao);
            helper.LerArquivoStream(caminhoArquivo);

        }
    }
}
