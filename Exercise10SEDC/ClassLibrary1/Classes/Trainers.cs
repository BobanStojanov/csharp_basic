using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Trainers : Users
    {
        public Trainers(string firstName, string lastName, string userName, string password, Role role) : base(firstName, lastName, userName, password, role)
        {

        }

        public static void chooseMethod()
        {
            Console.WriteLine("If you want to list all students choose 1, if you want to list all subjects of student choose 2 or if you want to list all Subjects, choose 3");
        }
    }
}
