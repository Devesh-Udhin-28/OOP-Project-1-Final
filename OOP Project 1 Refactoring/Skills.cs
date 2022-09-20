using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Skills : MainMenuOption
    {

        private readonly StringBuilder content;

        public Skills()
        {
            content = new StringBuilder("-------------------------SKILLS-------------------------\n");
            content.AppendLine("->Fluent in Java, SQL, C++, HTML, PHP, JavaScript, CSS, C");
            content.AppendLine("->Confident in Presentations\n");
        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            // when all skills are already displayed, the user will get back to the Main Menu
            return new MainMenu().Display();

        }

    }
}
