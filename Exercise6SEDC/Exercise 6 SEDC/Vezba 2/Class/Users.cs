using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba_2.Class
{
    public class Users
    {

       
            public Users(int Id, string Username, string Password, string[] Messages)
            {
                this.Id = Id;
                this.Username = Username;
                this.Password = Password;
                this.Messages = Messages;
            }

            public int Id;
            public string Username;
            public string Password;
            public string[] Messages;
            

        
    }
}
