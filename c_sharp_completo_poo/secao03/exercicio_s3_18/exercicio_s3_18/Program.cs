// exercicio de fixação

using System;
using System.Globalization;

namespace Ex03_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prod01 = "Computador";
            string prod02 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(prod01 + ", " + "cujo o preço é $ " + preco1);
            Console.WriteLine(prod02 + ", " + "cujo o preço é $ " + preco2);

            Console.WriteLine("Registro: " + idade + " anos de idade, " + "código " + codigo + " e gênero: " + genero);

            Console.WriteLine("Medida com oito casas decimais: " + preco3.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais): " + preco3.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + preco3.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}