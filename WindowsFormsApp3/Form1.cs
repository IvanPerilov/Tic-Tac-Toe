using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string checkTurn()
        {
            if (turn % 2 == 1)
                return "X";
            else
                return "O";
        }
        
        void changTurn()
        {
            turnPlayer.Text = checkTurn();
        }
        void win()
        {
            changMod = false;
            Turn.Text = "Победил игрок";
        }
        void checkingMainDiagonal()
        {
            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                win();
            }
        }
        void checkingSideDiagonal()
        {
            if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                win();
            }
        }
        void checkingFirstLine()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                win();
            }
        }
        
        void checkingSecondLine()
        {
            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                win();
            }
        }
        void checkingThirdLine()
        {
            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                win();
            }
        }
        void checkingFirstColumn()
        {
            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                win();
            }
        }
        void checkingSecondColumn()
        {
            if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                win();
            }
        }
        void checkingThirdColumn()
        {
            if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                win();
            }
        }
        
        bool changMod = true;
        int turn = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if(changMod)
            if(button1.Text=="")
            {
                button1.Text = checkTurn();
                checkingMainDiagonal();
                checkingFirstLine();
                checkingFirstColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (changMod)
                if (button2.Text == "")
                {
                    button2.Text = checkTurn();
                    checkingFirstLine();
                    checkingSecondColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (changMod)
                if (button3.Text == "")
                {
                    button3.Text = checkTurn();
                    checkingFirstLine();
                    checkingThirdColumn();
                    checkingSideDiagonal();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            if (changMod)
                if (button4.Text == "")
                {
                    button4.Text = checkTurn();
                    checkingSecondLine();
                    checkingFirstColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(changMod)
                if(button5.Text == "")
                {
                    button5.Text = checkTurn();
                    checkingSecondColumn();
                    checkingSecondLine();
                    checkingMainDiagonal();
                    if(changMod)
                    {
                        turn++;
                        changTurn();
                    }
                    
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(changMod)
                if(button6.Text == "")
                {
                    button6.Text = checkTurn();
                    checkingSecondLine();
                    checkingThirdColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(changMod)
                if(button7.Text == "")
                {
                    button7.Text = checkTurn();
                    checkingThirdLine();
                    checkingSideDiagonal();
                    checkingFirstColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(changMod)
                if(button8.Text == "")
                {
                    button8.Text = checkTurn();
                    checkingThirdLine();
                    checkingSecondColumn();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(changMod)
                if(button9.Text == "")
                {
                    button9.Text = checkTurn();
                    checkingThirdLine();
                    checkingThirdColumn();
                    checkingMainDiagonal();
                    if (changMod)
                    {
                        turn++;
                        changTurn();
                    }
                }
        }
        private void NGbutton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.BackColor = Color.White;
            button2.Text = "";
            button2.BackColor = Color.White;
            button3.Text = "";
            button3.BackColor = Color.White;
            button4.Text = "";
            button4.BackColor = Color.White;
            button5.Text = "";
            button5.BackColor = Color.White; 
            button6.Text = "";
            button6.BackColor = Color.White;
            button7.Text = "";
            button7.BackColor = Color.White;
            button8.Text = "";
            button8.BackColor = Color.White;
            button9.Text = "";
            button9.BackColor = Color.White;
            turn = 1;
            changTurn();
            changMod = true;
        }
    }
}
