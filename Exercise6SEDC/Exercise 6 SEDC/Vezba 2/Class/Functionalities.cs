using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba_2.Class
{
    public class Functionalities
    {
        public static string Question()
        {
            Console.WriteLine("Ako sakate da se Logirate vnesete 'L', ako sakate da se registrirate vnesete 'R':");
            return Console.ReadLine();
        }
        public static void Checker(Users[] userArr)
        {
            if (Question() == "L")
            {
                Login(userArr);
            }
            else if(Question() == "R")
            {
                Register(userArr);
            }
            
        }
            
        
        public static void Login (Users[] users)
        {
            Console.WriteLine("Vnesete Username:");
            string usernameInput = Console.ReadLine();
            Console.WriteLine("Vnesete Password");
            string passwordInput = Console.ReadLine();
            foreach (var user in users)
            {
                if (usernameInput == user.Username)
                {
                    if(passwordInput == user.Password)
                    {
                        Console.WriteLine("Welcome " + user.Username + ". Here are your messages:");
                        foreach( var mess in user.Messages)
                        {
                            int i = 1;
                            Console.WriteLine(i + ". " + mess);
                            i++;
                        }
                    } else
                    {
                        Console.WriteLine("Nepostoecki Password!");
                    }
                } else
                {
                    Console.WriteLine("User so toj Username ne postoi!");
                }
            }
        }
        public static void Register (Users[] users)
        {
            Console.WriteLine("Ve molie vnesete Username:");
            string newUserName = Console.ReadLine();
            Console.WriteLine("Ve molime vnesete Password:");
            string newUserPassword = Console.ReadLine();
            int newId = users[users.Length - 1].Id + 1;

            foreach (var user in users)
            {
                if (newUserName == user.Username)
                {
                    Console.WriteLine("Takov User veke postoi!");
                } else
                {
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = new Users(newId, newUserName, newUserPassword, new string[] { });
                    foreach(var us in users)
                    {
                        Console.WriteLine(us.Id + ". " + us.Username);
                    }
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
