using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThorHulkFight
{
    internal class Battlecs
    {

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {

        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttackAmt = warriorA.Attack();
            double warriorBBlockAmt = warriorB.Block();

            double dmg2WarriorB = warriorAAttackAmt - warriorBBlockAmt;

            if(dmg2WarriorB> 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarriorB;
            }
            else
            {
                dmg2WarriorB = 0;
            }

            Console.WriteLine($"{warriorA.Name} Attacks {warriorB.Name} and Deals {dmg2WarriorB} Damge");
            Console.WriteLine($"{warriorB.Name} Has {warriorB.Health} Health\n");

            double warriorBAttackAmt = warriorB.Attack();
            double warriorABlockAmt = warriorA.Block();

            double dmg2WarriorA = warriorBAttackAmt - warriorABlockAmt;

            if (dmg2WarriorA > 0)
            {
                warriorA.Health = warriorA.Health - dmg2WarriorA;
            }
            else
            {
                dmg2WarriorA = 0;
            }

            Console.WriteLine($"{warriorB.Name} Attacks {warriorA.Name} and Deals {dmg2WarriorA} Damge");
            Console.WriteLine($"{warriorA.Name} Has {warriorA.Health} Health\n");

        }
    }
}
