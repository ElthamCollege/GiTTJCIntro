using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiTTJCIntro
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string option = "";
            string questionMark = "??";
            Console.WriteLine("What would you like to do");

            Console.WriteLine("Rubbish task");
            Console.WriteLine("Really Rubbish");

            // {n} - allows you to add a variable or string to your string, this will "1" to the position indicatted by {0} and a Question mark to the position indicatted by {1}
            // You might need to correct the 2nd WriteLine statement
            Console.WriteLine("{0} - Run my Quiz {1}", "1", questionMark);
            Console.WriteLine("{0} - Run my Chat {1}  Bot ", "2", questionMark);
            option = Console.ReadLine();
            if (option == "1")
            {
                Quiz();
            }
            if (option == "2")
            {
                ChatBot();
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        // The subroutine should first ask the user thir name and then print out a greeting using their name
        // It should then ask ask the user 11 questions. If the user gets an answer correct they should gain 1 mark.
        // Your program should give the user a mark out of 11 and their mark as a % after they have answered all questions.
        // If the user gets a mark between 0 and 3 they should get the message '<users name> not too Good', If they gain 4 - 7 marks they should
        // get the message - '<Users name> Not Bad', 7 to 11 - 'Excellent <users name> !!!!!'
        static void Quiz()
        {


            // create a variable to store score - it will be a whole number.
            // create a variable to store % - this will need a decimal point.
            // create a variable to store the users name

            Console.WriteLine("Welcome to my Quiz");

            // Ask the user to input their name
            // Write Hello ..... usersname to the screen

            // Ask your questions here and update mark variable as appropriate




            // Print out the users score as a % and out of 11

            // Print out a message to the user

        }
        // Extension - Write a chat bot that has a conversation about how to use various features of C# with the user.
        // For example the chat bot might ask the user what part of c# they want help with, if the user responds with 
        // printing to the screen it might ask if they want to print out text, variables or text and variables. If they select text
        // it would explain how to use WriteLine to print out a message.
        static void ChatBot()
        {

            // \t adds a tab  \n adds a newline
            Console.WriteLine("\t Welcome to the c# learning ChatBot \n\n\n");
            Console.WriteLine("Here we go");
            /// This 
        }
    }
}

