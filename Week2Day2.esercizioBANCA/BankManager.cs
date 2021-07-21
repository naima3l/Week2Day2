using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2.esercizioBANCA
{
    class BankManager
    {
        static List<Conto> accounts = new List<Conto>();
        

        internal static void NewBankAccount(string data, string code)
        {
            Conto conto = new Conto(code, data, 0);
            accounts.Add(conto);
            
        }

        internal static void WithdrawByCode(string code, decimal withdraw)
        {
            foreach(Conto account in accounts)
            {
                if(account.BankNumber != code)
                {
                    Console.WriteLine("Mi dispiace, ma non esiste nessun conto con questo codice");
                }
                else
                {
                    if(account.Balance < withdraw )
                    {
                        Console.WriteLine("Mi dispiace ma nel tuo conto c'è un importo minore di quello che vuoi prelevare ");
                    }
                }
            }
        }
    }
}
