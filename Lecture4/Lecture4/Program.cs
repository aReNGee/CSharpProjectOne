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
            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy("Miguel", 4, true, 2, 6000);
            firstEnemy.slimeAttack();

            string PlayerAlias; //myPlayerName
            string yesno; //myDecision
            Console.WriteLine("Welcome to the world of Swordbreaker! Swords don't last long here, I highly");
            Console.WriteLine("recommend you use axes instead.");
            Console.WriteLine("Names are a valuable commodity here. Please enter the alias you'd like to use.");
            PlayerAlias = Console.ReadLine();
            Console.WriteLine("You have chosen the alias {0}, is that correct?", PlayerAlias);
            yesno = Console.ReadLine();
            if (yesno == "y")
            {
                Console.WriteLine("Great! You have a great future ahead of you, {0}.", PlayerAlias);
            }
            else
            {
                Console.WriteLine("Guess what? I don't even care. Your name is {0} now, buddy.", PlayerAlias);
            }
            Console.Read();
        }
    }
}
