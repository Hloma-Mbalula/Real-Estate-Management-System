using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program;

public class Property
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public double Price { get; set; }
    public string PropertyType { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Location: {Location}, Price: {Price:D}, Type: {PropertyType}";
    }
}
