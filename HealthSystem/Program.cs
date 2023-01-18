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
            Console.WriteLine("Health System\n");
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.TakeDamage(34);
            player.ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("");
            player.Heal(4);
            player.ShowHUD();
            Console.ReadKey(true);
        }
    }
}
