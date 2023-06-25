using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal abstract class Person
    {
        protected string state;
        protected System.Drawing.Color color;

        public string State { get { return state; } set { state = value; } }
        public System.Drawing.Color Color { get { return color; } set { color = value; } }
        
    }
}
