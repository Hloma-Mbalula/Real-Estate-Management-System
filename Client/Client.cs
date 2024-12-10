using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;


namespace Program
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; private set; }
        public string PropertyType { get; set; }

        public Client(string name, string surname, string propertyType)
        {
            
            Name = name;
            Surname = surname;
            PropertyType = propertyType;

        }
    }

    public class ClientsLists
    {
        public Dictionary<int, Client> clientsList { get; set; }

        public ClientsLists()
        {
            clientsList = new Dictionary<int, Client>{
                {1, new Client("Hloma", "Mbalula", "Residential")},
                {2, new Client("Alutha", "Sejosing", "Commercial")},
                {3, new Client("Jensen", "Huang", "Commercial")}
            };
        }
    }
}
