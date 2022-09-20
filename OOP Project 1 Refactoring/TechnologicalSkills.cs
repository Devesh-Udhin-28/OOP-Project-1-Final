using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class TechnologicalSkills : MainMenuOption
    {

        private StringBuilder content;

        public TechnologicalSkills()
        {
            content = new StringBuilder("-------------------------TECHNOLOGICAL SKILLS-------------------------\n");
            content.AppendLine("->Database Management");
            content.AppendLine("->Computer Literacy skills (Excel, Word)");
            content.AppendLine("->Website Development skills");
            content.AppendLine("->Digital Marketing skills\n");
        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            return new MainMenu().Display();

        }

    }
}
