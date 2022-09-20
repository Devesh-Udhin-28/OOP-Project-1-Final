using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class MainMenu : MainMenuOption
    {

        private StringBuilder menuContent;

        public MainMenu()
        {

            menuContent = new StringBuilder("-------------------------MAIN MENU-------------------------\n");
            menuContent.AppendLine("1. Experience / Job History");
            menuContent.AppendLine("2. Training / Education");
            menuContent.AppendLine("3. Skills");
            menuContent.AppendLine("4. Technological Skills");
            menuContent.AppendLine("5. Contact Details");
            menuContent.AppendLine("0. Exit\n");
            menuContent.AppendLine("Select one of the above to see in more details");

        }

        public MainMenuOption Display()
        {
            SortedList<int, Func<MainMenuOption>> selectedOptions = new SortedList<int, Func<MainMenuOption>>();

            selectedOptions.Add(1, () => { return new Experience().Display(); });
            selectedOptions.Add(2, () => { return new Education().Display(); });
            selectedOptions.Add(3, () => { return new Skills().Display(); });
            selectedOptions.Add(4, () => { return new TechnologicalSkills().Display(); });
            selectedOptions.Add(5, () => { return new ContactDetails().Display(); });

            Console.WriteLine(menuContent);

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                while (!Enum.IsDefined(typeof(MainMenuChoices), num))
                {
                    MainMenu mainMenu = new MainMenu();
                    return mainMenu.Display();
                }

                //here is just one if statement that will provide the user the option to exit the code from the 
                //terminal itself
                if(num == 0)
                    Environment.Exit(0);

                return selectedOptions[num]();

            }
            catch (System.FormatException)
            {
                new MainMenu().Display();
            }

            return this;

        }

    }
}
