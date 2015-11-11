using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    class Enemy
    {
        int health;
        string name;
        bool isRunning;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Enemy() //
        {
            health = 100;
            name = "Kwame";
            isRunning = true;
        }
        public Enemy(int eHealth, string eName, bool eIsRunning)
        {
            health = eHealth;
            name = eName;
            isRunning = eIsRunning;
        }
    }
}
