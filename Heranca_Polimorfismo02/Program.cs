using System;
using System.Collections.Generic;
using Heranca_Polimorfismo02.Entities;
using System.Globalization;


namespace Heranca_Polimorfismo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} date:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ress = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ress == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(nameProduct, price, customsFee));
                }

                else if (ress == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(nameProduct, price, date));
                }

                else
                {
                    list.Add(new Product(nameProduct, price));
                }
            }
            Console.WriteLine("PRICE TAGS:");

            foreach (Product pro in list)
            {
                Console.WriteLine(pro.PricTag() + " ");
            }
        }
    }
}
