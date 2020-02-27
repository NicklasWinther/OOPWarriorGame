using OOPWarriorGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWarriorGame.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Warrior> warriors = new List<Warrior>();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Enter player {i}'s name");
                //                       Name                HP   Att. Blk.
                warriors.Add(new Warrior(Console.ReadLine(), 200, 120, 40));
                Console.Clear();
            }

            foreach (Warrior warrior in warriors)
            {
                switch (warrior.Name.ToLower())
                {
                    case "dima":
                        warrior.Attack = 9999;
                        break;
                    case "nickolai":
                        warrior.Attack = 50;
                        break;
                    case "morten":
                        warrior.Block = 5;
                        break;
                    default:
                        break;
                }
            }

            Battle.StartFight(warriors[0], warriors[1]);
            Console.ReadLine();

        }
    }
}
