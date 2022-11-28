using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThorHulkFight
{
    internal class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double BlockMax { get; set; }

        Random rnd = new Random();

        public Warrior(string name = "Warrior", 
            double health = 0, 
            double attackMax = 0, 
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public virtual double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
