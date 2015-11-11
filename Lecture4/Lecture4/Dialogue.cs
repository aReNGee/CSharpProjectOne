using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Dialogue
    {
        string dialogueChoice;
        int numChoice;
        bool numCheck;
        

        public void whoareyou(string playerName)
        {
            Console.WriteLine("Who am I? None of your business.");
            Console.WriteLine("Shouldn't you be more concerned with who you are, {0}?",playerName);
            Console.WriteLine("(To choose a option, enter the number of your choice.)");
            Console.WriteLine("1. You're right! Who the hell am I?");
            Console.WriteLine("2. That's all right. I already know who I am.");

            
        }

        public int recursiveChoice(int upperLimit)
        {
            numCheck = false;
            do
            {
                dialogueChoice = Console.ReadLine(); //reads player imput //why doesn't my code stop here? whyyyyy
                if (Int32.TryParse(dialogueChoice, out numChoice) && numChoice <= upperLimit && numChoice >= 1) //checks if the player input a number between 1 and upperlimit
                {
                    numCheck = true; //lets the program contine
                }
                else
                {
                    numCheck = false; //rereads input
                    Console.WriteLine("I'm sorry, I didn't understand. Please re-enter your choice.");
                }
            } while (numCheck == false);

            return numChoice;
        }
    }
}
