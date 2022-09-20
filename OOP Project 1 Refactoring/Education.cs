using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Education : MainMenuOption
    {

        private StringBuilder menuContent;

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

            SortedList<int, Func<MainMenuOption>> selectedOptions = new SortedList<int, Func<MainMenuOption>>();

            selectedOptions.Add(0, () => { return new MainMenu().Display(); });
            selectedOptions.Add(1, () => { return new CS_Year_1().Display(); });
            selectedOptions.Add(2, () => { return new CS_Year_2().Display(); });

            Console.WriteLine(menuContent);

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                while (!Enum.IsDefined(typeof(ChoiceEducation), num))
                {
                    Education education = new Education();
                    return education.Display();
                }

                return selectedOptions[num]();

            }
            catch (System.FormatException)
            {
                new Education().Display();
            }

            return this;

        }

    }
}
