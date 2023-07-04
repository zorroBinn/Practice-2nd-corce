using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Infected : Person //Инфицированный человек
    {
        public int IncubDays { get; set; } //Оставшихся дней инкубационного периода
        public int InfectionDays { get; set; } //Оставшихся дней периода болезни
        public int DayOfDisease { get; set; } //День заражения

        public Infected(int incub, int infection, int day, int tick, int age) //Конструктор с параметрами
        {
            IncubDays = incub;
            InfectionDays = infection;
            DayOfDisease = day;
            Age = age;
            if (IncubDays > 0)
            {
                State = "Инкубационный период";
                Color = System.Drawing.Color.Salmon;
            }
            else 
            {
                State = "Заражён";
                Color = System.Drawing.Color.Brown;
            }
        }

        public void ReduceIncub() //Уменьшение оставшихся дней инкубационного периода с изменением статуса
        {
            IncubDays -= 1;
            if (IncubDays == 0)
            {
                State = "Заражён";
                Color = System.Drawing.Color.Brown;
            }
        }

        public void ReduceInfection() //Уменьшение оставшихся дней периода болезни
        { 
            InfectionDays -= 1;
        }
    }
}
