using System;
using System.Collections.Generic;
using System.Text;

namespace BeesConsoleApp.Models
{
    public class Queen
    {
        private static float health = 100;
        public bool dead;

        public float Damage(int val)
        {
            if (!dead)
            {
                if (val > 0 && val < 100)
                {
                    health = (float)(health - (val * health / 100));
                }

                if (health < 20)
                {
                    dead = true;
                }
            }

            return health;
        }
    }
}
