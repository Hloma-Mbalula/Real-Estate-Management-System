using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Program;

namespace Program
{
    
    public class ManageClientMenu
    {
        ClientsLists list = new ClientsLists();
        public Dictionary<int, Action> ManageClientOptions;

        public ManageClientMenu()
        {
            ManageClientOptions = new Dictionary<int, Action>
            {
                {1, AddClient },
                {2, ViewClients },
                {3, SearchClients },
                {4, EditClients },
                {5, DeleteClients },
                {6,  }
            };
        }
        // Managing Clients
        public void ManageClients()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Manage Clients           ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. View Clients");
            Console.WriteLine("3. Search Clients");
            Console.WriteLine("4. Edit Clients");
            Console.WriteLine("5. Delete Clients");
            Console.WriteLine("6. Back to Main Menu\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (ManageClientOptions.TryGetValue(option, out Action action))
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
                Console.WriteLine();
            }

        }
        public void AddClient()
        {
            string name;
            string surname;
            int id;
            string propertytype;

            Console.Write("Enter clients' Id: \n");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter clients' name: \n");
            name = Console.ReadLine();

            Console.Write("Enter clients' surname: \n");
            surname = Console.ReadLine();

            Console.Write("Enter clients' property type: \n");
            propertytype = Console.ReadLine();

            var client = new Client( name, surname, propertytype);
            

            list.clientsList.Add(id, client);
        }

        public void ViewClients()
        {
            var list = new ClientsLists();

            foreach (var item in list.clientsList)
            {
                Console.WriteLine(item);
            }
        }

        public void SearchClients()
        {
            string name;
            string surname;
            string propertyType;
            int Id;

            Console.WriteLine("Search by: ");
            Console.WriteLine("     1. Name");
            Console.WriteLine("     2. Surname");
            Console.WriteLine("     3. Property Type");
            Console.WriteLine("     4. Id\n");
            Console.Write("Select option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter clients name: \n");
                    name = Console.ReadLine();
                    for(int i = 0; i < list.clientsList.Count; i++)
                    {
                        if ( list.clientsList[i].Equals(name))
                        {
                            Console.WriteLine(list.clientsList[i]);
                        }
                        else
                        {
                            Console.WriteLine("Client unavailable, please try again.");
                        }
                    }
                    break;
                case 2:
                    Console.Write("Enter clients surname: \n");
                    surname = Console.ReadLine();
                    for (int i = 0; i < list.clientsList.Count; i++)
                    {
                        if (list.clientsList[i].Equals(surname))
                        {
                            Console.WriteLine(list.clientsList[i]);
                        }
                        else
                        {
                            Console.WriteLine("Client unavailable, please try again.");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Enter clients' property type: \n");
                    propertyType = Console.ReadLine();
                    for (int i = 0; i < list.clientsList.Count; i++)
                    {
                        if (list.clientsList[i].Equals(propertyType))
                        {
                            Console.WriteLine(list.clientsList[i]);
                        }
                        else
                        {
                            Console.WriteLine("Client unavailable, please try again.");
                        }
                    }
                    break;
                case 4:
                    Console.Write("Enter clients' Id");
                    Id = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < list.clientsList.Count; i++)
                    {
                        if (list.clientsList[i].Equals(Id))
                        {
                            Console.WriteLine(list.clientsList[i]);
                        }
                        else
                        {
                            Console.WriteLine("Client unavailable, please try again.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
                   

            }

        }

        public void EditClients()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("         List of Clients         ");
            Console.WriteLine("---------------------------------\n");
            foreach (var client in list.clientsList) 
            {
                Console.WriteLine(client);
            }
            Console.WriteLine("---------------------------------");
            Console.Write("Enter Clients Id to edit the client: \n");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < list.clientsList.Count; i++)
            {
                if (list.clientsList.Equals(option))
                {

                }

                

            }

        }

        public void DeleteClients() { }
    }
}
