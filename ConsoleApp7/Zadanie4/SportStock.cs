using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie4
{
    public class SportStock : Product
    {

        public SportStock(string _name, int _price, int _ageLimit, string _maker) : base(_name, _price, _ageLimit)
        {
            maker = _maker;
        }
        public string maker { get; set; }

        public override void print()
        {
            Console.WriteLine("Name: {0} | Maker: '{1}' | Price {2} | Age limit: {3}", name, maker, price, ageLimit);
        }
    }
}
