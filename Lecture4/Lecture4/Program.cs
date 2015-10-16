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
            
            string PlayerAlias; //myPlayerName
            Console.WriteLine("Welcome to the world of Swordbreaker! Swords don't last long here, I highly");
            Console.WriteLine("recommend you use axes instead.");
            Console.WriteLine("Names are a valuable commodity here. Please enter the alias you'd like to use.");
            PlayerAlias = Console.ReadLine();
            Console.WriteLine("You have chosen the alias {0}, is that correct?", PlayerAlias);
            Console.Read();
        }
    }
}
