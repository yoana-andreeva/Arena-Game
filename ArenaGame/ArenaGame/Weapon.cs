using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int DamageBonus { get; private set; }

        public Weapon(string name, int damageBonus)
        {
            Name = name;
            DamageBonus = damageBonus;
        }
        public virtual int EnhanceAttack(int baseAttack)
        {
            return baseAttack;
        }
    }
}
