/* TO DO
 * add a win/lose check
 * add a way to update lblTurn.Text to state who won
 */

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // make the window form
        }

        //declare variables
        bool PlayerTurn = false; // true = O, false = X. Stored as bool to take only 2 bits.

        // mark cell as X or O
        private void PlayerMarkCell(object sender, EventArgs e)
        {
            // define the cell to be marked as a button, to save on lines of code and prevent redundancy
            Button markingCell = sender as Button; // define the cell to be marked as the button that was pressed

            if (markingCell.Text == "") // check if cell is blank
            {
                switch (PlayerTurn) // changes what the cell is filled with
                {
                    case true: // player O
                        markingCell.Text = "O"; // fill cell with O
                        PlayerTurn = false; // switch turn to player X
                        lblTurn.Text = "Current Turn: X"; // update label
                        break; // end switch statement
                    case false: // player X
                        markingCell.Text = "X"; // fill cell with O
                        PlayerTurn = true; // switch turn to O
                        lblTurn.Text = "Current Turn: O"; // update label
                        break; // end switch statement
                }
            }
        }

        private void ResetGameBoard(object sender, EventArgs e)
        {
            // erase everything lol
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";
            PlayerTurn = false; // make it X's turn
            lblTurn.Text = "Current Turn: X"; // update label
        }
    }
}