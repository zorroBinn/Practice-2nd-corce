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
        private string name;
        private int type;
        private int infected;
        private int incub;
        private int illness;
        private int death;

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
    }
}
