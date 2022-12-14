using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Experience : MainMenuOption
    {

        private readonly StringBuilder menuContent;
        private SortedList<ChoiceExperience, Func<MainMenuOption>> selectedOptions;


        public Experience()
        {
            selectedOptions = new SortedList<ChoiceExperience, Func<MainMenuOption>>();

            // each selected values will call the corresponding object's "Display" function
            selectedOptions.Add(ChoiceExperience.goBack, () => { return new MainMenu().Display(); });
            selectedOptions.Add(ChoiceExperience.MutualAid, () => { return new MutalAid().Display(); });
            selectedOptions.Add(ChoiceExperience.Ceridian, () => { return new Ceridian().Display(); });

            menuContent = new StringBuilder("-------------------------EXPERIENCE-------------------------\n");
            menuContent.AppendLine("1. Mauritius Civil Services Mutual Aid Association (02 July 2020 to 25 September 2020)");
            menuContent.AppendLine("2. CERIDIAN Mauritius Limited (05 September 2022 to 11 November 2022)");
            menuContent.AppendLine("0. Go Back\n");
            menuContent.AppendLine("Please select an option for Experience details or 0 to go back to Main Menu");
        }

        public MainMenuOption Display()
        {

            Console.WriteLine(menuContent);

            try
            {
                Experience experience;
                int num = Convert.ToInt32(Console.ReadLine());

                // verifying if the value entered is found in the Main Menu Enum
                // if not, it will keep displying back the Main Menu options
                while (!Enum.IsDefined(typeof(ChoiceExperience), num))
                {
                    experience = new Experience();
                    return experience.Display();
                }

                // returns the delegate with the corresponding "Display" method signature
                return selectedOptions[(ChoiceExperience)num]();

            }
            catch (System.FormatException)
            {
                // if any characters other than numerical values are entered,
                // the Main Menu will be displayed back
                new Experience().Display();
            }

            return this;

        }

    }
}
