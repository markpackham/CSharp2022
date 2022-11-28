using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThorHulkFight
{
    internal class Battle
    {

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttackAmt = warriorA.Attack();
            double warriorBBlockAmt = warriorB.Block();

            double dmg2WarriorB = warriorAAttackAmt - warriorBBlockAmt;

            if (dmg2WarriorB> 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarriorB;
            }
            else
            {
                dmg2WarriorB = 0;
            }

            Console.WriteLine($"{warriorA.Name} Attacks {warriorB.Name} and Deals {dmg2WarriorB} Damge");
            Console.WriteLine($"{warriorB.Name} Has {warriorB.Health} Health\n");

            if(warriorB.Health < 1)
            {
                Console.WriteLine($"{warriorB.Name} died {warriorA.Name} won\n");

                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }


        }
    }
}
