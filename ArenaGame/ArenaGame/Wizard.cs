using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Wizard : Hero
    {
        private const int HealingSpellChance = 15;
        private int HealingSpellMultiplier = 30;
        private const int HypnoticSpellChance = 15;
        private const int HypnoticSpell = 130;
        // has 15% chance to hipnotize the opponent and cause 30% more damage
        // has 15% chance to heal himself and increase health by 30%
        

        public Wizard(string name) : base(name)
        {
        }
        public Wizard(string name, Weapon weapon) : base(name, weapon)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(HypnoticSpellChance))
            {
                attack = attack * HypnoticSpell / 100;
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
            if (ThrowDice(HealingSpellChance))
            {
                Heal(this.Health * HealingSpellMultiplier / 100);
                //for (int i = 0; i < 5; i++)
                //{
                //    base.Heal(this.Health * HealingSpellMultiplier / 100);
                //    HealingSpellMultiplier += 10;
                //}
                
            }
           
        }
    }
}
