using System;

class Program
{
    // Struct para armazenar os dados do usuário
    struct Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;

        // Construtor da struct
        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        // Função para calcular a idade da pessoa
        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            // Ajuste caso a pessoa ainda não tenha feito aniversário este ano
            if (DateTime.Now < DataNascimento.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }

        // Função para verificar se a pessoa é maior de idade
        public string VerificarMaiorIdade()
        {
            int idade = CalcularIdade();
            if (idade >= 18)
            {
                return "Você é maior de idade e pode tirar a carteira de habilitação!";
            }
            else
            {
                return "Você é menor de idade e não está apto para tirar a habilitação ainda.";
            }
        }
    }

    static void Main(string[] args)
    {
        // Entrada de dados
        Console.WriteLine("Digite seu nome completo:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua data de nascimento (formato: dd/MM/yyyy):");
        DateTime dataNascimento;
        string dataInput = Console.ReadLine();

        // Validar o formato da data
        while (!DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            Console.WriteLine("Data inválida. Por favor, insira a data no formato correto (dd/MM/yyyy):");
            dataInput = Console.ReadLine();
        }

        // Instanciando a struct com os dados do usuário
        Pessoa pessoa = new Pessoa(nome, dataNascimento);

        // Usando as funções da struct
        int idade = pessoa.CalcularIdade();
        string mensagem = pessoa.VerificarMaiorIdade();

        // Saída
        Console.WriteLine($"\nOlá, {pessoa.Nome}!");
        Console.WriteLine($"Sua idade é: {idade} anos.");
        Console.WriteLine(mensagem);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
