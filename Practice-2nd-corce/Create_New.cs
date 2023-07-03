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
using System.Globalization;

namespace Practice_2nd_corce
{
    public partial class Create_New : Form
    {
        //Стандартный конструктор формы
        public Create_New()
        {
            InitializeComponent();
        }

        //Выбор типа болезни - открытие соответствующей вкладки
        private void create_tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (create_tabs.SelectedIndex == 0) 
            {
                this.image_tab.SelectedIndex = 0;
                check_textUpdate(comboBox_bacteria_name);
            }
            else if (create_tabs.SelectedIndex == 1)
            {
                this.image_tab.SelectedIndex = 1;
                check_textUpdate(comboBox_virus_name);
            }
            else if (create_tabs.SelectedIndex == 2)
            {
                this.image_tab.SelectedIndex = 2;
                check_textUpdate(comboBox_prion_name);
            }
        }

        //Выбор вероятности заражения и её отображение у бактерии
        private void trackBar_bacteria_infection_Scroll(object sender, EventArgs e)
        {
            this.bacteria_infection.Text = this.trackBar_bacteria_infection.Value.ToString();
        }

        //Выбор инкубационного периода и его отображение у бактерии
        private void trackBar_bacteria_incub_Scroll(object sender, EventArgs e)
        {
            this.bacteria_incub.Text = this.trackBar_bacteria_incub.Value.ToString();
            if (this.trackBar_bacteria_incub.Value == 1)
            {
                this.label2.Text = "день";
            }
            else if (this.trackBar_bacteria_incub.Value < 5 && this.trackBar_bacteria_incub.Value > 1)
            {
                this.label2.Text = "дня";
            }
            else
            {
                this.label2.Text = "дней";
            }
        }

        //Выбор периода болезни и его отображение у бактерии
        private void trackBar_bacteria_illness_Scroll(object sender, EventArgs e)
        {
            this.bacteria_illness.Text = this.trackBar_bacteria_illness.Value.ToString();
            if (this.trackBar_bacteria_illness.Value == 1)
            {
                this.label3.Text = "день";
            }
            else if (this.trackBar_bacteria_illness.Value < 5 && this.trackBar_bacteria_illness.Value > 1)
            {
                this.label3.Text = "дня";
            }
            else
            {
                this.label3.Text = "дней";
            }
        }

        //Выбор летальности и её отображение у бактерии
        private void trackBar_bacteria_death_Scroll(object sender, EventArgs e)
        {
            this.bacteria_death.Text = this.trackBar_bacteria_death.Value.ToString();
        }

        //Выбор вероятности заражения и её отображение у вируса
        private void trackBar_virus_infection_Scroll(object sender, EventArgs e)
        {
            this.virus_infection.Text = this.trackBar_virus_infection.Value.ToString();
        }

        //Выбор инкубационного периода и его отображение у вируса
        private void trackBar_virus_incub_Scroll(object sender, EventArgs e)
        {
            this.virus_incub.Text = this.trackBar_virus_incub.Value.ToString();
            if (this.trackBar_virus_incub.Value == 1)
            {
                this.day_virus_incub.Text = "день";
            }
            else if (this.trackBar_virus_illness.Value < 5 && this.trackBar_virus_illness.Value > 1)
            {
                this.day_virus_incub.Text = "дня";
            }
            else
            {
                this.day_virus_incub.Text = "дней";
            }
        }

        //Выбор периода болезни и его отображение у вируса
        private void trackBar_virus_illness_Scroll(object sender, EventArgs e)
        {
            this.virus_illness.Text = this.trackBar_virus_illness.Value.ToString();
            if (this.trackBar_virus_illness.Value == 1)
            {
                this.day_virus_illness.Text = "день";
            }
            else if (this.trackBar_virus_illness.Value < 5 && this.trackBar_virus_illness.Value > 1)
            {
                this.day_virus_illness.Text = "дня";
            }
            else
            {
                this.day_virus_illness.Text = "дней";
            }
        }

        //Выбор летальности и её отображение у вируса
        private void trackBar_virus_death_Scroll(object sender, EventArgs e)
        {
            this.virus_death.Text = this.trackBar_virus_death.Value.ToString();
        }

        //Выбор вероятности заражения и её отображение у приона
        private void trackBar_prion_infection_Scroll(object sender, EventArgs e)
        {
            this.prion_infection.Text = this.trackBar_prion_infection.Value.ToString();
        }

        //Выбор периода болезни и его отображение у приона
        private void trackBar_prion_illness_Scroll(object sender, EventArgs e)
        {
            this.prion_illness.Text = this.trackBar_prion_illness.Value.ToString(); 
            if (this.trackBar_prion_illness.Value % 10 == 1 && this.trackBar_prion_illness.Value % 100 != 11)
            {
                this.day_prion_illness.Text = "день";
            }
            else if (this.trackBar_prion_illness.Value % 10 > 1 && this.trackBar_prion_illness.Value % 10 < 5 && (this.trackBar_prion_illness.Value % 100 < 10 || this.trackBar_prion_illness.Value % 100 > 20))
            {
                this.day_prion_illness.Text = "дня";
            }
            else
            {
                this.day_prion_illness.Text = "дней";
            }
        }

        //Выбор летальности и её отображение у приона
        private void trackBar_prion_death_Scroll(object sender, EventArgs e)
        {
            this.prion_death.Text = this.trackBar_prion_death.Value.ToString();
        }

        //Метод проверки имени на пустоту и отображение кнопки "Создать"
        private void check_textUpdate(System.Windows.Forms.ComboBox name)
        {
            if (name.Text != "")
            {
                this.Create_Button.Visible = true;
            }
            else
            {
                this.Create_Button.Visible = false;
            }
        }

        //Обработка обновления текста имени бактерии
        private void comboBox_bacteria_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_bacteria_name);
        }

        //Обработка обновления текста имени вируса
        private void comboBox_virus_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_virus_name);
        }

        //Обработка обновления текста имени приона
        private void comboBox_prion_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_prion_name);
        }

        //Обработка обновления текста имени бактерии при выборе из предложенных
        private void comboBox_bacteria_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_bacteria_name);
        }

        //Обработка обновления текста имени вируса при выборе из предложенных
        private void comboBox_virus_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_virus_name);
        }

        //Обработка обновления текста имени приона при выборе из предложенных
        private void comboBox_prion_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_prion_name);
        }

        //Нажатие на кнопку "Создать", создание файла с информацией о вирусе
        private void Create_Button_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("dt.dt", false);
                if (create_tabs.SelectedIndex == 0)
                {
                    file.WriteLine("0");
                    file.WriteLine(this.comboBox_bacteria_name.Text);
                    file.WriteLine(this.bacteria_infection.Text);
                    file.WriteLine(this.bacteria_incub.Text);
                    file.WriteLine(this.bacteria_illness.Text);
                    file.WriteLine(this.bacteria_death.Text);
                }
                else if (create_tabs.SelectedIndex == 1)
                {
                    file.WriteLine("1");
                    file.WriteLine(this.comboBox_virus_name.Text);
                    file.WriteLine(this.virus_infection.Text);
                    file.WriteLine(this.virus_incub.Text);
                    file.WriteLine(this.virus_illness.Text);
                    file.WriteLine(this.virus_death.Text);
                }
                else if (create_tabs.SelectedIndex == 2)
                {
                    file.WriteLine("2");
                    file.WriteLine(this.comboBox_prion_name.Text);
                    file.WriteLine(this.prion_infection.Text);
                    file.WriteLine("0");
                    file.WriteLine(this.prion_illness.Text);
                    file.WriteLine(this.prion_death.Text);
                }
                file.Close();
                this.Close();
            }
            catch (Exception) 
            {
                MessageBox.Show("Ошибка создания", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (File.Exists("dt.dt"))
                {
                    File.Delete("dt.dt");
                }
                this.Close();
            }
        }

        //Закрытие формы, отображение главного меню
        private void Create_New_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        //Метод проверки введённого символа
        private void CheckChar(KeyPressEventArgs args)
        {
            Char ch = (Char)args.KeyChar;
            if (Char.IsLetterOrDigit(ch))
            {
                return;
            }
            else
            {
                args.Handled = true;
            }
        }

        //Ввод символа в имя бактерии
        private void comboBox_bacteria_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChar(e);
        }

        //Ввод символа в имя вируса
        private void comboBox_virus_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChar(e);
        }

        //Ввод символа в имя приона
        private void comboBox_prion_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChar(e);
        }

        //Отображение краткой справки о бактерии
        private void about_bacteria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Патогенные бактерии могут проявлять свою вредность разными способами:\n" +
                "некоторые из них выделяют токсины, разрушающие клетки,\n" +
                "другие способны проникать в клетки и размножаться в них, вызывая их гибель или трансформацию,\n" +
                "третьи могут образовывать биопленки или капсулы, которые защищают их от иммунной системы.\n" +
                "Доступна полная настройка параметров бактерии, с уменьшенным периодом болезни.\n" +
                "Мутация способна изменить вероятность заражения, период болезни или летальность.", "Бактерия", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Отображение краткой справки о вирусе
        private void about_virus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вирусы - это неклеточные инфекционные агенты,\n" +
                "которые могут размножаться только внутри клеток хозяев.\n" +
                "Время жизни вируса в клетке зависит от типа вируса, типа клетки и условий среды\n." +
                "Доступна полная настройка параметров вируса, с увеличенным периодом болезни.\n" +
                "Мутация способна изменить вероятность заражения, период болезни или летальность.", "Вирус", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Отображение краткой справки о прионе
        private void about_prion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Прион - это особый вид инфекционного агента, который не содержит нуклеиновых кислот,\n" +
                "а состоит только из белка. Прион способен изменять форму нормального клеточного белка\n" +
                "и превращать его в себе подобный. Таким образом, прион размножается внутри клетки,\n" +
                "вызывая её повреждение и гибель. Прионы устойчивы к многим физическим и химическим факторам\n" +
                "Прионы приводят к образованию пустот в мозговой ткани.\n" +
                "Болезни,вызванные прионами чаще всего неизлечимы и смертельны.\n" +
                "Особенностью приона является его очень долгое развитие (от 3-х месяцев до 3-х лет.\n" +
                "У приона нет инкубационного периода, его заразность очень мала, а летальность высока.\n" +
                "Эти факторы обуславливают ограниченность настройки параметров болезни.\n" +
                "Шанс на мутацию очень мал, однако она способна изменить все параметры болезни.", "Прион", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Всплывающая подсказка над кнопкой "О бактерии"
        private void about_bacteria_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(about_bacteria, "Краткая справка о бактериях");
            t.AutomaticDelay = 200;
            t.IsBalloon = true;
        }

        //Всплывающая подсказка над кнопкой "О вирусе"
        private void about_virus_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(about_virus, "Краткая справка о вирусах");
            t.AutomaticDelay = 200;
            t.IsBalloon = true;
        }

        //Всплывающая подсказка над кнопкой "О прионе"
        private void about_prion_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(about_prion, "Краткая справка о прионах");
            t.AutomaticDelay = 200;
            t.IsBalloon = true;
        }
    }
}

