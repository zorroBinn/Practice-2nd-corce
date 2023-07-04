using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2nd_corce
{
    internal class Disease //Патоген
    {
        public int Type { get; set; } //Тип патогена
        public string Name { get; set; } //Название патогена
        public int Infected { get; set; } //Вероятность заражения патогена
        public int Incub { get; set; } //Инкубационный период патогена
        public int Illness { get; set; } //Период болезни патогена
        public int Death { get; set; } //Летальность патогена

        public Disease() //Конструктор по умолчанию
        {
            try
            {
                StreamReader file = File.OpenText("dt.dt");
                Type = int.Parse(file.ReadLine());
                Name = file.ReadLine();
                Infected = int.Parse(file.ReadLine());
                Incub = int.Parse(file.ReadLine());
                Illness= int.Parse(file.ReadLine());
                Death = int.Parse(file.ReadLine());
                file.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания", "Файл повреждён!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Mutation() //Метод "мутация патогена". Мутация происходит с некоторым шансом (зависит от типа патогена) каждый день
        {
            int mutation_probability;
            switch(Type)
            {
                case 0:
                    mutation_probability = Randomization.Rand(1, 5);
                    if (Randomization.Rand(1, 100) <= mutation_probability)
                    {
                        if (MutationSet(1, 8, 10)) return true;
                    }
                    break; 
                case 1:
                    mutation_probability = Randomization.Rand(1, 9);
                    if (Randomization.Rand(1, 100) <= mutation_probability)
                    {
                        if (MutationSet(5, 10, 10)) return true;
                    }
                    break;
                case 2:
                    mutation_probability = Randomization.Rand(1, 3);
                    if (Randomization.Rand(1, 100) < mutation_probability)
                    {
                        if (MutationSet(1, 10, 3)) return true;
                    }
                    break;
            }
            return false;
        }

        private bool MutationSet(int min, int max, int min_infected) //Метод, определяющий направление мутации
        {
            int mutation_type = Randomization.Rand(1, 3);
            int mutation_updown = Randomization.Rand(1, 2);
            switch (mutation_type)
            {
                case 1:
                    {
                        if (mutation_updown == 1 && Infected < 90)
                        {
                            Infected += Randomization.Rand(min, max);
                            return true;
                        }
                        else if (mutation_updown == 2 && Infected > min_infected && Type != 2)
                        {
                            Infected -= Randomization.Rand(min, max);
                            return true;
                        }
                        break;
                    }
                case 2:
                    {
                        if (mutation_updown == 1)
                        {
                            Illness += Randomization.Rand(1, 5);
                            return true;
                        }
                        else if (mutation_updown == 2 && Illness > 5)
                        {
                            Illness -= Randomization.Rand(1, 4);
                            return true;
                        }
                        break;
                    }
                case 3:
                    {
                        if (mutation_updown == 1 && Death < 90)
                        {
                            Death += Randomization.Rand(min, max);
                            return true;
                        }
                        else if (mutation_updown == 2)
                        {
                            Death -= Randomization.Rand(min, max);
                            return true;
                        }
                        break;
                    }
            }
            return false;
        }
    }
}
