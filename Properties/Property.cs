using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program;

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
        return $"Name: {Name}, Property Type: {PropertyType}, Features: {Features}, Location: {Location}, Price: {Price:D}";
    }

    public static void AddToCollection()
    {
        PropertyManager propManager = new PropertyManager();
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
        int numResi = 3;
        int numComm = 3;
        Property newProperty = new Property(name, type, features, location, price);

        if (type.Equals("Residential", StringComparison.OrdinalIgnoreCase))
        {
            propManager.ResidentialProperties.Add(numResi++, newProperty);
        }else if(type.Equals("Commercial", StringComparison.OrdinalIgnoreCase))
        {
            propManager.CommercialProperties.Add(numComm++, newProperty);
        }
        else
        {
            Console.WriteLine("Invalid option!");
        }
        
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("Property has been successfully addded!\n");

        Console.WriteLine("Please press any key to return to main menu...");
        Console.ReadLine();
        NavigationUtils.BackToMain();


       
    }
}
