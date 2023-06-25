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
        public Imitation()
        {
            InitializeComponent();
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
