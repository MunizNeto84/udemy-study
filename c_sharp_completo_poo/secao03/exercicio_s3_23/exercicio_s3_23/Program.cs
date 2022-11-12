/*
 Ler valor e  mostrarna tela 
 */

using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nome_completo = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preco de um produto: ");
double preco_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura: ");
string[] vetor = Console.ReadLine().Split(' ');

Console.WriteLine(nome_completo);
Console.WriteLine(quartos);
Console.WriteLine(preco_produto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(vetor[0]);
Console.WriteLine(vetor[1]);
Console.WriteLine(vetor[2]);


