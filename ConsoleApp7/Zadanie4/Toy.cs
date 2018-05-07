using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie4
{
    class Toy : Product
    {
        public Toy(string _name, int _price, int _ageLimit) : base(_name, _price, _ageLimit)
        {

        }
        public string maker { get; set; }
        public string material { get; set; }

        public override void print()
        {
            Console.WriteLine("Name: {0} | Price {1} | Age limit: {2}", name, price, ageLimit);
        }
    }
}
