namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        // Evento
        public static event DelegateCalculadora? EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x+y}");
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito!");
            }
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtrair: {x-y}");
        }
    }
}