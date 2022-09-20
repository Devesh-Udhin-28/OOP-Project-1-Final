using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Experience : MainMenuOption
    {

        private StringBuilder menuContent;
        
        public Experience()
        {
            menuContent = new StringBuilder("-------------------------EXPERIENCE-------------------------\n");
            menuContent.AppendLine("1. Mauritius Civil Services Mutual Aid Association (02 July 2020 to 25 September 2020)");
            menuContent.AppendLine("2. CERIDIAN Mauritius Limited (05 September 2022 to 11 November 2022)");
            menuContent.AppendLine("0. Go Back\n");
            menuContent.AppendLine("Please select an option for Experience details or 0 to go back to Main Menu");
        }

        public MainMenuOption Display()
        {

            SortedList<int, Func<MainMenuOption>> selectedOptions = new SortedList<int, Func<MainMenuOption>>();

            selectedOptions.Add(0, () => { return new MainMenu().Display(); });
            selectedOptions.Add(1, () => { return new MutalAid().Display(); });
            selectedOptions.Add(2, () => { return new Ceridian().Display(); });

            Console.WriteLine(menuContent);

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                while (!Enum.IsDefined(typeof(ChoiceExperience), num))
                {
                    Experience experience = new Experience();
                    return experience.Display();
                }

                return selectedOptions[num]();

            }
            catch (System.FormatException)
            {
                new Experience().Display();
            }

            return this;

        }

    }
}
