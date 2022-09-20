using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1_Refactoring
{
    internal class Introduction
    {
        readonly StringBuilder introduction;
        public Introduction()
        {
            introduction = new StringBuilder();
            introduction.AppendLine("-------------------------INTRODUCTION-------------------------");
            introduction.AppendLine("My name is Devesh, I am a Level 2 Computer Science student, currently enrolled in the JEDI training program at Ceridian");

            Console.WriteLine(introduction);
        }

    }
}
