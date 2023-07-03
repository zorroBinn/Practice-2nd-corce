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
        private Disease disease;           //Патогенный микроорганизм
        private Person[,] persons;         //Массив людей
        private const int Rows = 55;       //Высота поля
        private const int Columns = 70;    //Ширина поля
        private const int SquareSize = 15; //Размер клетки
        private int Day;                   //День в имитации
        private int Tick;                  //Один шаг передвижения людей
        private bool IsMutatiun = false;   //Была ли совершена мутация

        //Конструктор формы
        public Imitation()
        {
            InitializeComponent();
            disease = new Disease();
            Day = 0;
            Tick = 0;
            day_form.Text = Day.ToString();
            DiseaseInfoUpdate();
            persons = new Person[Rows, Columns];
        }

        //Обновление информации о патогене
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

        //Заполнение массива пустыми клетками
        private void FillPerson()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    persons[i, j] = new Person();
                }
            }
        }

        //Заполнение массива людьми
        private void FillPeople()
        {
            int count = 0;
            while (count < int.Parse(numberOfPeople.Text))
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Person Square = persons[i, j];
                        if (Square.State == "Empty" && Randomization.Rand(1, int.Parse(numberOfPeople.Text)) == 1)
                        {
                            persons[i, j] = new Healthy();
                            count++;
                            if (count == int.Parse(numberOfPeople.Text)) break;
                        }
                    }
                    if (count == int.Parse(numberOfPeople.Text)) break;
                }
            }
        }

        //Заражение случайных людей патогеном
        private void InfectRandomPersons()
        {
            int count = 0;
            while(count < int.Parse(numberOfInfected.Text)) 
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        Person Square = persons[i, j];
                        if(Square.State == "Здоров" && Randomization.Rand(1, int.Parse(numberOfPeople.Text)) == 1)
                        {
                            persons[i, j] = new Infected(disease.Incub, disease.Illness, Day, Tick, Square.Age);
                            if (++count == int.Parse(numberOfInfected.Text)) break;
                        }
                    }
                    if (count == int.Parse(numberOfInfected.Text)) break;
                }
            }
        }

        //Тик таймера передвижения - передвижение людей, распространение болезн 
        private void move_timer_Tick(object sender, EventArgs e)
        {
            Tick++;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State != "Empty" && person.State != "Мёртв")
                    {
                        UpdatePersonsMove(i, j);
                    }
                }
            }
            pictureBox.Invalidate();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State == "Инкубационный период" || person.State == "Заражён")
                    {
                        UpdatePersonsState(i, j);
                    }
                    if (person.State == "Мёртв" && checkBox_dead_delete.Checked)
                    {
                        persons[i, j] = new Person();
                    }
                }
            }
            pictureBox.Invalidate();
            NumberInfoUpdate();
            if(Tick % 8 == 0)
            {
                DayUpdate();
            } 
        }

        //Передвижение одного выбранного человека
        private void UpdatePersonsMove(int row, int column)
        {
            int i, j;
            Person person = null;
            do
            {
                i = Randomization.Rand(-1, 1);
                j = Randomization.Rand(-1, 1);
                if (row + i >= 0 && row + i < Rows && column + j >= 0 && column + j < Columns)
                {
                    person = persons[row + i, column + j];
                }
                else
                {
                    person = null;
                }
            } while (person == null || person.State != "Empty" && !(i == 0 && j == 0));
            if (i != 0 || j != 0)
            {
                persons[row + i, column + j] = persons[row, column];
                persons[row, column] = new Person();
            }
        }

        //Заражение людей при контакте
        private void UpdatePersonsState(int row, int column)
        {
            Person person = persons[row, column];
            switch (person.State)
            {
                case "Инкубационный период":
                    Infected incub = (Infected)person;
                    InfectNeighbors(row, column);
                    break;
                case "Заражён":
                    Infected infected = (Infected)person;
                    InfectNeighbors(row, column);
                    break;
            }
        }

        //Проверка соседей человека на наличие здоровых и заражение их
        private void InfectNeighbors(int row, int column)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if ((i == 0 && j == 0))
                        continue;
                    if (row + i < 0 || row + i >= Rows || column + j < 0 || column + j >= Columns)
                        continue;
                    Person neighbor = persons[row + i, column + j];
                    if (neighbor.State == "Здоров")
                    {
                        if (disease.Infected - ((Healthy)neighbor).Immunity > 0)
                        {
                            persons[row + i, column + j] = new Infected(disease.Incub, disease.Illness, Day, Tick, neighbor.Age);
                        }
                    }
                }
            }
        }

        //Обновление дня
        private void DayUpdate()
        {
            day_form.Text = (++Day).ToString();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    if (person.State == "Инкубационный период" || person.State == "Заражён")
                    {
                        UpdatePersons(i, j);
                    }
                }
            }
            pictureBox.Invalidate();
            NumberInfoUpdate();
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
                IsMutatiun = true;
                ShowMutationInfo();
                DiseaseInfoUpdate();
            }
            if (!HasInfected())
            {
                move_timer.Stop();
                button_pause.Visible = false;
                button_play.Visible = false;
                groupBoxSpeed.Visible = false;
                save_into_file_button.Visible = true;
                MessageBox.Show("Симуляция окончена", "Все зараженные выздоровели или умерли", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Обновление людей по имитационному дню
        private void UpdatePersons(int row, int column)
        {
            Person person = persons[row, column];
            switch (person.State)
            {
                case "Инкубационный период":
                    Infected incub = (Infected)person;
                    incub.ReduceIncub();
                    break;
                case "Заражён":
                    Infected infected = (Infected)person;
                    infected.ReduceInfection();
                    if (infected.InfectionDays == 0)
                    {
                        DecideFate(row, column);
                    }
                    break;
            }
        }

        //Обновление информации о количестве разных состояний людей
        private void NumberInfoUpdate()
        {
            int health = 0;
            int incub = 0;
            int illness = 0;
            int recover = 0;
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
                }
            }
            number_of_healthy.Text = health.ToString();
            number_of_incub.Text = incub.ToString();
            number_of_illness.Text = illness.ToString();
            number_of_recovery.Text = recover.ToString();
        }

        //Определения судьбы человека после болезни
        private void DecideFate(int row, int column)
        {
            Person person = persons[row, column];
            int random = Randomization.Rand(1, 100);
            if (random <= disease.Death)
            {
                persons[row, column] = new Dead(Day, person.Age);
                number_of_dead.Text = (int.Parse(number_of_dead.Text)+1).ToString();
            }
            else
            {
                persons[row, column] = new Recovered(Day, person.Age);
            }
        }

        //Проверка поля на наличие инфицированных
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

        //Временный показ информации о мутации
        private async Task ShowMutationInfo()
        {
            new_mutation.Visible = true;
            new_mutation_label.Visible = true;
            await Task.Delay(1900);
            new_mutation_label.Visible = false;
            new_mutation.Visible = false;
        }

        //Отрисовка имитационного поля
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Person person = persons[i, j];
                    Brush brush = new SolidBrush(person.Color);
                    if(person.State == "Empty")
                    {
                        g.FillRectangle(brush, j * SquareSize, i * SquareSize, SquareSize, SquareSize);
                    }
                    else
                    {
                        g.FillEllipse(brush, j * SquareSize, i * SquareSize, SquareSize, SquareSize);
                    }
                    brush.Dispose();
                }
            }
        }

        //Нажатие на кнопку "Старт" (запуск симуляции)
        private void button_play_Click(object sender, EventArgs e)
        {
            move_timer.Start();
        }

        //Нажатие на кнопку паузы (приостановка симуляции)
        private void button_pause_Click(object sender, EventArgs e)
        {
            move_timer.Stop();
        }

        //Нажатие на кнопку "Сброс имитации" с выбором сохранения мутации и/или начальных настроек
        private void button_reset_Click(object sender, EventArgs e)
        {
            move_timer.Stop();
            if (IsMutatiun)
            {
                DialogResult result = MessageBox.Show("Сохранить мутации вируса?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    disease = new Disease();
                    DiseaseInfoUpdate();
                }
            }
            button_pause.Visible = true;
            button_play.Visible = true;
            groupBoxSpeed.Visible = true;
            save_into_file_button.Visible = false;
            Day = 0;
            Tick = 0;
            day_form.Text = Day.ToString();
            groupBox_info.Visible = false;
            groupBox_create.Visible = true;
            IsMutatiun = false;
        }

        //Стандартная скорость симуляции
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                move_timer.Interval = 450;
            }
        }

        //Скорость симуляции х2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                move_timer.Interval = 225;
            }
        }

        //Скорость симуляции х4
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                move_timer.Interval = 100;
            }
        }

        //Скорость симуляции х10
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                move_timer.Interval = 45;
            }
        }

        //Подсказка с информацией о человеке по нажатии на него
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
                else if (person.State == "Исцелён")
                {
                    Recovered recover = (Recovered)persons[row, column];
                    text = "Статус: " + recover.State + "\nВозраст: " + recover.Age + "\nДень выздоровления: " + recover.DayOfRecovery;
                }
                if (text != "")
                {
                    tt.Show(text, pictureBox, x, y);
                    await Task.Delay(1300);
                    tt.Hide(pictureBox);
                }
            }
        }

        //Подсказка о количестве здоровых при навединии мышки
        private void pictureBox_Healthy_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Healthy, "Здоров");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        //Подсказка о количестве с инкубационным периодом при навединии мышки
        private void pictureBox_Incub_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Incub, "Инкубационный период");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        //Подсказка о количестве болеющих при навединии мышки
        private void pictureBox_Illness_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Illness, "Заражён");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        //Подсказка о количестве исцелённых при навединии мышки
        private void pictureBox_Recovered_MouseHover(object sender, EventArgs e) 
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Recovered, "Исцелён");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        //Подсказка о количестве умерших при навединии мышки
        private void pictureBox_Dead_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox_Dead, "Мёртв");
            t.AutomaticDelay = 120;
            t.IsBalloon = true;
        }

        //Выбор количества людей и его отображение
        private void trackBar_numberOfPeople_Scroll(object sender, EventArgs e)
        {
            numberOfPeople.Text = (trackBar_numberOfPeople.Value / 10 * 10).ToString();
            trackBar_numberOfInfected.Maximum = trackBar_numberOfPeople.Value / 10;
            if(trackBar_numberOfPeople.Value / 10 < int.Parse(numberOfInfected.Text))
            {
                trackBar_numberOfInfected.Value = trackBar_numberOfInfected.Maximum;
                numberOfInfected.Text = (trackBar_numberOfPeople.Value / 10).ToString();
            }
        }

        //Выбор количества заражённых и его отображение
        private void trackBar_numberOfInfected_Scroll(object sender, EventArgs e)
        {
            numberOfInfected.Text = trackBar_numberOfInfected.Value.ToString();
        }

        //Старт имитации по нажатии кнопки
        private void imitation_start_button_Click(object sender, EventArgs e)
        {
            groupBox_info.Visible = true;
            FillPerson();
            FillPeople();
            InfectRandomPersons();
            NumberInfoUpdate();
            pictureBox.Invalidate();
            groupBox_create.Visible = false;
        }

        //Закрытие формы имитации - удаление файла с информацией о болезни и открытие главного меню
        private void Imitation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("dt.dt"))
            {
                File.Delete("dt.dt");
            }
            this.Owner.Show();
        }

        //Сохранение в файл результатов по нажатии кнопки
        private void save_into_file_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter file = new StreamWriter(save.FileName, false);
                    file.WriteLine(type.Text + " '" + disease.Name + "'");
                    file.WriteLine();
                    file.WriteLine("Параметры болезни:");
                    file.WriteLine("Вероятность заражения: " + disease.Infected + "%");
                    if(disease.Type != 2)
                    {
                        file.WriteLine("Инкубационный период (дней): " + disease.Incub);
                    }
                    file.WriteLine("Период болезни (дней): " + disease.Illness);
                    file.WriteLine("Летальность: " + disease.Death + "%");
                    file.WriteLine();
                    file.WriteLine("Имитация продлилась (дней): " + Day);
                    file.WriteLine("Человек, участвующих в симуляции: " + numberOfPeople.Text);
                    file.WriteLine("Изначально инфицированных: " + numberOfInfected.Text); 
                    file.WriteLine();
                    file.WriteLine("Итоговые значения симуляции: ");
                    if (int.Parse(number_of_healthy.Text) != 0)
                    {
                        file.WriteLine("Осталось здоровых: " + number_of_healthy.Text);
                    }
                    if(int.Parse(number_of_recovery.Text) != 0)
                    {
                        file.WriteLine("Исцелено: " + number_of_recovery.Text);
                    }
                    if (int.Parse(number_of_dead.Text) != 0)
                    {
                        file.WriteLine("Умерших: " + number_of_dead.Text);
                    }
                    file.Close();
                }
                catch (Exception) 
                {
                    MessageBox.Show("Ошибка сохранения файла", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Файл сохранён!", "Сохранено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
