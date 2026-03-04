// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");

Cliente cliente = new Cliente();
cliente.Nome = "Francisco";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");

cliente.Cpf = "19759915758";
Console.WriteLine($"Cpf do cliente: {cliente.Cpf}");

Agencia agencia = new Agencia();
agencia.Numero = "24999242979";
Console.WriteLine($"Numero da agência: {agencia.Numero}");

agencia.Nome = "Flamengo";
Console.WriteLine($"Nome da agência: {agencia.Nome}");

agencia.Telefone = "2433451705";
Console.WriteLine($"O telefone da agencia: {agencia.Telefone}");