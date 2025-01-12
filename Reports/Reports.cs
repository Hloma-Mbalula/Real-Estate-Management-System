using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;
namespace Program
{
    public class Reports 
    { 
         // This method will allow for users to view Residential Property reports

         public void ResidentialPropertyReport(){

            Console.Clear();
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Residential Report       ");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine($"Total Number of Properties: {properties.ResidentialProperties.Count + properties.CommercialProperties.Count}\n");

            Console.WriteLine($"\tResidential: {properties.ResidentialProperties.Count}");
            

            Console.WriteLine("----------------------------------\n");

            foreach(var property in properties.ResidentialProperties){

                Console.WriteLine(property.Value.Name);
                Console.WriteLine(property.Value.Features);
                Console.WriteLine(property.Value.Location);
                Console.WriteLine(property.Value.Price);
                Console.WriteLine("------------------------------\n");
                
            }
            
            Console.WriteLine("Press any button to return to main menu...");
            Console.ReadLine();
            NavigationUtils.BackToMain();
         }

         // Commercial Properties
         public void CommercialPropertyReport(){

            Console.Clear();
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            Console.WriteLine($"Total Number of Properties: {properties.ResidentialProperties.Count + properties.CommercialProperties.Count}\n");

            Console.WriteLine($"\tCommercial: {properties.CommercialProperties.Count}\n");


            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Commercial Report        ");
            Console.WriteLine("----------------------------------\n");
            
            foreach( var property in properties.CommercialProperties){
                
                Console.WriteLine(property.Value.Name);
                Console.WriteLine(property.Value.Location);
                Console.WriteLine("---------------------------------\n");
            }
            Console.WriteLine("Press any button to return to main menu...");
            Console.ReadLine();
            NavigationUtils.BackToMain();

         }

         // CLIENTS REPORTS
         public void ClientsReport(){

            Console.WriteLine($"Total Number of clients: {clientList.clientsList.Count}\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("          Clients Report          ");
            Console.WriteLine("----------------------------------\n");


            foreach(var client in clientList.clientsList){

                Console.WriteLine(client.Value.Name);
                Console.WriteLine(client.Value.Surname);
                Console.WriteLine($"{client.Value.PropertyType}\n");

                Console.WriteLine("----------------------------------\n");



                Console.Write("Please press any key to return to main menu");
                Console.ReadLine();
                NavigationUtils.BackToMain();

            

            }
         }
        


    }


}
    
