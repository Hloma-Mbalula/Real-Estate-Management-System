using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace Program
{
    public class PropertyManager
    {
        public Dictionary<int, Property> ResidentialProperties { get; private set; }

        public Dictionary<int, Property> CommercialProperties { get; private set; }

        public PropertyManager()
        {
            ResidentialProperties = new Dictionary<int, Property>{
                { 1, new Property(
                    "Lake House", "Residential", "2 Bedroom, 2x Garage","Rosebank, Johannesburg", 12000000)
                    },
                { 2, new Property("Sunny Apartment", "Residential", "2 Bed, 2 Bath", "Downtown", 120000) },
                
            };
            CommercialProperties = new Dictionary<int, Property>{
                {1, new Property("The Bank","Commercial","12 Story Building","Rosebank, Johannesburg", 20000000)
                },
                {2, new Property("High Rise", "Commercial", "20 Story Building", "Sandton, Johannesburg", 30000000)}
            };

        }
    }
}
