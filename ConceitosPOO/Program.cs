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


Console.WriteLine($"Nome do cliente: {cliente.Nome}");

