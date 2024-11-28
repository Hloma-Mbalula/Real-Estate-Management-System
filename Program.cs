﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;

namespace MainProgram
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            var method = new MainMenu();

            Console.WriteLine("Welcome to Proton Estates");
            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("     Real Estate Management      ");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("1. Manage Properties");
            Console.WriteLine("2. Manage Clients");
            Console.WriteLine("3. Record Transactions");
            Console.WriteLine("4. View Reports");
            Console.WriteLine("5. Exit\n");
            Console.WriteLine("---------------------------------\n");

            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if (method.MainMenuOptions.TryGetValue(option, out Action action))
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

        // Back to main Menu Method
        static void BackToMain()
        {

        }
    }
}
