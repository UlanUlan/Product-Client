using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie6
{
    public class Depositor : Client
    {
        public Depositor(string _surName, DateTime _dateStartDeposit, double _depositSize, double _procentOfDeposit)
        {
            surName = _surName;
            dateStartDeposit = _dateStartDeposit;
            depositSize = _depositSize;
            procentOfDeposit = _procentOfDeposit;
        }

        public string surName { get; set; }
        public DateTime dateStartDeposit { get; set; }
        public double depositSize { get; set; }
        public double procentOfDeposit { get; set; }

        public override void print()
        {
            Console.WriteLine("Surname: {0}, Date start of deposit: {1}, Deposit size: {2}, Procent of deposit: {3}", surName, dateStartDeposit, depositSize, procentOfDeposit);
        }
       
    }
}
