using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Player : GameCharacter
    {
        public int lives;
        public int shield;
        private int maxShield;

        public Player(string name = "Bob", int hp = 100, int lives = 3, int shield = 50) : base(name, hp)
        {
            this.lives = lives;
            this.shield = shield;
            maxShield = shield;
        }

        public new void TakeDamage(int hp)
        {
            int tempShield = shield;

            tempShield -= hp;
            if (tempShield < 0) tempShield = 0;
            hp -= shield;
            if (hp < 1) hp = 0;
            shield = tempShield;

            base.TakeDamage(hp);
            
            if (health == 0)
            {
                lives--;
                Heal(maxHealth);
                RegenerateShield(maxShield);
            }
        }

        public void RegenerateShield(int sp)
        {
            shield += sp;
            if (shield > maxShield) shield = maxShield;
        }

        public new void ShowHUD()
        {
            base.ShowHUD();
            Console.WriteLine(name + "'s Shield = " + shield);
            Console.WriteLine(name + "'s lives = " + lives);
        }
    }
}
