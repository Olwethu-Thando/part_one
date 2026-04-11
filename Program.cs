using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_one
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating method for greeting_and_user_intercation 
            user_intercation greeting = new user_intercation(){};

            // creating audio method
            audio voice = new audio() {};

            // creating logo method 
             logo  image =new logo() {};

            //creating chat method 
            //chats  chat = new chats() {};

            // calling welcome method
            greeting.welcome();

            // calling ther ask_name method 
            greeting.ask_user();

            //calling chat method 


            



             

        }
    }
}
