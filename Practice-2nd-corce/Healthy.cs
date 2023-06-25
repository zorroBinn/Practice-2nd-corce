using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Healthy : Person
    {
        private int immunity;

        public int Immunity { get { return immunity;} set { immunity = value; } }
        
        public Healthy() 
        {
            this.state = "Здоров";
            this.color = System.Drawing.Color.Silver;
            Random random = new Random();
            this.immunity = random.Next(0,99);
        }
    }
}
