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

        public Transaction( string transactionType, string transactionName)
        {
            transactionType = TransactionType;
            transactionName = TransactionName;
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
    }

    public class TransactionMethod()
    {
        public void Record()
        {
            string name;
            string type;
            int id = 0;

            Console.Write("Enter the name of the property: \n");
            name = Console.ReadLine();

            Console.Write("Enter the type of Transaction: \n");
            type = Console.ReadLine();
            id++;

            var trans = new Transaction(type, name);
            var list = new DictionaryOfTransactions();

            list.ListOfTransactions.Add(id, trans);

        }

        public void ViewRecords()
        {
            var list = new DictionaryOfTransactions();
            for (int i = 0; i < list.ListOfTransactions.Count; i++)
            {
                if(list.ListOfTransactions.Count > 0)
                {
                    Console.WriteLine(i);
                }
                else if (list.ListOfTransactions.Count < 0 || list.ListOfTransactions.Count == 0)
                {
                    Console.WriteLine("   No transactions recorded.\n");
                }
            }
            
        }
    }
}
