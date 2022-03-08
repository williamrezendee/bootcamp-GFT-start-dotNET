namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 0;
            double resultado = 0;

            try
            {
                resultado = Dividir(a, b);
                System.Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Divisão finalizada!");
            }
        }

        static double Dividir(int x, int y)
        {
            if (y == 0)
                throw new MyClassException("Minha mensagem customizada de erro!");
            return x / y;
        }
    }
}
