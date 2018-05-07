using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie4
{
    public class Book : Product
    {
        public Book(string _name, int _price, int _ageLimit, string _author, string _edition) : base(_name, _price, _ageLimit)
        {
            author = _author;
            edition = _edition;
        }
        public string author { get; set; }
        public string  edition { get; set; }
        

        public override void print()
        {
            Console.WriteLine("Name: {0} | Author: {1} | Edition: '{2}' | Price {3} | Age limit: {4}", name, author, edition, price, ageLimit);
        }   
    }
}
