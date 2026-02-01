using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostAnythingApp
{
    public partial class TicTacToe : Form
    {
        private int PlayerTurn = 1;
        bool[] Values = new bool[10];
        int counter = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button1, PlayerTurn, 1);
        }
        private void ChangeSymbol(Button Square, int CurrentPlayer, int ButtonNumber)
        {
            if (Square.Text == "")
            {
                counter++;
                if (CurrentPlayer == 1)
                {
                    Square.Text = "X";
                    Values[ButtonNumber] = true;
                }
                else
                {
                    Square.Text = "O";
                    Values[ButtonNumber] = false;
                }
                HaveTurn();
                if (counter == 9)
                {
                    MessageBox.Show("It's a draw!", "Game Over");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBox.Show("Do you want to play again?", "Play Again?", buttons);
                    TicTacToe NewGame = new TicTacToe();
                    NewGame.Show();
                    this.Hide();
                }
            }
            else
            {

            }
        }

        private void HaveTurn()
        {
            if (PlayerTurn == 1)
            {
                label1.Text = "Player 2's Turn (O)";
                PlayerTurn = 2;
            }
            else
            {
                PlayerTurn = 1;
                label1.Text = "Player 1's Turn (X)";
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            ChangeSymbol(button2, PlayerTurn, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button3, PlayerTurn, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button4, PlayerTurn, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button5, PlayerTurn, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button6, PlayerTurn, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button7, PlayerTurn, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button8, PlayerTurn, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeSymbol(button9, PlayerTurn, 9);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
