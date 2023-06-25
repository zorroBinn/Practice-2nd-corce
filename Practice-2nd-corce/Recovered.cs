using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Recovered : Person
    {
        private int day_of_recovery;

        public int Day_Of_Recovery { get { return day_of_recovery; } set { day_of_recovery = value; } }

        public Recovered(int day) 
        {
            this.day_of_recovery = day;
            this.state = "Исцелён";
            this.color = System.Drawing.Color.PaleGreen;
        }
    }
}
