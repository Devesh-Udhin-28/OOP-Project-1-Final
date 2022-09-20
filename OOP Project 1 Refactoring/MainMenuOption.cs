using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal interface MainMenuOption
    {
        // All classes will have to implement this interface so that whenever a method is executed,
        // it will return the next state/option for the selected objects of the Main Menu
        MainMenuOption Display();

    }
}
