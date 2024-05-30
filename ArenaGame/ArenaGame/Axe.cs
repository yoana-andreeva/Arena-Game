using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
     public class Axe : Weapon
     {
        private const int DoubleDamageChance = 20;
        //has a 20% chance to cause double damage

        public Axe() : base("Axe", 10)
        {
        }

        public override int EnhanceAttack(int baseAttack)
        {
            if (Random.Shared.Next(101) < DoubleDamageChance)
            {
                return baseAttack * 2;
            }
            return baseAttack;
        }
    }
}
