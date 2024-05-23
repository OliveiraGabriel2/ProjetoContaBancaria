// Classe ContaBancaria: representa uma conta bancária com propriedades para Agencia, Titular, NumeroDaConta, Saldo e Limite.

class ContaBancaria
{
    public int Agencia { get; set; } // Número da agência da conta
    public Titular Titular { get; set; } // Titular da conta, do tipo Titular
    public int NumeroDaConta { get; set; } // Número da conta
    public double Saldo { get; set; } // Saldo atual da conta
    public double Limite { get; set; } // Limite de crédito da conta

    public ContaBancaria()
    {
        // Construtor padrão: inicializa o objeto Titular para evitar referência nula
        this.Titular = new Titular();
    }

    public ContaBancaria(Titular titular)
    {
        // Construtor que recebe um titular como parâmetro e o associa à conta
        Titular = titular;
    }

    // Método ExibirInfos: exibe todas as informações da conta
    public void ExibirInfos()
    {
        Console.WriteLine($"Titular da conta: {Titular.Nome}");
        Console.WriteLine($"CPF do titular: {Titular.CPF}");
        Console.WriteLine($"Agencia: {Agencia}");
        Console.WriteLine($"Número da conta: {NumeroDaConta}");
        Console.WriteLine($"Saldo da conta: R${Saldo:F2}");
        Console.WriteLine($"Limite da conta: R${Limite:F2}");
    }
}