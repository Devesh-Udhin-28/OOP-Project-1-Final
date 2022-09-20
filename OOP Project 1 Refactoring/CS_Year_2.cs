using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class CS_Year_2 : MainMenuOption
    {

        private readonly StringBuilder content;

        public CS_Year_2()
        {
            content = new StringBuilder();
            content.AppendLine("-------------------------Modules Taken-------------------------");
            content.AppendLine("1. Operating Systems");
            content.AppendLine("2. User Interface and Graphic Design");
            content.AppendLine("3. Algorithm and Complexities");
            content.AppendLine("4. Object Oriented Techniques");
            content.AppendLine("5. Software Engineering and Program Management");
            content.AppendLine("6. Web and Technologies\n");
            content.AppendLine("-------------------------Projects Done-------------------------");
            content.AppendLine("1. Fully Functional FrontEnd & BackEnd Website using PHP, JavaScript, CSS, Laravel");
            content.AppendLine("2. Toddler's Application for drawing using JAVA SWING");
            content.AppendLine("3. Attendence Application using JAVA SWING\n");
        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            // when all modules & projects are already displayed, the user will get back to the education Menu
            return new Education().Display();

        }

    }
}
