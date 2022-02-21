using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "William";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua teste",
    Numero = 300,
    CEP = "000000",
    Cidade = "Itabaiana"
};

WriteLine("FIM");
