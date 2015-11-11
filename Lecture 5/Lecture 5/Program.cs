using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable for stopping the while loop
            string stopvalue = "A";
            Enemy myEnemy = new Enemy();
            Enemy myEnemy2 = new Enemy(5,"Bob",false);
            int playerHealth = 100;
            //
            int timeStep = 60;
            int someCrazyTimeStep = 1000;
            // construct the while loop
            while(stopvalue != "B") 
            {
                //grab the time step
                //if the returened timeStep is greater than our locked timestep set it back
                if (someCrazyTimeStep > timeStep)
                {
                    someCrazyTimeStep = timeStep;
                }
                //
                Console.WriteLine("MAKE YOU CHOICE:");
                Console.WriteLine("ENTER A, AND YOUR FAMILY WILL DIE, BUT YOU WILL SURVIVE");
                Console.WriteLine("ENTER B AND BE INSTANTLY DESTROYED (BUT I WILL SPARE YOUR FAMILY)");
                stopvalue = Console.ReadLine();
                addDamageToPlayer(ref playerHealth);
            }
        }

        //pass by value and path by ref
        public static void addDamageToPlayer(ref int health)
        {
            health--;
            Console.WriteLine("{0}", health);
        }

        public static string returnEnemyName(string name)
        {
            return name;
        }

        public static Enemy returnANewEnemy(Enemy enemy)
        {
            return enemy;
        }
    }
}
