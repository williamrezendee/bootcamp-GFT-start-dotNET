using static System.Console;

public class Program
{
    public static void Main()
    {
        int[] pares = new int[] {0, 2, 4, 6, 8};
        MudarParaImpar(pares);
        WriteLine($"Os impares {string.Join(",", pares)}");
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
}
