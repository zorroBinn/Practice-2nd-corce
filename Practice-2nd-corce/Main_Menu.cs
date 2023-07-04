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
    public partial class Main_Menu : Form //Главное меню
    {
        //Стандартный конструктор формы
        public Main_Menu()
        {
            InitializeComponent();
        }

        //Нажатие на кнопку старт, открытие формы создания микроорганизма
        private void Main_Menu_Start_Button_Click(object sender, EventArgs e)
        {
            Create_New create = new Create_New();
            create.Owner = this;
            create.Show();
            this.Hide();
        }

        //Действие при закритии формы
        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(File.Exists("dt.dt") == true)
            {
                File.Delete("dt.dt");
            }
        }

        //При отображении формы, проверка созданного файла с болезнью, и перехад на форму имитации
        private void Main_Menu_Activated(object sender, EventArgs e)
        {
            if (File.Exists("dt.dt") == true)
            {
                Imitation imitation = new Imitation();
                imitation.Owner = this;
                imitation.Show();
                this.Hide();
            }
        }
    }
}
