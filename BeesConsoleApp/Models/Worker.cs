﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeesConsoleApp.Models
{
    public class Worker
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

                if (health < 70)
                {
                    dead = true;
                }
            }

            return health;
        }
    }
}
