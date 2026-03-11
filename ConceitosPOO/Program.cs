// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");

//Agencia//
Agencia agencia = new Agencia(123);
agencia.Nome = "UGBVR";
Console.WriteLine($"Nome da agência: {agencia.Nome}");

agencia.Telefone = "2433451705";
Console.WriteLine($"O telefone da agencia: {agencia.Telefone}");

//Cliente//
Console.Write("Informe o nome do cliente: ");
string nome = Console.ReadLine();
Console.Write("Informe o CPF do cliente: ");
string cpf = Console.ReadLine();

Cliente cliente = new Cliente(nome, cpf);


Console.WriteLine("Informe o número da conta: ");
long numero = long.Parse(Console.ReadLine());

Console.WriteLine($"Informe o saldo inicial da conta {numero}: ");
decimal saldoinicial = decimal.Parse(Console.ReadLine());

//imprimir os dados da conta
Conta conta = new Conta(numero, saldoinicial);
Console.WriteLine($" A conta número {conta.Numero} possui saldo {conta.Saldo}");
//depositar 1000 na conta
conta.Deposito(1000);
//exibir saldo
Console.WriteLine($"A conta número {conta.Numero} possui saldo {conta.Saldo}");
//sacar 500 da conta
conta.Saque(500);
//exibir saldo
Console.WriteLine($"A conta número {conta.Numero} possui saldo {conta.Saldo}");

