namespace Demo04
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var dir in retornoCaminho)
            {
                System.Console.WriteLine(dir);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarAquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
                File.WriteAllText(caminho, conteudo);
        }

        public void CriarAquivoTextoStream(string camingo, List<string> conteudo)
        {
            using(var stream = File.CreateText(camingo))
            {
            foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);               
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string camingo, List<string> conteudo)
        {
            using(var stream = File.AppendText(camingo))
            {
            foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);               
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while (linha = stream.ReadLine() != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
    }
}