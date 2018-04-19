using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace tictactoe
{

    public partial class Form1 : Form
    {
        public bool against_computer = false;
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }      

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void oGrzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jacek 2018", "Informacje");
            Process.Start("https://www.linkedin.com/in/jacek-flak/");       
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                there_is_a_winner = true;

            if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
                there_is_a_winner = true;

            if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;

            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                
                disableButtons();
                String winner = "";

                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                { 
                winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }              
                MessageBox.Show(winner + " wygrał/a!", "Brawo!");

                clear_buttons();

            }
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    turn = true;
                    turn_count = 0;
                    foreach (Component c in Controls)
                    {
                        try
                        {
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.Text = "";
                        }
                        catch { }
                    }
                    MessageBox.Show("Nikt nie wygrał!", "Remis!");
                }
            }
        }
        private void disableButtons()

        {
            try {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
               }
            }
            catch { }
            }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_buttons();
        }

        private void jakGraćToolStripMenuItem_Click(object sender, EventArgs e)
        {          
                Process.Start("https://pl.wikipedia.org/wiki/K%C3%B3%C5%82ko_i_krzy%C5%BCyk");           
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                
                    b.Text = "X";
                else
                b.Text = "O";
                }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void zresetujWynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";            
        }

        private void clear_buttons()
        {
            turn = true;
            turn_count = 0;
            foreach (Component c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}