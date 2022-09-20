using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class MainMenu : MainMenuOption
    {

        private readonly StringBuilder menuContent;

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

            // each selected values will call the corresponding object's "Display" function
            selectedOptions.Add(1, () => { return new Experience().Display(); });
            selectedOptions.Add(2, () => { return new Education().Display(); });
            selectedOptions.Add(3, () => { return new Skills().Display(); });
            selectedOptions.Add(4, () => { return new TechnologicalSkills().Display(); });
            selectedOptions.Add(5, () => { return new ContactDetails().Display(); });

            Console.WriteLine(menuContent);

            try
            {
                MainMenu mainMenu;
                int num = Convert.ToInt32(Console.ReadLine());

                // verifying if the value entered is found in the Main Menu Enum
                // if not, it will keep displying back the Main Menu options
                while (!Enum.IsDefined(typeof(MainMenuChoices), num))
                {
                    mainMenu = new MainMenu();
                    return mainMenu.Display();
                }

                // here is just one if statement that will provide the user the option to exit the code from the 
                // terminal itself
                if(num == 0)
                    Environment.Exit(0);

                // returns the delegate with the corresponding "Display" method signature
                return selectedOptions[num]();

            }
            catch (System.FormatException)
            {
                // if any characters other than numerical values are entered,
                // the Main Menu will be displayed back
                new MainMenu().Display();
            }

            return this;

        }

    }
}
