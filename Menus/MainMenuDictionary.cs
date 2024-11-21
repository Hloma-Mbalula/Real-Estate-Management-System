using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class MainMenu
    {
        MethodsProgram method = new MethodsProgram();
        // Dictionary for the  main menu
        public Dictionary<int, Action> MainMenuOptions { get; private set; }
        // Constructor to Initialize the menu
        public MainMenu() {
            MainMenuOptions = new Dictionary<int, Action>
            {
                {1, method.ManageProperties },
                {2, method.ManageClients },
                {3, method.RecordTransaction },
                {4, method.VeiwReports },
                {5, method.Exit }
            };
        }

    }
}
