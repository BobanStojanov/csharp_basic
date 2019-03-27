using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Classes;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Methods
{
    public static class Login
    {
        public static Users LoginMethod(List<Users> userList)
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();

            foreach(var user in userList)
            {
                if(userName == user.UserName)
                {
                    if(pass == user.Password)
                    {
                        Console.WriteLine("Welcome " + user.Role + user.FirstName + " " + user.LastName + ". Please choose your next step:");
                        //if(user.Role == Enums.Roles.Admin)
                        //{
                        //    LandingMethod(List<Users> userList)
                        //}
                        return user;
                    }
                }
            }
        }
        
    }
}
