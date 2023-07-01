using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Infected : Person
    {
        public int IncubDays { get; set; }
        public int InfectionDays { get; set; }
        public int DayOfDisease { get; set; }

        public Infected(int incub, int infection, int day_of_disease, int age)
        {
            IncubDays = incub;
            InfectionDays = infection;
            DayOfDisease = day_of_disease;
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

        public void ReduceIncub()
        {
            IncubDays -= 1;
            if (IncubDays == 0)
            {
                State = "Заражён";
                Color = System.Drawing.Color.Brown;
            }
        }

        public void ReduceInfection() 
        { 
            InfectionDays -= 1;
        }
    }
}
