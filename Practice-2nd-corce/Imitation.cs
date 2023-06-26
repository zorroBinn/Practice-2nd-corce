using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2nd_corce
{
    public partial class Imitation : Form
    {
        private Disease disease;
        private int Day;
        public Imitation()
        {
            InitializeComponent();
            disease = new Disease();
            Day = 0;
            this.day_form.Text = Day.ToString();
            Disease_Info_Update();
        }

        private void Disease_Info_Update()
        {
            switch(disease.Type)
            {
                case 0:
                    {
                        this.type.Text = "Бактерия";
                        this.type.ForeColor = Color.Green;
                        this.name.ForeColor = Color.Green;
                        this.infection.ForeColor = Color.Green;
                        this.incub.ForeColor = Color.Green;
                        this.illness.ForeColor = Color.Green;
                        this.death.ForeColor = Color.Green;
                        this.percent_infection.ForeColor = Color.Green;
                        this.percent_death.ForeColor = Color.Green;
                        break;
                    }
                case 1:
                    {
                        this.type.Text = "Вирус";
                        this.type.ForeColor = Color.Red;
                        this.name.ForeColor = Color.Red;
                        this.infection.ForeColor = Color.Red;
                        this.incub.ForeColor = Color.Red;
                        this.illness.ForeColor = Color.Red;
                        this.death.ForeColor = Color.Red;
                        this.percent_infection.ForeColor = Color.Red;
                        this.percent_death.ForeColor = Color.Red;
                        break;
                    }
                case 2:
                    {
                        this.type.Text = "Прион";
                        this.type.ForeColor = Color.Blue;
                        this.name.ForeColor = Color.Blue;
                        this.infection.ForeColor = Color.Blue;
                        this.incub.ForeColor = Color.Blue;
                        this.illness.ForeColor = Color.Blue;
                        this.death.ForeColor = Color.Blue;
                        this.percent_infection.ForeColor = Color.Blue;
                        this.percent_death.ForeColor = Color.Blue;
                        break;
                    }
            }
            this.name.Text = disease.Name;
            this.infection.Text = disease.Infected.ToString();
            this.incub.Text = disease.Incub.ToString();
            this.illness.Text = disease.Illness.ToString();
            this.death.Text = disease.Death.ToString();
        }

        private void Imitation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("dt.dt"))
            {
                File.Delete("dt.dt");
            }
            this.Owner.Show();
        }

    }
}
