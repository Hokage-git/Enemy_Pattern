using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EnemySpawner
{
    internal class Zombie : BaseEnemy
    {
        public int InfectionChance { get; set; }

        public Zombie(string type, int health, int damage, float speed, int infectionChance)
        {
            Type = type;
            Health = health;
            Damage = damage;
            Speed = speed;
            InfectionChance = infectionChance;
        }

        public override IEnemy Clone()
        {
            return new Zombie(this.Type, this.Health, this.Damage, this.Speed, this.InfectionChance);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Зомби: Тип {Type}, Здоровье: {Health}, Урон: {Damage}, Скорость: {Speed}, Шанс заражения: {InfectionChance}%");
        }
    }
}
