using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2nd_corce
{
    internal class Infected : Person
    {
        private int incub_days;
        private int infection_days;
        private int day_of_disease;

        public int Incub_Days { get { return incub_days; } set { incub_days = value; } }
        public int Infection_Days { get { return infection_days; } set { infection_days = value; } }

        public int Day_of_disease { get { return day_of_disease; } set { day_of_disease = value;} }

        public Infected(int incub, int infection, int day_of_disease)
        {
            this.incub_days = incub;
            this.infection_days = infection;
            this.day_of_disease = day_of_disease;
            if (incub_days > 0)
            {
                this.state = "Инкубациооный период";
                this.color = System.Drawing.Color.MistyRose;
            }
            else 
            {
                this.state = "Заражён";
                this.color = System.Drawing.Color.Red;
            }
        }

        public void Reduce_Incub()
        {
            this.incub_days -= 1;
            if (this.incub_days == 0)
            {
                this.state = "Заражён";
                this.color = System.Drawing.Color.Red;
            }
        }

        public void Reduce_Infection() 
        { 
            this.infection_days -= 1;
        }
        
        public void App_Day_Of_Disease()
        {
            this.day_of_disease += 1;
        }
    }
}
