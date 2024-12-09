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
        DictionaryOfTransactions.TransctionsMethods method = new DictionaryOfTransactions.TransctionsMethods();
        Reports reports = new Reports();
        

        // Dictionary for the  main menu
        public Dictionary<int, Action> MainMenuOptions { get; private set; }
        // Constructor to Initialize the menu
        public MainMenu() {
            MainMenuOptions = new Dictionary<int, Action>
            {
                {1, managePropsMethod.ManageProperties },
                {2, manageClientsMethod.ManageClients },
                {3, RecordTransaction },
                {4, Reports },
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
            Console.WriteLine("2. View Transactions");
            Console.WriteLine("3. Back To Main Menu\n");
            Console.WriteLine("----------------------------------\n");
            Console.Write("Select an option: ");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    method.Record();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("           Transactions           ");
                    Console.WriteLine("----------------------------------\n");
                    method.View();
                    Console.WriteLine("----------------------------------\n");

                    Console.Write("Press any key to return to main menu: ");
                    Console.ReadLine();
                    NavigationUtils.BackToMain();

                    break;
                case 3:
                    NavigationUtils.BackToMain();
                    break;
                default:
                    Console.WriteLine("Incorrect option, please try again!");
                    return;



            }

        }

        // Reports Menu
        public void Reports()
        {

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Reports           ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Properties Report");
            Console.WriteLine("2. Cients Report");
            Console.WriteLine("3. Back To Main Menu\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Please enter an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("           Reports           ");
                    Console.WriteLine("----------------------------------\n");
                    Console.WriteLine("1. Residential Properties Report");
                    Console.WriteLine("2. Commercial Properties Report");
                    Console.WriteLine("3. Back To Main Menu\n");
                    Console.WriteLine("----------------------------------\n");

                    Console.Write("Select an option: ");
                    int option1 = Convert.ToInt32(Console.ReadLine());

                    if (option1 == 1){

                        reports.ResidentialPropertyReport();
                    }else if(option1 == 2){
                        reports.CommercialPropertyReport();

                    }else if (option1 == 3){
                        NavigationUtils.BackToMain();
                    }
                    break;
                case 2:
                    break;
                case 3:
                    NavigationUtils.BackToMain();
                    break;
                default:
                    Console.WriteLine("Invalid option, Please try again.");
                    return;
            }
        }


        // Exit
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting Program...");
            Environment.Exit(0);
           
        }

    }
}
