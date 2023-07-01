using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Recovered : Person
    {
        public int DayOfRecovery { get; set; }

        public Recovered(int day, int age) 
        {
            DayOfRecovery = day;
            Age = age;
            State = "Исцелён";
            Color = System.Drawing.Color.LightGreen;
        }
    }
}
