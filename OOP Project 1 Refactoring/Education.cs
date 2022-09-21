using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Education : MainMenuOption
    {

        private readonly StringBuilder menuContent;

        public Education()
        {
            menuContent = new StringBuilder("-------------------------EDUCATION-------------------------\n");
            menuContent.AppendLine("1. Computer Science (Year 1)");
            menuContent.AppendLine("2. Computer Science (Year 2)");
            menuContent.AppendLine("0. Go Back\n");
            menuContent.AppendLine("Please select an option for Experience details or 0 to go back to Main Menu");
        }

        public MainMenuOption Display()
        {

            SortedList<ChoiceEducation, Func<MainMenuOption>> selectedOptions = new SortedList<ChoiceEducation, Func<MainMenuOption>>();

            // each selected values will call the corresponding object's "Display" function
            selectedOptions.Add(ChoiceEducation.goBack, () => { return new MainMenu().Display(); });
            selectedOptions.Add(ChoiceEducation.ComputerScience1, () => { return new CS_Year_1().Display(); });
            selectedOptions.Add(ChoiceEducation.ComputerScience2, () => { return new CS_Year_2().Display(); });

            Console.WriteLine(menuContent);

            try
            {
                Education education;
                int num = Convert.ToInt32(Console.ReadLine());

                // verifying if the value entered is found in the Main Menu Enum
                // if not, it will keep displying back the Main Menu options
                while (!Enum.IsDefined(typeof(ChoiceEducation), num))
                {
                    education = new Education();
                    return education.Display();
                }

                // returns the delegate with the corresponding "Display" method signature
                return selectedOptions[(ChoiceEducation)num]();

            }
            catch (System.FormatException)
            {
                // if any characters other than numerical values are entered,
                // the Main Menu will be displayed back
                new Education().Display();
            }

            return this;

        }

    }
}
