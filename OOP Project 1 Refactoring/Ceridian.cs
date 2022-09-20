using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Ceridian : MainMenuOption
    {

        private StringBuilder content;

        public Ceridian()
        {
            content = new StringBuilder("-------------------------CERIDIAN-------------------------\n");
            content.AppendLine("Taking part in the JEDI/SKILLSLAB training\n");

        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            return new Experience().Display();

        }

    }
}
