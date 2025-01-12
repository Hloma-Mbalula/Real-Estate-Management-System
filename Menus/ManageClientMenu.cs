using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Program;

namespace Program
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PropertyType { get; set; }


        public Client(string name, string surname, string propertyType)
        {

            Name = name;
            Surname = surname;
            PropertyType = propertyType;

        }

        public override string ToString()
        {
            return $"Client: {Name} {Surname}\n" +
                   $"Property Type: {PropertyType}";
        }
    }

    public class ClientRepository
    {
        public static Dictionary<int, Client> clientsList { get; set; }

        public ClientRepository()
        {
            clientsList = new Dictionary<int, Client>{
                {1, new Client("Hloma", "Mbalula", "Residential")},
                {2, new Client("Alutha", "Sejosing", "Commercial")},
                {3, new Client("Jensen", "Huang", "Commercial")}
            };              
        }
    }

    public class ClientsMenuDictionary
    {
        public static Dictionary<int, Action> ManageClient { get; set; }

        public ClientsMenuDictionary()
        {
            ManageClient = new Dictionary<int, Action>
            {
                { 1, ManageClientMenu.AddClient },
                { 2, ManageClientMenu.ViewClients },
                { 3, ManageClientMenu.SearchClients },
                { 4, ManageClientMenu.DeleteClients },
                { 5, NavigationUtils.BackToMain }
            };
        }
    }

    public class ManageClientMenu
    {
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
            Console.WriteLine("4. Delete Clients");
            Console.WriteLine("5. Back to Main Menu\n");
            Console.WriteLine("----------------------------------\n");

            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (ClientsMenuDictionary.ManageClient.TryGetValue(option, out Action action))
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


        // Adding Clients
        public void AddClient()
        {
            string name;
            string surname;
            string propertytype;
            int idCounter = ClientRepository.clientslist.Count;

            Console.Write("Enter clients' name: \n");
            name = Console.ReadLine();

            Console.Write("Enter clients' surname: \n");
            surname = Console.ReadLine();

            Console.Write("Enter clients' property type: \n");
            propertytype = Console.ReadLine();

            var client = new Client(name, surname, propertytype);
            ClientRepository.clientsList.Add(idCounter++, client);

            Console.Clear();
            Console.WriteLine("Client has been successfully added!");
            Console.WriteLine("Press any key to return to main menu...");
            Console.ReadKey();

            NavigationUtils.BackToMain();
        }


        // Viewing Clients
        public void ViewClients()
        {

            foreach (var item in ClientRepository.clientsList)
            {
                Console.WriteLine($"{item.Value.Name} {item.Value.Surname}: {item.Value.PropertyType}");
            }
        }

        // Searching Clients
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

                    bool clientFound = false;

                    foreach (var client in ClientRepository.clientsList)
                    {
                        if (client.Value.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(client.Value);
                            clientFound = true;
                            return;
                        }
                    }
                    break;
                case 2:
                    Console.Write("Enter clients surname: \n");
                    surname = Console.ReadLine();
                    bool clientFound = false;

                    foreach (var client in ClientRepository.clientsList)
                    {
                        if (client.Value.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(client.Value);
                            clientFound = true;
                            return;
                        }
                    }

                    break;
                case 3:
                    Console.Write("Enter clients' property type: \n");
                    propertyType = Console.ReadLine();
                    bool clientFound = false;

                    foreach (var client in ClientRepository.clientsList)
                    {
                        if (client.Value.PropertyType.Equals(propertyType, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(client.Value);
                            clientFound = true;
                            return;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
        
        // Deleting Clients
        public void DeleteClients()
        {
            Console.Clear();
            Console.Write("Please entner the name of the client you want to delete: ");

                string name = Console.ReadLine();
                bool clientFound = false;

                foreach(var client in ClientRepository.clientsList)
                {
                    if (client.Value.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();

                        Console.WriteLine(client.Value);
                        clientFound = true;

                        Console.WriteLine("To Confirm, is this the client you want to delete? (Y or N) \n ");
                        string option = Console.ReadLine();

                        if(option == "Y")
                        {
                            client.Value.Remove(); // Double check on how to remove a collection from a dictionary of collections
                            Console.WriteLine("Client has been successfully removed.");
                            Console.WriteLine("Press any key to return to main menu....");
                            Console.ReadKey();
                            NavigationUtils.BackToMain();
                        }
                        else if(option == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("Press any key to return to main menu..");
                            Console.ReadKey();
                            NavigationUtils.BackToMain();
                        }

                    }
                }
        }
            
    }
}
