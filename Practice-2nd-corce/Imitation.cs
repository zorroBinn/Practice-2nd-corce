using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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
            DiseaseInfoUpdate();
            persons = new Person[Rows, Columns];
            FillPerson();
            InfectRandomPerson();
            NumberInfoUpdate();
        }

        private void DiseaseInfoUpdate()
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
            persons[row, column] = new Infected(disease.Incub, disease.Illness, Day, persons[row, column].Age);
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
            if (disease.Mutation())
            {
                string text = "";
                if (disease.Infected > Int32.Parse(infection.Text))
                {
                    text = "Вероятность передачи +" + (disease.Infected - Int32.Parse(infection.Text));
                }
                else if (disease.Infected < Int32.Parse(infection.Text))
                {
                    text = "Вероятность передачи -" + (Int32.Parse(infection.Text) - disease.Infected);
                }
                else if (disease.Illness > Int32.Parse(illness.Text))
                {
                    text = "Период болезни +" + (disease.Illness - Int32.Parse(illness.Text));
                }
                else if (disease.Illness < Int32.Parse(illness.Text))
                {
                    text = "Период болезни -" + (Int32.Parse(illness.Text) - disease.Illness);
                }
                else if (disease.Death > Int32.Parse(death.Text))
                {
                    text = "Летальность +" + (disease.Death - Int32.Parse(death.Text));
                }
                else if (disease.Death < Int32.Parse(death.Text))
                {
                    text = "Летальность -" + (Int32.Parse(death.Text) - disease.Death);
                }
                new_mutation.Text = text;
                ShowMutationInfo();
                DiseaseInfoUpdate();
            }
            pictureBox.Invalidate();
            NumberInfoUpdate();
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

        private void NumberInfoUpdate()
        {
            int health = 0;
            int incub = 0;
            int illness = 0;
            int recover = 0;
            int dead = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State == "Здоров")
                    {
                        health++;
                        if (Day % 365 == 0)
                        {
                            person.Age++;
                        }
                    }
                    else if (person.State == "Инкубационный период")
                    {
                        incub++;
                        if (Day % 365 == 0)
                        {
                            person.Age++;
                        }
                    }
                    else if (person.State == "Заражён")
                    {
                        illness++;
                        if (Day % 365 == 0)
                        {
                            person.Age++;
                        }
                    }
                    else if (person.State == "Исцелён")
                    {
                        recover++;
                        if (Day % 365 == 0)
                        {
                            person.Age++;
                        }
                    }
                    else if (person.State == "Мёртв")
                    {
                        dead++;
                    }
                }
            }
            number_of_healthy.Text = health.ToString();
            number_of_incub.Text = incub.ToString();
            number_of_illness.Text = illness.ToString();
            number_of_recovery.Text = recover.ToString();
            number_of_dead.Text = dead.ToString();
        }

        private void UpdatePerson(int row, int column)
        {
            Person person = persons[row, column];
            switch (person.State)
            {
                case "Инкубационный период":
                    Infected incub = (Infected)person;
                    incub.ReduceIncub();
                    if (incub.DayOfDisease == Day-1) InfectNeighbors(row, column);
                    break;
                case "Заражён":
                    Infected infected = (Infected)person;
                    infected.ReduceInfection();
                    if (infected.DayOfDisease == Day - 1) InfectNeighbors(row, column);
                    if (infected.InfectionDays == 0)
                    {
                        DecideFate(row, column);
                    }
                    break;
            }
        }

        //private void CheckNeighbors(int row, int column)
        //{
        //    Healthy healthy = (Healthy)persons[row, column];
        //    for (int i = -1; i <= 1; i++)
        //    {
        //        for (int j = -1; j <= 1; j++)
        //        {
        //            if ((i == 0 && j == 0) || (i != 0 && j != 0))
        //                continue;
        //            if (row + i < 0 || row + i >= Rows || column + j < 0 || column + j >= Columns)
        //                continue;
        //            Person neighbor = persons[row + i, column + j];
        //            if (neighbor.State == "Инкубационный период" || neighbor.State == "Заражён")
        //            {
        //                if (disease.Infected - healthy.Immunity > 0)
        //                {
        //                    persons[row, column] = new Infected(disease.Incub, disease.Illness, Day);
        //                }
        //            }
        //        }
        //    }
        //}

        // Метод для проверки соседей человека на наличие здоровых
        private void InfectNeighbors(int row, int column)
        {
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
                            persons[row + i, column + j] = new Infected(disease.Incub, disease.Illness, Day, neighbor.Age);
                        }
                    }
                }
            }
        }

        // Метод для определения судьбы человека после болезни
        private void DecideFate(int row, int column)
        {
            Person person = persons[row, column];
            int random = Randomization.Rand(1, 100);
            if (random <= disease.Death)
            {
                persons[row, column] = new Dead(Day, person.Age);
            }
            else
            {
                persons[row, column] = new Recovered(Day, person.Age);
            }
        }

        private bool HasInfected()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State == "Инкубационный период" || person.State == "Заражён")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool HasHealthy()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State != "Здоров")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private async Task ShowMutationInfo()
        {
            new_mutation.Visible = true;
            new_mutation_label.Visible = true;
            await Task.Delay(1900);
            new_mutation_label.Visible = false;
            new_mutation.Visible = false;
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
            DialogResult result = MessageBox.Show("Сохранить мутации вируса?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                disease = new Disease();
                DiseaseInfoUpdate();
            }
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                timer.Interval = 40;
            }
        }

        private async void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int row = y / SquareSize;
            int column = x / SquareSize;
            if (row >= 0 && row < Rows && column >= 0 && column < Columns)
            {
                string text = "";
                Person person = persons[row, column];
                ToolTip tt = new ToolTip();
                if (person.State == "Здоров")
                {
                    Healthy health = (Healthy)persons[row, column];
                    text = "Статус: " + health.State + "\nВозраст: " + health.Age + "\nИммунитет: " + health.Immunity + "%";
                    text += "\nДважды нажмите, чтобы заразить...";
                }
                else if (person.State == "Инкубационный период" || person.State == "Заражён")
                {
                    Infected infect = (Infected)persons[row, column];
                    text = "Статус: " + infect.State + "\nВозраст: " + infect.Age + "\nДень заражения: " + infect.DayOfDisease;
                }
                else if (person.State == "Мёртв")
                {
                    Dead dead = (Dead)persons[row, column];
                    text = "Статус: " + dead.State + "\nВозраст: " + dead.Age + "\nДень смерти: " + dead.DeadDay;
                }
                else
                {
                    Recovered recover = (Recovered)persons[row, column];
                    text = "Статус: " + recover.State + "\nВозраст: " + recover.Age + "\nДень выздоровления: " + recover.DayOfRecovery;
                    text += "\nДважды нажмите, чтобы заразить...";
                }
                tt.Show(text, pictureBox, x, y);
                await Task.Delay(1300);
                tt.Hide(pictureBox);
            }
        }

        private void pictureBox_Healthy_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Healthy, "Здоров");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        private void pictureBox_Incub_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Incub, "Инкубационный период");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        private void pictureBox_Illness_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Illness, "Заражён");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        private void pictureBox_Recovered_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Recovered, "Исцелён");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        private void pictureBox_Dead_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Dead, "Мёртв");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }
    }
}
