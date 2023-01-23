using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class GameCharacter
    {

        public string name;
        public int health;
        public int lives;
        public int maxHealth;


        public GameCharacter(string name, int hp)
        {
            this.name = name;
            this.health = hp;
            maxHealth = hp;
        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > maxHealth) health = maxHealth;
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health <= 0) health = 0;
        }

        public void ShowHUD()
        {
            Console.WriteLine("Game Character: " + name);
            Console.WriteLine(name + "'s Health = " + health);
        }
    }
}
