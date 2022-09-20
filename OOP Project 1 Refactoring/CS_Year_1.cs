using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class CS_Year_1 : MainMenuOption
    {

        private readonly StringBuilder content;

        public CS_Year_1()
        {
            content = new StringBuilder();
            content.AppendLine("-------------------------Modules Taken-------------------------");
            content.AppendLine("1. Computer Programming");
            content.AppendLine("2. Databases");
            content.AppendLine("3. Computer Architecture");
            content.AppendLine("4. Communication Skills");
            content.AppendLine("5. Computational Mathematics");
            content.AppendLine("6. Computational and Formal Systems\n");
            content.AppendLine("-------------------------Projects Done-------------------------");
            content.AppendLine("1. Translation Program in C++");
            content.AppendLine("2. Database BackEnd for Cinema Ticketing system");
            content.AppendLine("3. Traffic lights system using Logisim\n");
        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            // when all modules & projects are already displayed, the user will get back to the education Menu
            return new Education().Display();

        }

    }
}
