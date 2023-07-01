using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Dead : Person
    {
        private int dead_day;

        public int Dead_Day { get { return dead_day; } set { dead_day = value; } }

        public Dead(int dead_day)
        {
            this.dead_day = dead_day;
            this.state = "Мёртв";
            this.color = System.Drawing.Color.Black;
        }
    }
}
