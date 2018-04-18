using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        bool against_computer;
       

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayersNames(p1.Text, p2.Text);
            this.Close();
        }

        private void ke(object sender, EventArgs e)
        {
            /*if (p2.Text.ToUpper() == "Komputer")
                against_computer = true;
            else
                against_computer = false;*/
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();
        }
    }
}
