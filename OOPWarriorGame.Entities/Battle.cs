using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWarriorGame.Entities
{
    public class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            List<Warrior> warriors = new List<Warrior>() { warrior1, warrior2 };
            while (warrior1.Health > 0 && warrior2.Health > 0)
            {
                Attack(warriors[0], warriors[1]);
                
                Console.WriteLine($"{warrior1.Name}: {warrior1.Health}/{warrior1.MaxHealth}\n" +
                                  $"{warrior2.Name}: {warrior2.Health}/{warrior2.MaxHealth}", Console.ForegroundColor = ConsoleColor.Gray);
                Console.WriteLine($"Press any key to continue...", Console.ForegroundColor = ConsoleColor.Gray);

                Console.ReadKey();
                Console.Clear();

                warriors.Reverse();
            }

            Console.WriteLine($"{warriors[0].Name} died", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void Attack(Warrior attacker, Warrior defender)
        {
            Random rnd = new Random();
            int attackDamage = rnd.Next(1, attacker.Attack + 1);
            int damageBlocked = rnd.Next(1, defender.Block + 1);
            int damageDealt = attackDamage - damageBlocked;
            Console.WriteLine($"{attacker.Name} deals {attackDamage}, and {defender.Name} blocked {damageBlocked}.");

            if (damageDealt > 0)
            {
                defender.Health -= damageDealt;
                Console.WriteLine($"{defender.Name} lost {damageDealt} health", Console.ForegroundColor = ConsoleColor.DarkRed);
            }
            else
            {
                Console.WriteLine($"{defender.Name} blocked all damage!", Console.ForegroundColor = ConsoleColor.Green);
            }

        }
    }
}
