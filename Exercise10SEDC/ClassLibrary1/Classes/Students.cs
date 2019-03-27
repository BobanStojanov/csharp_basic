using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Students : Users
    {
        public Students(string firstName, string lastName, string userName, string password, Role role) : base(firstName, lastName, userName, password, role)
        {

        }
    }
}
