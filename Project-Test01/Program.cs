using System;
using System.Globalization;
namespace Product_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Product's Data: ");
            Product product = new Product();
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Product's Data: ");
            Console.WriteLine(product);
            Console.WriteLine();

            Console.Write("Type the number of products to be added to the stock:  ");
            int ExtraQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            product.AddProducts(ExtraQuantity);

            Console.Write("Updated Data: ");
            Console.Write(product);
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Type the number of products to be removed from the stock: ");
            int QuantityRemove = int.Parse(Console.ReadLine());
            Console.WriteLine();

            product.RemoveProducts(QuantityRemove);

            Console.Write("Updated Data: ");
            Console.WriteLine(product);
        }
    }
}
