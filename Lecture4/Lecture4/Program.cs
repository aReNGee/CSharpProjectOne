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
            string playerChoice; //Reads the players input
            int choiceNumber; //converted choice into a number
            bool legalNumber;

            Dialogue firstDialogue = new Dialogue();

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

            Console.WriteLine("Just kidding! This wouldn't be much of an adventure if you immediately died,");
            Console.WriteLine("would it?");
            Console.WriteLine("");
            Console.WriteLine("Come along now, {0}. You're going to need a weapon as well as a name.", PlayerAlias);
            Console.WriteLine("Let's get you suited up.");

            Console.Read(); //why do I need two of these? Ask the Teacher
            Console.Read();

            Console.WriteLine("Let's see what we have in the Armory...");
            Console.WriteLine("(To choose a option, enter the number of your choice.)");
            Console.WriteLine("1. Knight's Blade");
            Console.WriteLine("2. Fenching Foil");
            Console.WriteLine("3. Claymore");
            Console.WriteLine("4. Falchion");
            Console.WriteLine("5. Who are you, anyways?");
            Console.WriteLine("6. What is this place?");

            yeahthatsright = false; //player has not confirmed thier choice yet
            legalNumber = false; //player has not yet entered a legal number

            choiceNumber = 0;

            do
            {
                
                choiceNumber = firstDialogue.recursiveChoice(6);
                /* do
                {


                    playerChoice = Console.ReadLine(); //reads player imput //why doesn't my code stop here? whyyyyy
                    if (Int32.TryParse(playerChoice, out choiceNumber) && choiceNumber <= 6 && choiceNumber >= 1) //checks if the player input a number between 1 and 5
                    {
                        legalNumber = true; //lets the program contine
                    }
                    else
                    {
                        legalNumber = false; //rereads input
                        Console.WriteLine("I'm sorry, I didn't understand. Please re-enter your choice.");
                    }
                } while (legalNumber == false); */

                Console.WriteLine("Excellent! You have chosen option {0}, correct? (Type 'y' for yes)", choiceNumber);
                yesno = Console.ReadLine();
                if (yesno == "y")
                {
                    yeahthatsright = true;
                }
                else
                {
                    Console.WriteLine("Please re-enter your choice.");
                    Console.WriteLine("(To choose a option, enter the number of your choice.)");
                    Console.WriteLine("1. Knight's Blade");
                    Console.WriteLine("2. Fenching Foil");
                    Console.WriteLine("3. Claymore");
                    Console.WriteLine("4. Falchion");
                    Console.WriteLine("5. Who are you, anyways?");
                    Console.WriteLine("6. What is this place?");
                }
            } while (yeahthatsright == false);

            firstDialogue.whoareyou(PlayerAlias);
            Console.Read();

            

        }
    }
}
