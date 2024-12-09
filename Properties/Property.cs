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

    public static void Add()
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

        new Property(name, type, features, location, price);



       
    }
}
