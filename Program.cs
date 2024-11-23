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
            var menu = new MainMenu();
            var method = new MethodsProgram();
            Console.WriteLine("Welcome to the Real Estate Management System\n");
            while (true)
            {
                Console.Clear();
                method.InitializeMenu();
                Console.Write("Select an option: ");

                if(int.TryParse(Console.ReadLine(), out int option))
                {
                    if(menu.MainMenuOptions.TryGetValue(option, out Action action))
                    {
                        Console.Clear();
                        action.Invoke();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option, Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, Please enter a number.");
                }
                

                
                
            }
            

        }
    }
}
