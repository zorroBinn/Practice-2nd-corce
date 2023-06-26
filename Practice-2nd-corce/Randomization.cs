using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal static class Randomization
    {
        private static Random rand = new Random();
        public static int Rand(int min, int max)
        {
            lock (rand)
            {
                return rand.Next(min, max+1);
            }
        }
    }
}
