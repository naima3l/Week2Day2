using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2.esercizioBANCA
{
    class Conto
    {
        public string BankNumber { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }

        public Conto(string banknumber, string holder, decimal balance)
        {
            BankNumber = banknumber;
            Holder = holder;
            Balance = balance;
        }
    }
}
