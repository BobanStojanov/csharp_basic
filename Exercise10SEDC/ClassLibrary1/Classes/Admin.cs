using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Admin : Users
    {
        public Admin(string firstName, string lastName, string userName, string password, Role role) : base(firstName, lastName, userName, password, role)
        {
        }

        public static void LandingMethod(List<Users> userList)
        {
            Console.WriteLine("Choose 1 to ADD user or choose 2 to REMOVE user");
            string chosen = Console.ReadLine();
            try
            {
                if (chosen == "1")
                {
                    AddUser(userList);
                }
                else if (chosen == "2")
                {
                    RemoveUser(userList);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
           

        }
        public static void AddUser(List<Users> userList)
        {
            Console.WriteLine("Enter Firstname:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Lastname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Role:");
            string roleStr = Console.ReadLine();
            Role role;
            if (roleStr == "1" || roleStr == "admin")
            {
                role = Role.Admin;
            }
            else if (roleStr == "2" || roleStr == "trainer")
            {
                role = Role.Trainer;
            }
            else if (roleStr == "3" || roleStr == "student")
            {
                role = Role.Student;
            }
            else
            {
                throw new Exception("Unexisting Role");
               
                
            }
            
            

            foreach(var user in userList)
            {
                if (userName != user.UserName)
                {
                    Console.WriteLine("That user alredy exists");
                    Console.ReadLine();
                    break;
                    
                } else
                {
                    userList.Add(new Users(firstName, lastName, userName, password, role));
                }
            }

           
        }
        public static void RemoveUser(List<Users> userList)
        {
            Console.WriteLine("Enter Username of User that needs to be removed:");
            string userRemove = Console.ReadLine();
            
            foreach( var user in userList)
            {
                if(userRemove == user.UserName)
                {
                    userList.Remove(user);
                } else
                {
                    Console.WriteLine("That User does not exist.");
                    Console.ReadLine();
                }
            }

        }
    }
}
