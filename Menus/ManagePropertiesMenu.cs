using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program
{

    // This file should handle everything about the Properties and managing properties

    public class Property
    {

        public string Name { get; set; }

        public string PropertyType { get; set; }

        public string Features { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }

        public Property(string name, string type, string features, string location, double price)
        {
            Name = name;
            PropertyType = type;
            Features = features;
            Location = location;
            Price = price;
        }

        public override string ToString()
        {
            return $"Property Name: {Name}\n" +
                   $"Property Type: {PropertyType}\n" +
                   $"Property Features: {Features}\n" +
                   $"Property Location: {Location}\n" +
                   $"Property Price: {Price}";
        }

    }

    public class PropertyManager
    {
        public static Dictionary<int, Property> ResidentialProperties { get; set; }
        public static Dictionary<int, Property> CommercialProperties { get; set; }
        public static int residentialCounter = 1;
        public static int commercialCounter = 1;



        public PropertyManager()
        {
            ResidentialProperties = new Dictionary<int, Property>
            {
                { 1, new Property("Lonova House", "Residential", "2 Bedrooms, Swimming Pool", "Sandton", 1200000) }
            };

            CommercialProperties = new Dictionary<int, Property>{
                {1, new Property("The Bank","Commercial","12 Story Building","Rosebank, Johannesburg", 20000000)
                }
            };

        }

    }

    // Manage Properties 
    public class ManagePropertiesMenu
    {
        public Dictionary<int, Action> ManagePropsMenuOptions { get; private set; }

        public ManagePropertiesMenu()
        {
            ManagePropsMenuOptions = new Dictionary<int, Action>
            {
                { 1, AddToCollection },
                { 2, View },
                { 3, Search },

                { 4, Delete },
                { 5, Back }
            };
        }
    }

    public class ManagePropertiesMethods
    {
        // Add
        public static void AddToCollection()
        {
            try
            {
                Console.Write("Property Name: ");
                string name = Console.ReadLine();

                Console.Write("Property Type (Residential or Commercial): ");
                string type = Console.ReadLine();

                Console.Write("Features: ");
                string features = Console.ReadLine();

                Console.Write("Location: ");
                string location = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out price)) ;

                Property newProperty = new Property(name, type, features, location, price);

                if (type.Equals("Residential", StringComparison.OrdinalIgnoreCase))

                {
                    PropertyManager.ResidentialProperties.Add(PropertyManager.residentialCounter++, newProperty);

                }
                else if (type.Equals("Commercial", StringComparison.OrdinalIgnoreCase))
                {
                    PropertyManager.CommercialProperties.Add(PropertyManager.commercialCounter++, newProperty);
                }
                else
                {
                    Console.WriteLine("Invalid property type!");
                    return;
                }


                Console.Clear();
                Console.WriteLine("Property has been successfully addded!\n");
                Console.WriteLine("Please press any key to return to main menu...");
                Console.ReadKey();
                NavigationUtils.BackToMain();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ReadKey();
            }
        }

        // View
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
                    foreach (var property in PropertyManager.ResidentialProperties)
                    {

                        Console.WriteLine("----------------------------------\n");
                        Console.WriteLine($"{property.Value}");

                        Console.WriteLine("----------------------------------");

                    };
                    Console.WriteLine("Press any button to return to main... ");
                    Console.ReadKey();

                    NavigationUtils.BackToMain();
                    break;
                case 2:

                    Console.Clear();
                    foreach (var property in PropertyManager.CommercialProperties)
                    {
                        Console.WriteLine("----------------------------------\n");
                        Console.WriteLine($"{property.Value}");

                        Console.WriteLine("----------------------------------");
                    };
                    Console.WriteLine("Press any button to return to main...");
                    Console.ReadKey();

                    NavigationUtils.BackToMain();
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again!");
                    break;
            }

        }
        // Search Method
        public void Search()
        {
            Console.Clear();
            Console.WriteLine("Residential or Commercial?");
            string type = Console.ReadLine();

            Console.Write("Type the full name of the property (This Program is case sensitive): ");
            string name = Console.ReadLine();

            if (type.Equals("Residential"))
            {
                Console.Clear();

                foreach (var i in PropertyManager.ResidentialProperties)
                {

                    if (name.Equals(i.Value.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Property could not be found, sorry!");
                        Thread.Sleep(1000);

                        NavigationUtils.BackToMain();
                    }
                }

                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Press any button to return to main menu..");
                Console.ReadKey();

                NavigationUtils.BackToMain();

            }
            else if (type.Equals("Commercial"))
            {

                Console.Clear();

                foreach (var i in property.CommercialProperties)
                {

                    if (name.Equals(i.Value.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i.Value}");

                    }
                    else
                    {
                        Console.WriteLine("Property could not be found, sorry!");
                        Thread.Sleep(1000);

                        NavigationUtils.BackToMain();
                    }
                }

                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Press any button to return to main menu..");
                Console.ReadKey();

                NavigationUtils.BackToMain();
            }
            else
            {
                Console.WriteLine("Invalid option! Please try again.");
                return;

            }

        }



        // Edit Method
        public void Edit()
        {
            Console.WriteLine();
        }

        // Delete Method
        public void Delete()
        {
            Console.WriteLine();

        }

        // Back to main menu
        public void Back()
        {
            NavigationUtils.BackToMain();
        }

        public void ResidentialPropertyReport()
        {
            Console.Clear();
            Console.WriteLine("Residential Property Report\n");
            foreach( var property in PropertyManager.ResidentialProperties)
            {
                Console.WriteLine(property.Value);
            }
        }

        public void CommercialPropertyReport()
        {
            Console.Clear();
            Console.WriteLine("Commercial Property Report\n");
            foreach(var property in PropertyManager.CommercialProperties)
            {
                Console.WriteLine(property.Value);
            }
        }
    }
}
        
       

    

