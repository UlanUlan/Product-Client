using ConsoleApp7.Zadanie4;
using ConsoleApp7.Zadanie6;
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
            string[] banks = { "HalykBank", "KKB", "ForteBank", "CentralCredit" };
            Random rand = new Random();
            void Zadanie4()
            {
                /*1.	Создать абстрактный класс Товар с методами, позволяющими вывести на экран информацию о товаре, а также определить, соответствует ли она искомому типу.
                  2.	Создать производные классы: Игрушка (название, цена, производитель, материал, возраст, на который рассчитана), Книга (название, автор, цена, издательство, возраст, на который рассчитана),
                  Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитана), со своими методами вывода информации на экран, и определения соответствия искомому типу.
                  3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск товаров определенного типа.
                  */
                List<Product> prod = new List<Product>();
                for (int i = 0; i < rand.Next(1, 20); i++)
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
            Zadanie4();
            void Zadanie6()
            {
                /*1.	Создать абстрактный класс Клиент с методами, позволяющими вывести на экран информацию о клиентах банка, а также определить соответствие клиента критерию поиска.
                  2.	Создать производные классы: Вкладчик (фамилия, дата открытия вклада, размер вклада, процент по вкладу), Кредитор (фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга), 
                  Организация (название, дата открытия счета, номер счета, сумма на счету) со своими методами вывода информации на экран, и определения соответствия дате (открытия вклада, выдаче кредита, открытия счета).
                  3.	Создать базу (массив) из n клиентов, вывести полную информацию из базы на экран, а также организовать поиск клиентов, начавших сотрудничать с банком в заданную дату.
                  */

                List<Client> client = new List<Client>();
                for (int i = 0; i < rand.Next(200, 400); i++)
                {
                    int index = rand.Next(editions.Length);
                    int index1 = rand.Next(banks.Length);
                    if (i == 0)
                        client.Add(new Organization(banks[index1], DateTime.Now.AddMonths(rand.Next(1, 36) * -1), rand.Next(), rand.Next(1000, 1000000)));
                    else if (i % 2 == 0)
                        client.Add(new Depositor(editions[index], DateTime.Now.AddMonths(rand.Next(1, 36) * -1), rand.Next(1000, 1000000), rand.Next(5, 15)));
                    else
                        client.Add(new Creditor(editions[index], DateTime.Now.AddMonths(rand.Next(1, 36) * -1), rand.Next(1000, 1000000), rand.Next(5, 15), rand.Next(1000, 1000000)));
                }
                List<Client> client1 = new List<Client>();
                foreach (Client item in client)
                {
                    item.print();
                    Console.WriteLine("---------------------------------------------------");
                }

                DateTime data = DateTime.Now.AddMonths(rand.Next(1, 36) * -1);

                void depos(object o)
                {
                    foreach (Client item in client)
                    {
                        if (item.GetType() == o.GetType())
                            client1.Add(item);
                    }
                }
                depos(new Depositor("", DateTime.Now, 0, 0));

                void searchDepositorsByDate(DateTime DT)
                {
                    foreach (Depositor item in client1)
                    {
                        if (item.dateStartDeposit.Date == DT.Date)
                        {
                            item.print();
                            Console.WriteLine("---------------------------------------------------");
                        }
                    }
                }
                Console.WriteLine("\n*****************************************************************************\n\nВкладчики, начавшие сотрудничать с банком в заданную дату\n");

                searchDepositorsByDate(data);

            }
            //Zadanie6();
        }
    }
}
