using static System.Console;
public class Program
{
    static void Adicionar20(ref int x)
    {
        x = x + 20;
    }
    public static void Main()
    {
        int a = 2;
        Adicionar20(ref a);

        WriteLine($"O valor da variável a é {a}");
    }
}
