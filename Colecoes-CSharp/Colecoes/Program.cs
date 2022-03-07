using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>() {"SP", "MG", "SE", "BA"};
            string[] estadosArray = new String[2] {"CE", "RJ"};

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            opLista.ImprimirListaString(estados);

            // Console.WriteLine($"Removendo o elemento MG");
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);
            estados.Insert(1, "RJ");
            opLista.ImprimirListaString(estados);
            
            
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