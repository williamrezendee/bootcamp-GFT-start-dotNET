namespace Demo01.Models
{
    public class Retangulo
    {
        private double _comprimento;
        private double _largura;
        private bool _valoresValidos;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                _comprimento = comprimento;
                _largura = largura;
                _valoresValidos = true;
            }
            else
            {
                Console.WriteLine("Valores inválidos!");
            }
        }

        public double ObterArea()
        {
            if(_valoresValidos)
            {
                return _comprimento * _largura;
            }
            else
            {
                Console.WriteLine("Valores preenchidos inválidos!");
                return 0;
            }
        }
    }
}