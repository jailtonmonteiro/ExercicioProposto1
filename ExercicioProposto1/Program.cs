using System;
using System.Globalization;

namespace ExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double price;
            int quantity;

            int stock, removeStock;

            Console.Write("NOME DO PRODUTO: ");
            name = Console.ReadLine();

            Console.Write("PREÇO DO PRODUTO: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("QUANTIDADE DO PRODUTO: ");
            quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantity);

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