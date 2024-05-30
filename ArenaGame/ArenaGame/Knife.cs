using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Knife : Weapon
    {
        private const int ExtraDamageMultiplier = 180;
        private int stabCount; //every third stab can cause 80% more damage

        public Knife() : base("Knife", 10)
        {
            stabCount = 0;
        }

        public override int EnhanceAttack(int baseAttack)
        {
            stabCount++;
            if (stabCount % 3 == 0)
            {
                return baseAttack * ExtraDamageMultiplier / 100;
            }
            return baseAttack;
        }
    }
}
