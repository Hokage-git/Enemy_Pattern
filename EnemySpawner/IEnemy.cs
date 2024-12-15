using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemySpawner
{
    internal interface IEnemy
    {
        IEnemy Clone();
        void DisplayInfo();
    }

    abstract class BaseEnemy : IEnemy
    {
        public string Type { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public float Speed { get; set; }

        public abstract IEnemy Clone();
        public abstract void DisplayInfo();
    }
}
