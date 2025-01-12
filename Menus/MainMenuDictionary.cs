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

        // Dictionary for the  main menu
        public Dictionary<int, Action> MainMenuOptions { get; private set; }
        // Constructor to Initialize the menu
        public MainMenu() {
            MainMenuOptions = new Dictionary<int, Action>
            {
                {1, MainMenuMethods.ManageProperties },
                {2, ManageClientMenu.ManageClients },
                {3, MainMenuMethods.RecordTransaction },
                {4, MainMenuMethods.Reports },
                {5, MainMenuMethods.Exit }
            };
        }
    }

    public class MainMenuMethods
    {
        public void ManageProperties()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Manage Properties        ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Add Property");
            Console.WriteLine("2. View Properties");
            Console.WriteLine("3. Search Properties");
            Console.WriteLine("4. Delete Properties");
            Console.WriteLine("5. Back to Main Menu\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Please select an option: ");

            try
            {
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    if (MainMenu.ManagePropsMenuOptions.TryGetValue(option, out Action action))
                    {
                        Console.Clear();
                        action.Invoke();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option, please try again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option, please select a number.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
                return;
            }
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
                    TransactionMethods.Record();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("           Transactions           ");
                    Console.WriteLine("----------------------------------\n");
                    TransactionMethods.ViewTransactions();
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

                    if (option1 == 1)
                    {

                        ManagePropertiesMethods.ResidentialPropertyReport();

                    }
                    else if (option1 == 2)
                    {

                        ManagePropertiesMethods.CommercialPropertyReport();

                    }
                    else if (option1 == 3)
                    {
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