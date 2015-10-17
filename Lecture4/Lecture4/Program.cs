using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerAlias = "default"; //myPlayerName
            string yesno; //myDecision
            bool yeahthatsright = false; //DoesThePlayerAgree
            string[] illegalNames = new string[3] { "Miguel", "miguel" , ""}; //names the player cannot use
            bool appropriateName; //is the name appropriate
            int counter; //counter variable

            Console.WriteLine("Welcome to the world of Swordbreaker! Swords don't last long here, I highly");
            Console.WriteLine("recommend you use axes instead.");
            Console.WriteLine("Names are a valuable commodity here. Please enter the alias you'd like to use."); //Prompts for player imput (PlayerName)

            while (yeahthatsright == false) //continues until the player likes their (appropriate) name
            {
                appropriateName = true;
                PlayerAlias = Console.ReadLine(); //gathers player imput

                for (counter = 0; counter < illegalNames.Length; counter++) //checks if the name is appropriate
                {
                    if (PlayerAlias == illegalNames[counter])
                    {
                        appropriateName = false;
                    }
                } 

                if (appropriateName == false) //filters out inapropriate names (like Miguel)
                {
                    Console.WriteLine("Excuse me? You should be ashamed of yourself!");
                    Console.WriteLine("You must choose an inoffensive alias!");
                }
                else //if the name is appropriate, double checks that the player likes their name
                {
                    Console.WriteLine("You have chosen the alias {0}, is that correct? (Type 'y' for yes)", PlayerAlias);
                    yesno = Console.ReadLine();
                    if (yesno == "y")
                    {
                        yeahthatsright = true;
                    }
                    else
                    {
                        Console.WriteLine("I completely understand why you'd like to reconsider that name.");
                        Console.WriteLine("Please enter the alias you'd like to use.");
                    }
                }
            }

            Console.WriteLine("Fantastic choice! You have a great future ahead of you, {0}.", PlayerAlias);
            Console.Read();
            Console.WriteLine("You immediately die."); //trolls the player

            Console.Read(); //why do I need two of these? Ask the Teacher
            Console.Read();

            Console.WriteLine("Just kidding! This wouldn't be much of an adventure if you immediately died, would it?");

            Console.Read(); //why do I need two of these? Ask the Teacher
            Console.Read(); 

        }
    }
}
