using System;

namespace Lecture4
{
    public class Enemy
    {
        //type // name // value
        string name;
        int weaponCount;
        bool isAlive;
        int currentState;
        int bodyParts;
        // getter and setter //accessor and mutator
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        

        public Enemy()
        {
            name = "Slime";
            weaponCount = 5;
            isAlive = true;
            currentState = 2;
            bodyParts = 4000;
        }

        public Enemy(string enemyName, int weapon, bool alive, int state, int soManyBodyParts)
        {
            name = enemyName;
            weaponCount = weapon;
            isAlive = alive;
            currentState = state;
            bodyParts = soManyBodyParts;
        }

        public void slimeAttack() //enemyAttack
        {
            Console.WriteLine("THE SLIME DRAWS NEAR! DEFEND YOURSELF!");
        }
    }
}
