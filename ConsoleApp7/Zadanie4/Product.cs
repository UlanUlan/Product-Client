using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie4
{
    public abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int ageLimit { get; set; }
        public Product(string _name, int _price, int _ageLimit)
        {
            name = _name;
            price = _price;
            ageLimit = _ageLimit;
        }
        public abstract void print();
        
    }
}
