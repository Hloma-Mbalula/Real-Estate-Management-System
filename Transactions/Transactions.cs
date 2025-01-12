using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Program;

namespace Program
{
    public class Transaction
    {

        public string TransactionType { get; set; }
        public string TransactionName { get; set; }
        public double TransactionValue { get; set; }
        public int TransactionId { get; private set; }

        public static int TotalTransactions = 1;

        public Transaction( string transactionType, string transactionName, double transactionValue ) 
        {
            TransactionType = transactionType;
            TransactionName = transactionName;
            TransactionValue = transactionValue;
            TransactionId = TotalTransactions++;
        }

        public override string ToString()
        {
            return $"{TransactionName}" +
                   $"{TransactionType}" +
                   $"Value of the Property: R{TransactionValue}.00";
        }
    }

    public class DictionaryOfTransactions
    {
        public static Dictionary<int, Transaction> ListOfTransactions;
        public static int transactionCounter;

        public DictionaryOfTransactions()
        {
            ListOfTransactions = new Dictionary<int, Transaction>
            {
                {1, new Transaction("Sell", "House Lovona", 10_000_000) }
            };
        }
    }

    public class TransactionMethods
    {
        //Add Methods
        public void AddTransaction(Transaction transaction)
        {
            DictionaryOfTransactions.ListOfTransactions.Add(TratransactionCounter+1, transaction);
        }

        //View Method
        public void ViewTransactions()
        {
            if (DictionaryOfTransactions.ListOfTransactions.Count == 0)
            {
                Console.WriteLine("No transactions recorded.\n");
            }
            else
            {
                foreach (var transaction in DictionaryOfTransactions.ListOfTransactions)
                {
                    Console.WriteLine($"List of Transactions\n");
                    Console.WriteLine($"{transaction.Value}\n");
                }
                Console.WriteLine("End of the list...");
            }
        }

        // Record Transaction
        public void Record()
        {
            Console.Write("Enter the name of the transaction: ");
            string name = Console.ReadLine();

            Console.Write("Enter the name of transaction: ");
            string type = Console.ReadLine();

            Console.WriteLine("What was the total value of the transaction: ");
            double value = ConvertToDouble(Console.ReadLine());

            var transaction = new Transaction(type, name, value);
            DictionaryOfTransactions.ListOfTransactions.AddTransaction(transaction);

            Thread.Sleep(1000);
            Console.WriteLine("Recording...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Transaction recorded successfully!\n");


            Console.WriteLine("Enter any key to return to main menu: ");
            Console.ReadLine();
            NavigationUtils.BackToMain();

        }
    }
}














