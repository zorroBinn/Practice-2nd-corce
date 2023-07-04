using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Recovered : Person //Исцелённый человек
    {
        public int DayOfRecovery { get; set; } //День исцеления

        public Recovered(int day, int age) //Конструктор с параметрами
        {
            DayOfRecovery = day;
            Age = age;
            State = "Исцелён";
            Color = System.Drawing.Color.LightGreen;
        }
    }
}
