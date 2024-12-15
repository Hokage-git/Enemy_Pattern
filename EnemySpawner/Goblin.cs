using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EnemySpawner
{
    internal class Goblin : BaseEnemy
    {
        public int GoldDrop { get; set; }

        public Goblin(string type, int health, int damage, float speed, int goldDrop)
        {
            Type = type;
            Health = health;
            Damage = damage;
            Speed = speed;
            GoldDrop = goldDrop;
        }

        public override IEnemy Clone()
        {
            return new Goblin(this.Type, this.Health, this.Damage, this.Speed, this.GoldDrop);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Гоблин: Тип {Type}, Здоровье: {Health}, Урон: {Damage}, Скорость: {Speed}, Золота при убийстве: {GoldDrop}");
        }
    }
}
