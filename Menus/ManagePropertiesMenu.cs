using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class ManagePropertiesMenu
    {
        MethodsProgram method = new MethodsProgram();
        public Dictionary<int, Action> ManagePropsMenuOptions { get; private set; }

        public ManagePropertiesMenu()
        {
            ManagePropsMenuOptions = new Dictionary<int, Action>
            {
                { 1, method.Add },
                { 2, method.View },
                { 3, method.Search },
                { 4, method.Edit },
                { 5, method.Delete },
                { 6, method.Back }
            };
        }
    }
}
