using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Phil");
            Enemy enemy = new Enemy("Skeleton", 50);

            Console.WriteLine("Health System\n\nPlayer:\n");
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.TakeDamage(34);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.TakeDamage(57);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.Heal(14);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.RegenerateShield(23);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.TakeDamage(127);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("\n\n");

            Console.WriteLine("Enemy:\n");
            enemy.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            enemy.TakeDamage(23);
            enemy.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            enemy.Heal(48);
            enemy.ShowHUD();
            Console.ReadKey(true);
        }
    }
}
