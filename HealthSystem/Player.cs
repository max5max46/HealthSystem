using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Player
    {
        private string name;
        private int health;
        private int lives;


        public Player(string name = "Bobert")
        {
            this.name = name;
            health = 100;
            lives = 3;
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health <= 0) health = 0;
        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > 100) health = 100;
        }

        public void ShowHUD()
        {
            Console.WriteLine("Player: " + name);
            Console.WriteLine(name + "'s Health = " + health);
            Console.WriteLine(name + "'s lives = " + lives);
        }
    }
}
