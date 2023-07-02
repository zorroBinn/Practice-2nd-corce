using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Person
    {
        public string State { get; set; }
        public System.Drawing.Color Color { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            State = "Empty";
            Color = System.Drawing.Color.Gainsboro;
            Age = 0;
        }
    }
}
