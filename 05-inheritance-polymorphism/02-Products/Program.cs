using System.Globalization;
using _02_Products.Entities;

namespace _02_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Value per Hour: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (productType == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else {
                    throw new ArgumentException("Invalid input. Expected 'c' or 'u' or 'i'.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}