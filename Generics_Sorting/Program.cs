using System;
using System.Collections.Generic;

namespace Generics_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Телефон", 50000m),
                new Product("Ноутбук", 120000m),
                new Product("Наушники", 5000m),
                new Product("Планшет", 30000m)
            };

            Console.WriteLine("=== Исходный список товаров ===");
            PrintProducts(products);

            Console.WriteLine("\n=== Сортировка по цене (Sort() / IComparable) ===");
            products.Sort();
            PrintProducts(products);

            Console.WriteLine("\n=== Сортировка по названию (Sort(new NameComparer()) / IComparer) ===");
            products.Sort(new NameComparer());
            PrintProducts(products);

            Console.WriteLine("\n=== Сортировка по длине названия (Comparison<Product> / Лямбда) ===");
            products.Sort((a, b) => a.Name.Length.CompareTo(b.Name.Length));
            PrintProducts(products);

            Console.WriteLine("\n=== Интерактивный режим ===");

            while (true)
            {
                try
                {
                    Console.Write("Введите название товара (или 'stop' для выхода): ");
                    string nameInput = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(nameInput) || nameInput.Trim().ToLower() == "stop")
                    {
                        break;
                    }

                    Console.Write("Введите цену товара: ");
                    decimal priceInput = decimal.Parse(Console.ReadLine() ?? "0");

                    products.Add(new Product(nameInput, priceInput));

                    Console.WriteLine("\nВыберите вариант сортировки:");
                    Console.WriteLine("1. По цене");
                    Console.WriteLine("2. По имени");
                    Console.WriteLine("3. По длине имени");
                    Console.Write("Ваш выбор (1-3): ");
                    string choice = Console.ReadLine() ?? "";

                    if (choice == "1")
                    {
                        products.Sort();
                    }
                    else if (choice == "2")
                    {
                        products.Sort(new NameComparer());
                    }
                    else if (choice == "3")
                    {
                        products.Sort((a, b) => a.Name.Length.CompareTo(b.Name.Length));
                    }

                    Console.WriteLine("\nТекущий список товаров:");
                    PrintProducts(products);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено некорректное число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        private static void PrintProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}