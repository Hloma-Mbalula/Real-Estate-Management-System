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
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int ID { get; private set; }
        public string PropertyType { get; private set; }

        public Client(string name, string surname, string propertyType)
        {
            
            Name = name;
            Surname = surname;
            PropertyType = propertyType;

        }
    }

    public class ClientsLists
    {
        public Dictionary<int, Client> clientsList { get; private set; }

        public ClientsLists()
        {
            clientsList = new Dictionary<int, Client>();
        }
    }
}
