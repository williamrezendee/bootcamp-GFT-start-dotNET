namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int _mes;
        private bool _mesValido;

        public int GetMes()
        {
            return _mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                _mes = mes;
                _mesValido = true;
            }
        }

        public void ApresentarMes()
        {
            if (_mesValido)
            {
                System.Console.WriteLine(GetMes());
            }
            else
            {
                System.Console.WriteLine("Mês inválido!");
            }
        }
    }
}