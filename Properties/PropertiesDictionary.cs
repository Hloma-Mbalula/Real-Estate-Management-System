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
            ResidentialProperties = new Dictionary<int, Property>();
            CommercialProperties = new Dictionary<int, Property>();

        }
    }
}
