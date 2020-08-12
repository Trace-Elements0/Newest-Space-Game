using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace SpaceGameTest
{
    public class Actions
    {
        public void Fight(Characters attacker, Characters defender)
        {
            Random rando = new Random();
            do
            {
                Console.WriteLine($"{attacker.Name} launches an attack!");

                Thread.Sleep(3000);

                int hitpoints = rando.Next(25, 100);

                defender.Health -= hitpoints;

                Console.WriteLine($"{defender.Name} was damaged and lost {hitpoints} health and now has {defender.Health}.");
                Thread.Sleep(3000);
                if (defender.Health !<= 0)
                    continue;

                int hitpoints2nd = rando.Next(25, 100);
                attacker.Health -= hitpoints2nd;

                Console.WriteLine($"{attacker.Name} was damaged and lost {hitpoints} health and now has {attacker.Health} health.");
            } while (attacker.Health > 0 && defender.Health > 0);

            Console.WriteLine(attacker.Health > defender.Health ? $"{attacker.Name} wins!" : $"{defender.Name} wins!");
        }

        public static void Bargain()
        {
            Random rando = new Random();
            int choice = rando.Next(1, 2);

        }

        public static void Pause()
        {
            Console.WriteLine("\nPress any continue to continue...");
            Console.ReadKey(true);
        }

        public void Defend()
        {

        }

        public void Die()
        {
            //TODO:
        }

        public void Sell()
        {
            //TODO
        }

        public void Restart()
        {

        }

        public void MerchantCelebration()
        {

        }



    }
}