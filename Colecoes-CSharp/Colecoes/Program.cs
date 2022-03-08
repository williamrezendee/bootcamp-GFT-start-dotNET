using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[] {100,1,4,0,8,15,19};
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();

            System.Console.WriteLine($"Mínino: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");

            // var numerosPares = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;
            
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            // System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosPares));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));

            // Dictionary<string, string> estados = new Dictionary<string, string>();
            // estados.Add("SP", "São Paulo");
            // estados.Add("SE", "Sergipe");
            // estados.Add("BA", "Bahia");
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // string valorProcurado = "BA";
            // if (estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário.");
            // }

            // System.Console.WriteLine("Valor Original:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - Teste";

            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
            // }
            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Leonardo");
            // fila.Enqueue("William");
            // fila.Enqueue("Bruna");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"A vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendida.");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            
            
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>() {"SP", "MG", "SE", "BA"};
            // string[] estadosArray = new String[2] {"CE", "RJ"};

            // Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            // opLista.ImprimirListaString(estados);

            // Console.WriteLine($"Removendo o elemento MG");
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");
            // opLista.ImprimirListaString(estados);
            
            
            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 7;
            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            // if (todosMaiorQue)
            // {
            //     Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);
            // if (existe)
            // {
            //     Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            // }

            // Console.WriteLine("Array Original");
            // op.ImprimirArray(array);
            // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);
            // Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);
            // Console.WriteLine("ArrayCopia antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // Console.WriteLine("ArrayCopia após a cópia");
            // op.Copiar(ref array, ref arrayCopia);
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4,2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;
            // Console.WriteLine("Percorrendo o array usando for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     Console.WriteLine(arrayInteiros[i]);
            // }
            // Console.WriteLine("Percorrendo o array usando foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}