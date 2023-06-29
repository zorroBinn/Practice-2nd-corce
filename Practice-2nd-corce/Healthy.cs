using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Healthy : Person
    {
        public int Immunity { get; set; }

        public Healthy()
        {
            Age = Randomization.Rand(15, 90);
            State = "Здоров";
            Color = System.Drawing.Color.SkyBlue;
            if (Age < 25)
            {
                Immunity = Randomization.Rand(0, 90);
            }
            else if (Age >= 25 && Age <= 50)
            {
                Immunity = Randomization.Rand(0, 65);
            }
            else if (Age > 50 && Age <= 70)
            {
                Immunity = Randomization.Rand(0, 40);
            }
            else
            {
                Immunity = Randomization.Rand(0, 15);
            }
        }
    }
}
