using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program
{
    public class MainMenu
    {
        ManagePropertiesMenu managePropsMethod = new ManagePropertiesMenu();
        ManageClientMenu manageClientsMethod = new ManageClientMenu();
        DictionaryOfTransactions listOfTrans = new DictionaryOfTransactions();
        TransactionMethod method = new TransactionMethod();

        // Dictionary for the  main menu
        public Dictionary<int, Action> MainMenuOptions { get; private set; }
        // Constructor to Initialize the menu
        public MainMenu() {
            MainMenuOptions = new Dictionary<int, Action>
            {
                {1, managePropsMethod.ManageProperties },
                {2, manageClientsMethod.ManageClients },
                {3, RecordTransaction },
                {4, VeiwReports },
                {5, Exit }
            };
        }

        // Record Transaction
        public void RecordTransaction()
        {
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Record Transaction       ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Record Transation");
            Console.WriteLine("2. View Transtions \n");
            Console.WriteLine("----------------------------------\n");
            Console.Write("Select an option: ");

            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                method.Record();
            }
            else if(option == 2)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("           Transactions           ");
                Console.WriteLine("----------------------------------\n");
                method.ViewRecords();
                Console.WriteLine("----------------------------------");
            }
     
        }

        // Viewing Reports 
        public void VeiwReports()
        {
            Console.WriteLine("Viewing reports");
        }

        // Exit
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting program...");
           
        }

    }
}
