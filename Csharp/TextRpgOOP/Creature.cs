using System;
using System.Collections.Generic;
using System.Text;

namespace TextRpgOOP
{
    public enum CreatureType
    {
        None = 0,
        Player =1,
        Monster = 2
    }

    class Creature
    {
        CreatureType type;
        protected Creature(CreatureType type)
        {
            this.type = type;
        }
        protected int hp = 0;
        protected int atk = 0;
        public int Gethp() { return hp; }
        public int Getatk() { return atk; }

        public bool isDead() { return hp <= 0; }

        public void OnDamaged(int dmg)
        {
            hp -= dmg;
            if (hp < 0)
                hp = 0;
        }
        public void Setinfo(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }
    }
}
