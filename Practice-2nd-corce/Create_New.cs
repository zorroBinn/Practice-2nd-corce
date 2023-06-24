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
    public partial class Create_New : Form
    {
        public Create_New()
        {
            InitializeComponent();
        }

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

        private void trackBar_bacteria_infection_Scroll(object sender, EventArgs e)
        {
            this.bacteria_infection.Text = this.trackBar_bacteria_infection.Value.ToString();
        }

        private void trackBar_bacteria_incub_Scroll(object sender, EventArgs e)
        {
            this.bacteria_incub.Text = this.trackBar_bacteria_incub.Value.ToString();
            if (this.trackBar_bacteria_incub.Value > 1)
            {
                this.label2.Text = "дней";
            }
            else
            {
                this.label2.Text = "день";
            }
        }

        private void trackBar_bacteria_illness_Scroll(object sender, EventArgs e)
        {
            this.bacteria_illness.Text = this.trackBar_bacteria_illness.Value.ToString();
            if (this.trackBar_bacteria_illness.Value > 1)
            {
                this.label3.Text = "дней";
            }
            else
            {
                this.label3.Text = "день";
            }
        }

        private void trackBar_bacteria_death_Scroll(object sender, EventArgs e)
        {
            this.bacteria_death.Text = this.trackBar_bacteria_death.Value.ToString();
        }

        private void trackBar_virus_infection_Scroll(object sender, EventArgs e)
        {
            this.virus_infection.Text = this.trackBar_virus_infection.Value.ToString();
        }

        private void trackBar_virus_incub_Scroll(object sender, EventArgs e)
        {
            this.virus_incub.Text = this.trackBar_virus_incub.Value.ToString();
            if (this.trackBar_virus_incub.Value > 1)
            {
                this.day_virus_incub.Text = "дней";
            }
            else
            {
                this.day_virus_incub.Text = "день";
            }
        }

        private void trackBar_virus_illness_Scroll(object sender, EventArgs e)
        {
            this.virus_illness.Text = this.trackBar_virus_illness.Value.ToString();
            if (this.trackBar_virus_illness.Value > 1)
            {
                this.day_virus_illness.Text = "дней";
            }
            else
            {
                this.day_virus_illness.Text = "день";
            }
        }

        private void trackBar_virus_death_Scroll(object sender, EventArgs e)
        {
            this.virus_death.Text = this.trackBar_virus_death.Value.ToString();
        }

        private void trackBar_prion_infection_Scroll(object sender, EventArgs e)
        {
            this.prion_infection.Text = this.trackBar_prion_infection.Value.ToString();
        }

        private void trackBar_prion_illness_Scroll(object sender, EventArgs e)
        {
            this.prion_illness.Text = this.trackBar_prion_illness.Value.ToString();
            if (this.trackBar_prion_illness.Value % 100 != 1)
            {
                this.day_prion_illness.Text = "дней";
            }
            else
            {
                this.day_prion_illness.Text = "день";
            }
        }

        private void trackBar_prion_death_Scroll(object sender, EventArgs e)
        {
            this.prion_death.Text = this.trackBar_prion_death.Value.ToString();
        }

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

        private void comboBox_bacteria_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_bacteria_name);
        }

        private void comboBox_virus_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_virus_name);
        }

        private void comboBox_prion_name_TextUpdate(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_prion_name);
        }

        private void comboBox_bacteria_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_bacteria_name);
        }

        private void comboBox_virus_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_virus_name);
        }

        private void comboBox_prion_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_textUpdate(comboBox_prion_name);
        }

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
                this.Close();
            }
        }

        private void Create_New_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("dt.dt") == false)
            {
                this.Owner.Show();
            }
        }
    }
}
