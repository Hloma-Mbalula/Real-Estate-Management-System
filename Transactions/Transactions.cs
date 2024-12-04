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

        public string TransactionType { get; private set; }
        public int TransactionId { get; private set; }

        public string TransactionName { get; private set; }

        public Transaction( string transactionType, string transactionName, int transactionId) 
        {
            transactionType = TransactionType;
            transactionName = TransactionName;
            transactionId = TransactionId;
        }

        // Record method
        
    }  
    public class DictionaryOfTransactions
    {
        public Dictionary<int, Transaction> ListOfTransactions;

        public DictionaryOfTransactions()
        {
            ListOfTransactions = new Dictionary<int, Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            ListOfTransactions.Add(transaction.TransactionId, transaction);
        }

        public void ViewTransactions()
        {
            if (ListOfTransactions.Count == 0)
            {
                Console.WriteLine("No transactions recorded.\n");
            }
            else
            {
                foreach(var transaction in ListOfTransactions)
                {
                    Console.WriteLine($"ID: {transaction.Key} - Type: {transaction.Value.TransactionType} - Name: {transaction.Value.TransactionName}");
                }
            }
        }

        // class that holds transctions methods
        public class TransctionsMethods
        {
            private static DictionaryOfTransactions transactionList = new DictionaryOfTransactions();
            private static int transactionIdCounter = 1;

            public void Record()
            {
                Console.Write("Enter the name of the transaction: ");
                string name = Console.ReadLine();

                Console.Write("Enter the name of transaction: ");
                string type = Console.ReadLine();

                var transaction = new Transaction(type, name, transactionIdCounter);
                transactionList.AddTransaction(transaction);

                transactionIdCounter++;
                Console.WriteLine("Transaction recorded successfully!\n");
            }

            public void View()
            {
                transactionList.ViewTransactions();
            }

        }

        
    }
}
