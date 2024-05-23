// Criação de uma instância da classe ContaBancaria chamada "conta" utilizando o construtor padrão
ContaBancaria conta = new ContaBancaria();

// Inicialização dos atributos da conta "conta" utilizando a notação de ponto
conta.Titular.Nome = "Gabriel";
conta.Titular.CPF = "157.336.626.70";
conta.Agencia = 0001;
conta.NumeroDaConta = 223040;
conta.Saldo = 20000;
conta.Limite = 50000;

// Exibição das informações da conta "conta"
conta.ExibirInfos();

// Criação de uma nova instância da classe ContaBancaria chamada "conta2" utilizando inicialização de objeto
ContaBancaria conta2 = new ContaBancaria
{
    Titular = new Titular { Nome = "Cristiano", CPF = "157.336.626.70" },
    Agencia = 0005,
    NumeroDaConta = 253740,
    Saldo = 2000.000,
    Limite = 500000
};

// Exibição das informações da conta "conta2"
conta2.ExibirInfos();

// Criação de uma instância da classe Titular chamada "titular3" e utilização dela na criação da conta "conta3"
Titular titular3 = new Titular
{
    Nome = "João",
    CPF = "123.456.789-00"
};

ContaBancaria conta3 = new ContaBancaria(titular3); // Criação da conta "conta3" com um titular específico

// Inicialização dos atributos da conta "conta3" utilizando a notação de ponto
conta3.Agencia = 7;
conta3.NumeroDaConta = 223040;
conta3.Saldo = 20000;
conta3.Limite = 50000;

// Exibição das informações da conta "conta3"
conta3.ExibirInfos();







