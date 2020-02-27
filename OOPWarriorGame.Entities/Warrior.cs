using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWarriorGame.Entities
{
    public class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public int Attack { get; set; }
        public int Block { get; set; }
        public double MaxHealth { get; set; }
        public Warrior(string name, double health, int attack, int block)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Block = block;
            MaxHealth = health;
        }

    }
}
