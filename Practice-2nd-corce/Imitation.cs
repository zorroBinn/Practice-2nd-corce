using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private Person[,] persons;
        private const int Rows = 40;
        private const int Columns = 50;
        private const int SquareSize = 20;
        private int Day;
        public Imitation()
        {
            InitializeComponent();
            disease = new Disease();
            Day = 0;
            day_form.Text = Day.ToString();
            Disease_Info_Update();
            persons = new Person[Rows, Columns];
            FillPerson();
            InfectRandomPerson();

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

        private void FillPerson()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    persons[i, j] = new Healthy();
                }
            }
        }

        private void InfectRandomPerson()
        {
            int row = Randomization.Rand(0, Rows - 1);
            int column = Randomization.Rand(0, Columns - 1);
            persons[row, column] = new Infected(disease.Incub, disease.Illness, Day);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            day_form.Text = (++Day).ToString();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    UpdatePerson(i, j);
                }
            }
            pictureBox.Invalidate();
            if (!HasInfected())
            {
                timer.Stop();
                button_pause.Visible = false;
                button_play.Visible = false;
                button_step.Visible = false;
                groupBoxSpeed.Visible = false;
                MessageBox.Show("Симуляция окончена", "Все зараженные выздоровели или умерли", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdatePerson(int row, int column)
        {
            Person person = persons[row, column];
            switch (person.State)
            {
                case "Здоров":
                    //CheckNeighbors(row, column);
                    break;
                case "Инкубациооный период":
                    Infected incub = (Infected)person;
                    incub.Reduce_Incub();
                    if (incub.Day_of_disease == Day-1) InfectNeighbors(row, column);
                    break;
                case "Заражён":
                    Infected infected = (Infected)person;
                    infected.Reduce_Infection();
                    if (infected.Day_of_disease == Day - 1) InfectNeighbors(row, column);
                    if (infected.Infection_Days == 0)
                    {
                        DecideFate(row, column);
                    }
                    break;
            }
        }

        private void CheckNeighbors(int row, int column)
        {
            Healthy healthy = (Healthy)persons[row, column];
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if ((i == 0 && j == 0) || (i != 0 && j != 0))
                        continue;
                    if (row + i < 0 || row + i >= Rows || column + j < 0 || column + j >= Columns)
                        continue;
                    Person neighbor = persons[row + i, column + j];
                    if (neighbor.State == "Инкубациооный период" || neighbor.State == "Заражён")
                    {
                        if (disease.Infected - healthy.Immunity > 0)
                        {
                            persons[row, column] = new Infected(disease.Incub, disease.Illness, Day);
                        }
                    }
                }
            }
        }

        // Метод для проверки соседей человека на наличие здоровых
        private void InfectNeighbors(int row, int column)
        {
            Infected infected = (Infected)persons[row, column];
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if ((i == 0 && j == 0) || (i != 0 && j != 0))
                        continue;
                    if (row + i < 0 || row + i >= Rows || column + j < 0 || column + j >= Columns)
                        continue;
                    Person neighbor = persons[row + i, column + j];
                    if (neighbor.State == "Здоров")
                    {
                        if (disease.Infected - ((Healthy)neighbor).Immunity > 0)
                        {
                            persons[row + i, column + j] = new Infected(disease.Incub, disease.Illness, Day);
                        }
                    }
                }
            }
        }

        // Метод для определения судьбы человека после болезни
        private void DecideFate(int row, int column)
        {
            Infected infected = (Infected)persons[row, column];
            int random = Randomization.Rand(1, 100);
            if (random <= disease.Death)
            {
                persons[row, column] = new Dead(Day);
            }
            else
            {
                persons[row, column] = new Recovered(Day);
            }
        }

        private bool HasInfected()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State == "Инкубациооный период" || person.State == "Заражён")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    Brush brush = new SolidBrush(person.Color);
                    g.FillRectangle(brush, j * SquareSize, i * SquareSize, SquareSize, SquareSize);
                    brush.Dispose();
                }
            }
        }

        private void Imitation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("dt.dt"))
            {
                File.Delete("dt.dt");
            }
            this.Owner.Show();
        }

        private void button_step_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer_Tick(sender, e);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button_pause.Visible = true;
            button_play.Visible = true;
            button_step.Visible = true;
            groupBoxSpeed.Visible = true;
            Day = 0;
            day_form.Text = (++Day).ToString();
            FillPerson();
            InfectRandomPerson();
            pictureBox.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                timer.Interval = 400;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                timer.Interval = 200;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                timer.Interval = 100;
            }
        }
    }
}
