using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie6
{
    public class Creditor : Client
    {
        public Creditor(string _surName, DateTime _dateOfCredit, double _creditSize, double _ProcentOfCredit, double _debt)
        {
            surName = _surName;
            dateOfCredit = _dateOfCredit;
            creditSize = _creditSize;
            ProcentOfCredit = _ProcentOfCredit;
            debt = _debt;
        }
        public string surName { get; set; }
        public DateTime dateOfCredit { get; set; }
        public double creditSize { get; set; }
        public double ProcentOfCredit { get; set; }
        public double debt { get; set; }

        public override void print()
        {
            Console.WriteLine("Surname: {0}, Date of credit: {1}, Credit size: {2}, Size of credit: {3}, Debt: {4}", surName, dateOfCredit, creditSize, ProcentOfCredit, debt);
        }
    }
}
