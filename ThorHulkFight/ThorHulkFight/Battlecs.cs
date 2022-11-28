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

            double warriorBAttackAmt = warriorB.Attack();
            double warriorABlockAmt = warriorA.Block();

            double dmg2WarriorA = warriorBAttackAmt - warriorABlockAmt;


        }
    }
}
