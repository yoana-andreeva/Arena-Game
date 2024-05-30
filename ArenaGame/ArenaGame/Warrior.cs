using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Warrior : Hero
    {
        private const int DoubleStrikeChance = 25;
        private const int HalfDamageChance = 15;
        //25% chance to make double strike
        //15% chance to double reduce the incoming damage
        public Warrior(string name) : base(name)
        {
        }
        public Warrior(string name, Weapon weapon) : base(name, weapon)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if(ThrowDice(DoubleStrikeChance)) attack = attack * 2;
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if(ThrowDice(HalfDamageChance))
            {
                incomingDamage = incomingDamage - (incomingDamage * 50) / 100;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
