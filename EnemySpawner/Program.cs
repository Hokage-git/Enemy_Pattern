using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemySpawner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zombie baseZombie = new Zombie("Обычный", 100, 10, 1.5f, 20);

            Zombie eliteZombie = baseZombie.Clone() as Zombie;
            eliteZombie.Type = "Элитный";
            eliteZombie.Health = 250;
            eliteZombie.Damage = 25;
            eliteZombie.InfectionChance = 50;

            Goblin baseGoblin = new Goblin("Слабый", 50, 5, 2.0f, 10);

            Goblin strongGoblin = baseGoblin.Clone() as Goblin;
            strongGoblin.Type = "Сильный";
            strongGoblin.Health = 150;
            strongGoblin.Damage = 15;
            strongGoblin.GoldDrop = 50;

            baseZombie.DisplayInfo();
            eliteZombie.DisplayInfo();
            baseGoblin.DisplayInfo();
            strongGoblin.DisplayInfo();
            Console.ReadKey();
        }
    }
}
