using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
   public class Hammer : Weapon
   {
        // no special power, adds 20 damage bonus
        public Hammer() : base("Hammer", 20)
        {
        }

        public override int EnhanceAttack(int baseAttack)
        {
            return baseAttack;
        }
    }
}
