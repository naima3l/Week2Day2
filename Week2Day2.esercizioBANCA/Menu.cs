using System;

namespace Week2Day2.esercizioBANCA
{
    internal class Menu
    {
        internal static void Start()
        {
            char choice;
            do
            {
                Console.WriteLine("Benvenuto nella banca dei sogni!");

                Console.WriteLine("Premi 1 per creare un nuovo conto \nPremi 2 per prelevare da un conto \nPremi 3 per versare su un conto \nPremi 4 per visualizzare il saldo di un conto \nPremi 5 per eliminare un conto \nPremi Q per uscire");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        //nuovo conto corrente
                        CreateNewBankAccount();
                        break;
                    case '2':
                        //prelevare da un conto
                        Withdraw();
                        break;
                    case '3':
                        //versare su un conto
                        BookManager.ShowBooks();
                        break;
                    case '4':
                        //visualizzare il saldo di un conto
                        ShowBookByGenre();
                        break;
                    case '5':
                        //eliminare un conto
                        ShowBookByGenre();
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("\nScelta non valida!");
                        break;
                }
            } while (choice != 'Q');
        }

        private static void Withdraw()
        {
            Console.WriteLine("Inserisci il numero del conto da cui vuoi prelevare");
            string code = Console.ReadLine();
            Console.WriteLine("Inserisci l'importo che vuoi prelevare (es. 50, 30 ecc)");
            decimal withdraw;
            while(!decimal.TryParse(Console.ReadLine(), out withdraw) || withdraw <= 0)
            {
                Console.WriteLine("Inserisci un importo corretto!");
            }
            BankManager.WithdrawByCode(code, withdraw);
        }

        private static void CreateNewBankAccount()
        {
            string data = "";
            while(data.Length < 1)
            {
                Console.WriteLine("Per creare un nuovo conto corrente, inserisci il tuo nome e cognome separati da uno spazio");
            }
            
            data = Console.ReadLine();

            Random random = new Random();
            int nextInt = random.Next(000000, 999999);
            string code = "a" + nextInt;


            BankManager.NewBankAccount(data, code);
            Console.WriteLine($"Il tuo nuovo conto ha numero : {code}");
        }
    }
}