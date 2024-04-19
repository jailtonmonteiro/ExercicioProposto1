using System;
using System.Globalization;

namespace ExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            int stock, removeStock;

            Console.Write("NOME DO PRODUTO: ");
            product.Name = Console.ReadLine();

            Console.Write("PREÇO DO PRODUTO: ");
            product.Price = double.Parse(Console.ReadLine());

            Console.Write("QUANTIDADE DO PRODUTO: ");
            product.Quantity = int.Parse(Console.ReadLine());


            Console.WriteLine($"\n\n");
            Console.WriteLine($"PRODUTO: {product.Name}");
            Console.WriteLine($"PREÇO R$: {product.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUANTIDADE: {product.Quantity}");

            Console.WriteLine("\n");
            Console.Write("DIGITE A QUANTIDADE DE ENTRADA EM ESTOQUE: ");
            stock = int.Parse(Console.ReadLine());

            product.addProducts(stock);

            Console.WriteLine($"\n\n");
            Console.WriteLine($"PRODUTO: {product.Name}");
            Console.WriteLine($"PREÇO R$: {product.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUANTIDADE: {product.Quantity}");

            Console.WriteLine("\n");
            Console.Write("DIGITE A QUANTIDADE DE SAÍDA EM ESTOQUE: ");
            removeStock = int.Parse(Console.ReadLine());

            product.removeProducts(removeStock);

            Console.WriteLine($"\n\n");
            Console.WriteLine($"PRODUTO: {product.Name}");
            Console.WriteLine($"PREÇO R$: {product.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUANTIDADE: {product.Quantity}");

            product.totalValueStock();
        }
    }
}