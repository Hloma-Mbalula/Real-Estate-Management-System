using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program
{
    public class ManagePropertiesMenu
    {
        public Dictionary<int, Action> ManagePropsMenuOptions { get; private set; }
        public string propetyName { get; set; }
        public string propertyLocation { get; set; }
        public string propertyType { get; set; }


        public ManagePropertiesMenu()
        {
            ManagePropsMenuOptions = new Dictionary<int, Action>
            {
                { 1, Add },
                { 2, View },
                { 3, Search },
                { 4, Edit },
                { 5, Delete },
                { 6, Back }
            };
        }
        public void ManageProperties()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Manage Properties        ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Add Property");
            Console.WriteLine("2. View Properties");
            Console.WriteLine("3. Search Properties");
            Console.WriteLine("4. Edit Propertiies");
            Console.WriteLine("5. Delete Properties");
            Console.WriteLine("6. Back to Main Menu\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Please select an option: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (ManagePropsMenuOptions.TryGetValue(option, out Action action))
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

        public void Add()
        {
            Console.WriteLine();

        }

        // View all
        public void View()
        {
            Console.WriteLine();
        }

        // Search
        public void Search()
        {
            Console.WriteLine();
        }

        // Edit
        public void Edit()
        {
            Console.WriteLine();
        }

        // Delete
        public void Delete()
        {
            Console.WriteLine();

        }

        // Back to main menu
        public void Back()
        {
            Console.Clear();

        }
    }
}
