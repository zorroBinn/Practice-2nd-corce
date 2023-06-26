using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2nd_corce
{
    internal class Disease
    {
        private int type;
        private string name;
        private int infected;
        private int incub;
        private int illness;
        private int death;

        public int Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Infected { get { return infected; } set { infected = value; } }
        public int Incub { get { return incub; } set { incub = value; } }
        public int Illness { get { return illness; } set { illness = value; } }
        public int Death { get { return death; } set { death = value; } }

        public Disease() 
        {
            try
            {
                StreamReader file = File.OpenText("dt.dt");
                this.type = int.Parse(file.ReadLine());
                this.name = file.ReadLine();
                this.infected = int.Parse(file.ReadLine());
                this.incub = int.Parse(file.ReadLine());
                this.illness= int.Parse(file.ReadLine());
                this.death = int.Parse(file.ReadLine());
                file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания", "Файл повреждён!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Mutation()
        {
            int mutation_probability;
            if (this.type == 0)
            {
                mutation_probability = Randomization.Rand(1, 4);
                
                if (Randomization.Rand(1,100) <= mutation_probability)
                {
                    MutationSet(1, 8, 10);
                }
            }
            else if (this.type == 1)
            {
                mutation_probability = Randomization.Rand(1, 8); 
                if (Randomization.Rand(1, 100) <= mutation_probability)
                {
                    MutationSet(5, 10, 10);
                }
            }
            else
            {
                mutation_probability = Randomization.Rand(1, 2); 
                if (Randomization.Rand(1, 100) < mutation_probability)
                {
                    MutationSet(1, 3, 3);
                }
            }
        }

        private void MutationSet(int min, int max, int min_infected)
        {
            int mutation_type = Randomization.Rand(1, 3);
            int mutation_updown = Randomization.Rand(1, 2);
            switch (mutation_type)
            {
                case 1:
                    {
                        if (mutation_updown == 1 && this.infected < 90)
                        {
                            this.infected += Randomization.Rand(min, max);
                        }
                        else if (mutation_updown == 2 && this.infected > min_infected)
                        {
                            this.infected -= Randomization.Rand(min, max);
                        }
                        break;
                    }
                case 2:
                    {
                        if (mutation_updown == 1)
                        {
                            this.illness += Randomization.Rand(1, 5);
                        }
                        else if (mutation_updown == 2 && this.illness > 5)
                        {
                            this.illness -= Randomization.Rand(1, 4);
                        }
                        break;
                    }
                case 3:
                    {
                        if (mutation_updown == 1 && this.death < 90)
                        {
                            this.death += Randomization.Rand(min, max);
                        }
                        else if (mutation_updown == 2 && this.death > 10)
                        {
                            this.death -= Randomization.Rand(min, max);
                        }
                        break;
                    }
            }
        }

    }
}
