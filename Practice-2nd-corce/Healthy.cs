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
            this.color = System.Drawing.Color.Lavender;
            RandomAge();
            if (this.age < 25)
            {
                this.immunity = Randomization.Rand(0, 95);
            }
            else if (this.age >= 25 && this.age <= 50)
            {
                this.immunity = Randomization.Rand(0, 70);
            }
            else if (this.age >= 50 && this.age <= 70)
            {
                this.immunity = Randomization.Rand(0, 50);
            }
            else
            {
                this.immunity = Randomization.Rand(0, 20);
            }
        }
    }
}
