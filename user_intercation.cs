using System;

namespace part_one
{
    internal class user_intercation
    {
        //global variable
        private string username = string.Empty;


        //void method to welcome the user

        public void welcome()
        {//start of method

            //message to welcome with text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    [Welcome to Cyber Security Awareness ChatBot]         ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------");
            //reset the color
            Console.ResetColor();



        }//end of method

        //method to ask the user name

        public void ask_user()
        {//start of the method

            //AI message and name with text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("bot: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name.. ");

            //reset the color
            Console.ResetColor();

            //do while to re-prompt the user for the username

            do
            {//start of dowhile

                //prompt the text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("USER: "+username);

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();

            } while (!empty());//ends of do while


        }//end of the method ask_user
        //Boolean method to check the username if not empty
        private Boolean empty()
        {//star of method
            //check idf not empty by if statement
            if (username != "")
            {//start of if
                //success message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Bot: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey " + username);
                //return true
                return true;

            }//end of if
            else
            { //start of else
                //error message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Bot : ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter name....");
                //returnfalse

                return false;

            }//end of else



        }
    }
}