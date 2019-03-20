using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_7_SEDC.Enums;

namespace Exercise_7_SEDC.Class
{
    public class Programmer : Human
    {
        public Title Title { get; set; }
        public string Language { get; set; }
        public int YearsOfExperiance { get; set; }
       


        public Programmer(Title Title, string Language, int exp, string Name, int Age) : base(Name, Age)
        {
            Title = Title;
            Language = Language;
            YearsOfExperiance = exp;
            Name = Name;
            Age = Age;
        }

        public override string PrintInfo()
        {
            return $"{base.PrintInfo()} and im {Title.Junior} {Language} programmer" +
                $" with {YearsOfExperiance} year of experience. ";
        }
    }
}
