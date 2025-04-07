using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.RPG
{
    internal class Player
    {
        private string name;

        private int life;
        private int damage;

        public string Name { get { return name; } }

        public Player(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        private void ChangeLife(int value)
        {
            life += value;
            if (life < 0)
            {
                life = 0;
            }
        }

        public void TakeDamage(int value)
        {
            ChangeLife(-value);
        }

        public int GetDamage()
        {
            return damage;
        }

        public bool IsAlive()
        {
            return life > 0;
        }

        public string GetData()
        {
            return $"Nombre: {name} - Vida: {life} - Daño: {damage}";
        }
    }
}
