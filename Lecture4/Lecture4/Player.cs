using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Player
    {
        string p1Name;
        int currentHealth;
        int maxHealth;
        int armorType; //0 for none, 1 for light, 2 for medium, 3 for heavy
        int missingBodyParts; //0 = no damage reduction, 1 = 20% damage reduction, 2 = 50% damage reduction, 3 = 80% damage reduction, 4 = you can't move
        int currentWeapon; //0 = none, 1 = Knight's Blade, 2 = Fencing Foil, 3 = Claymore, 4 = Falchion
        int weaponDurability;
        bool playerAlive;

        public Player() //default constructor with default values.
        {
            p1Name = "Anyone except Miguel"; //That name is banned
            currentHealth = 1000; //feeling pretty healthy
            maxHealth = 1000;
            armorType = 0;
            missingBodyParts = 0;
            currentWeapon = 0;
            weaponDurability = 0; //no weapon, no durability
            playerAlive = true;
        }

        public Player(string playerName, int cHealth, int mHealth, int aType, int wType, int mBodyParts, int durability, bool notDead)
        {
            if (playerName != "Miguel" && playerName != "miguel" )
            {
                p1Name = playerName;
            }
            else
            {
                p1Name = "still not Miguel"; //still banned
            }

            currentHealth = cHealth;
            maxHealth = mHealth;
            armorType = aType;
            missingBodyParts = mBodyParts;
            currentWeapon = wType;
            weaponDurability = durability;
            playerAlive = notDead;
        }
    }
}
