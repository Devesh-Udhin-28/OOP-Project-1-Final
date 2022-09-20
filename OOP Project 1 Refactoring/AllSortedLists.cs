using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class AllSortedLists
    {

        public SortedList<int, Func<MainMenuOption>> MainMenuSelectedOptions;

        public SortedList<int, Func<MainMenuOption>> ExperienceSelectedOptions;

        public SortedList<int, Func<MainMenuOption>> EducationSelectedOptions;

        public AllSortedLists()
        {

            MainMenuSelectedOptions = new SortedList<int, Func<MainMenuOption>>();
            ExperienceSelectedOptions = new SortedList<int, Func<MainMenuOption>>();
            EducationSelectedOptions = new SortedList<int, Func<MainMenuOption>>();

            MainMenuSelectedOptions.Add(1, () => { return new Experience().Display(); });
            MainMenuSelectedOptions.Add(2, () => { return new Education().Display(); });
            MainMenuSelectedOptions.Add(3, () => { return new Skills().Display(); });
            MainMenuSelectedOptions.Add(4, () => { return new TechnologicalSkills().Display(); });
            MainMenuSelectedOptions.Add(5, () => { return new ContactDetails().Display(); });

            ExperienceSelectedOptions.Add(0, () => { return new MainMenu().Display(); });
            ExperienceSelectedOptions.Add(1, () => { return new MutalAid().Display(); });
            ExperienceSelectedOptions.Add(2, () => { return new Ceridian().Display(); });

            EducationSelectedOptions.Add(0, () => { return new MainMenu().Display(); });
            EducationSelectedOptions.Add(1, () => { return new CS_Year_1().Display(); });
            EducationSelectedOptions.Add(2, () => { return new CS_Year_2().Display(); });

        }

    }
}
