using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Methods;
using ClassLibrary1.Classes;
using ClassLibrary1.Enums;


namespace Exercise10SEDC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Admin> usersList = new List<Admin>() { };
                Login.user = Login.LoginMethod(new UserLists());
                if(user.Role == Role.Admin)
                {
                    Admin admin = (Admin)user;
                    admin.LandingMethod
                }
                else if(usersList.Role == Role.Student)
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
