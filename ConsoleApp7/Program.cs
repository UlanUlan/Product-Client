using ConsoleApp7.Zadanie4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] editions = { "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };
            Random rand = new Random();
            List<Product> prod = new List<Product>();
            for (int i = 0; i < rand.Next(1,20); i++)
            {
                int index = rand.Next(editions.Length);
                int index1 = rand.Next(editions.Length);
                int index2 = rand.Next(editions.Length);
                if (i % 2 == 0)
                    prod.Add(new Book(editions[index], rand.Next(100, 10000), rand.Next(18), editions[index1], editions[index2]));
                else if (i % 3 == 0)
                    prod.Add(new Toy(editions[index], rand.Next(100, 10000), rand.Next(18)));
                else
                    prod.Add(new SportStock(editions[index], rand.Next(100, 10000), rand.Next(18), editions[index2]));
            }
            foreach (Product item in prod)
            {
                item.print();
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("\n*************************************************************\n");

            //Поиск по типу товара
            void searchByType(object o)
            {
                foreach (Product item in prod)
                {
                    if (item.GetType() == o.GetType())
                    {
                        item.print();
                        Console.WriteLine("------------------------------");
                    }
                }
            }
            Console.WriteLine("Поиск книг\n");
            searchByType(new Book("", 0, 0, "", ""));
            //Console.WriteLine("Поиск игрушек\n");
            //searchByType(new Toy("", 0, 0));
            //Console.WriteLine("Поиск спорттоваров\n");
            //searchByType(new SportStock("", 0, 0, ""));
        }
    }
}
