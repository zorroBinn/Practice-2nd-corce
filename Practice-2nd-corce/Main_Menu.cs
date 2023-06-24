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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Start_Button_Click(object sender, EventArgs e)
        {
            Create_New create = new Create_New();
            create.Owner = this;
            create.Show();
            this.Hide();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(File.Exists("dt.dt") == true)
            {
                File.Delete("dt.dt");
            }
        }
    }
}
