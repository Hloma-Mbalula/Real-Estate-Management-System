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
        PropertyManager property = new PropertyManager();
      


        public ManagePropertiesMenu()
        {
            ManagePropsMenuOptions = new Dictionary<int, Action>
            {
                { 1, Property.AddToCollection },
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

       

        // View all
        public void View()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Manage Properties        ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Residential Properties");
            Console.WriteLine("2. Commercial Properties\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Please select an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    foreach(var property in property.ResidentialProperties){
                        
                        Console.WriteLine("----------------------------------\n");
                        Console.WriteLine($"{property.Value.Name}");
                        Console.WriteLine($"\t{property.Value.PropertyType}");
                        Console.WriteLine($"\t{property.Value.Features}");
                        Console.WriteLine($"\t{property.Value.Location}\n");
                        Console.WriteLine($"\t\t R{property.Value.Price}\n");
                        Console.WriteLine("----------------------------------");  
                    };
                    Console.WriteLine("Press any button to return to main... ");
                    Console.ReadLine();

                    NavigationUtils.BackToMain();
                    break;

                case 2:
                    Console.Clear();
                    foreach(var property in property.CommercialProperties){
                        
                        Console.WriteLine("----------------------------------\n");
                        Console.WriteLine($"{property.Value.Name}");
                        Console.WriteLine($"\t{property.Value.PropertyType}");
                        Console.WriteLine($"\t{property.Value.Features}");
                        Console.WriteLine($"\t{property.Value.Location}\n");
                        Console.WriteLine($"\t\t R{property.Value.Price}\n");
                        Console.WriteLine("----------------------------------");
                        
                    };
                    Console.WriteLine("Press any button to return to main... ");
                    Console.ReadLine();

                    NavigationUtils.BackToMain();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again!");
                    return;
            }

        }

        // Search
        public void Search()
        {
            Console.Clear();
            Console.WriteLine("Residential or Commercial?");
            string type = Console.ReadLine();

            Console.Write("Type the full name of the property (This Program is case sensitive): ");
            string name = Console.ReadLine();

            if(type.Equals("Residential")){

                foreach(var i in property.ResidentialProperties){

                    if (name.Equals(i.Value.Name, StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();

                        Console.WriteLine($"{i.Value.Name}");
                        Console.WriteLine($"{i.Value.PropertyType}");
                        Console.WriteLine($"{i.Value.Features}");
                        Console.WriteLine($"{i.Value.Location}");
                        Console.WriteLine($"{i.Value.Price}\n");

                        Console.WriteLine("----------------------------------\n");
                        Console.WriteLine("Press any button to return to main menu..");
                        Console.ReadLine();

                        NavigationUtils.BackToMain();
                    }
                    else{
                        Console.WriteLine("Property could not be found, sorry!");
                        Thread.Sleep(1000);

                        NavigationUtils.BackToMain();
                    }
                }

            }else if (type.Equals("Commercial")){

                    foreach(var i in property.CommercialProperties ){

                        if (name.Equals(i.Value.Name, StringComparison.OrdinalIgnoreCase)){
                            Console.Clear();

                            Console.WriteLine($"{i.Value.Name}");
                            Console.WriteLine($"{i.Value.PropertyType}");
                            Console.WriteLine($"{i.Value.Features}");
                            Console.WriteLine($"{i.Value.Location}");
                            Console.WriteLine($"{i.Value.Price}\n");

                            Console.WriteLine("----------------------------------\n");
                            Console.WriteLine("Press any button to return to main menu..");
                            Console.ReadLine();

                            NavigationUtils.BackToMain();
                        }else{
                            Console.WriteLine("Property could not be found, sorry!");
                            Thread.Sleep(1000);

                            NavigationUtils.BackToMain();
                        }
            }
        }else{
                Console.WriteLine("Invalid option!");
                Search();
            }}

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
            NavigationUtils.BackToMain();
        }
    }
}
