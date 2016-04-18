using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingPatrol
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        { get { return 10; } }

        public int StingerLength
        { get; set; }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return 11;
        }
    }
}
