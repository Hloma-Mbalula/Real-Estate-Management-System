using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Program
    {
        static void Main(string[] args)
        {
            var method = new MethodsProgram();
            
            while (true)
            {
                Console.WriteLine("Welcome to the Real Estate Management System\n");
                method.InitializeMenu();
                Console.Write("Select an option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                
                
            }
            

        }
    }
}
