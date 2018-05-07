using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Zadanie6
{
    public class Organization : Client
    {
        public Organization(string _nameOfOrganization, DateTime _dateOfOpeningAccount, int _accountNumber, double _summOfAccount)
        {
            nameOfOrganization = _nameOfOrganization;
            dateOfOpeningAccount = _dateOfOpeningAccount;
            accountNumber = _accountNumber;
            summOfAccount = _summOfAccount;
        }

        public string nameOfOrganization { get; set; }
        public DateTime dateOfOpeningAccount { get; set; }
        public int accountNumber { get; set; }
        public double summOfAccount { get; set; }

        public override void print()
        {
            Console.WriteLine("Name of organization: {0}, Date of opening account: {1}, Account number: {2}, Summ of account: {3}", nameOfOrganization, dateOfOpeningAccount, accountNumber, summOfAccount);
        }
    }
}
