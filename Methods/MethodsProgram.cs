using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class MethodsProgram
    {
       
        // A Method that prints the options to us
        public void InitializeMenu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("     Real Estate Management      ");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("1. Manage Properties");
            Console.WriteLine("2. Manage Clients");
            Console.WriteLine("3. Record Transactions");
            Console.WriteLine("4. View Reports");
            Console.WriteLine("5. Exit");
            
        }

        // Methods for the main menu
        // Managing Properties 
        public void ManageProperties()
        {
            Console.WriteLine("Managing Properties");

        }

        // Managing Clients
        public void ManageClients()
        {
            Console.WriteLine("Managing Properties");

        }
        
        // Record Transaction
        public void RecordTransaction()
        {
            Console.WriteLine("Record Transaction");
        }

        // Viewing Reports 
        public void VeiwReports()
        {
            Console.WriteLine("Viewing reports");
        }

        // Exit
        public void Exit()
        {
            Console.WriteLine("Exiting program");
        }
    }

}
