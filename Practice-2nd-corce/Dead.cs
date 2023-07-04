using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Dead : Person //Умерший человек
    {
        public int DeadDay { get; set; } //День смерти

        public Dead(int day, int age) //Конструктор с параметрами
        {
            Age = age;
            DeadDay = day;
            State = "Мёртв";
            Color = System.Drawing.Color.Black;
        }
    }
}
