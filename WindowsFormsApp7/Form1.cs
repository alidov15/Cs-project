using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            StartNewGame();
        }

        private void StartNewGame()
        {
            numberToGuess = random.Next(1, 1001);
            this.BackColor = SystemColors.Control;
            textBoxGuess.Enabled = true;
            textBoxGuess.Text = "I have a number between 1 and 1000--can you guess my number? Please enter your first guess.";
            textBoxGuess.Enabled = true;
            textBoxGuess.Text = ""; // Clear previous input
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxGuess.Text, out int guess))
            {
                if (guess < numberToGuess)
                {
                    textBoxGuess.Text = "Too Low";
                    this.BackColor = Color.Blue;
                }
                else if (guess > numberToGuess)
                {
                    textBoxGuess.Text = "Too High";
                    this.BackColor = Color.Blue;
                }
                else
                {
                    MessageBox.Show("Correct!", "Congratulations");
                    this.BackColor = Color.Green;
                    textBoxGuess.Enabled = false; // Disable the TextBox after correct guess
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input");
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
