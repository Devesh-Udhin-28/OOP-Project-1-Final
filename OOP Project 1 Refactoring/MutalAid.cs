using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class MutalAid : MainMenuOption
    {

        private readonly StringBuilder content;

        public MutalAid()
        {
            content = new StringBuilder("-------------------------MUTUALAID-------------------------\n");
            content.AppendLine("Loan Abeyance / Updating Customers details on FINACLE system\n");

        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            // when all experience details are already displayed, the user will get back to the experience Menu
            return new Experience().Display();

        }

    }
}
