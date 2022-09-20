using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class ContactDetails : MainMenuOption
    {

        private StringBuilder content;

        public ContactDetails()
        {
            content = new StringBuilder("-------------------------CONTACT DETAILS-------------------------\n");
            content.AppendLine("-Phone Number : +230 58343689");
            content.AppendLine("-Company Email : devesh.udhin@ceridian.com");
            content.AppendLine("-Personal Email : udhindevesh@gmail.com\n");

        }

        public MainMenuOption Display()
        {

            Console.WriteLine(content);
            return new MainMenu().Display();

        }

    }
}
