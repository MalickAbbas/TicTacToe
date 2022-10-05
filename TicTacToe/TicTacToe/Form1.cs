using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player = false;
        string userone = "X";
        string usertwo = "O";
        string winner = "";
        int playerone = 0;
        int playertwo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void newGame()
        {
            this.winner = "";
            this.playerone = 0;
            this.playertwo = 0;
            label1.Text = "Winner :";
            label2.Text = "Player 1 :";
            label3.Text = "player 2 :";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void tictactoe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (player)
            {
                btn.Text = usertwo;
            }
            else
            {
                btn.Text = userone;
            }
            player = !player;
            btn.Click -= new EventHandler(tictactoe_Click);
            checkforwinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
            button1.Click += new EventHandler(tictactoe_Click);
            button2.Click += new EventHandler(tictactoe_Click);
            button3.Click += new EventHandler(tictactoe_Click);
            button4.Click += new EventHandler(tictactoe_Click);
            button5.Click += new EventHandler(tictactoe_Click);
            button6.Click += new EventHandler(tictactoe_Click);
            button7.Click += new EventHandler(tictactoe_Click);
            button8.Click += new EventHandler(tictactoe_Click);
            button9.Click += new EventHandler(tictactoe_Click);
            label1.Text="Winner:" + winner;
            label2.Text = "Player 1 : " + playerone.ToString();
            label3.Text = "Player 2 : " + playertwo.ToString();

        }
        public void reset()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            
        }
        public void stop()
        {
            button1.Click -= new EventHandler(tictactoe_Click);
            button2.Click -= new EventHandler(tictactoe_Click);
            button3.Click -= new EventHandler(tictactoe_Click);
            button4.Click -= new EventHandler(tictactoe_Click);
            button5.Click -= new EventHandler(tictactoe_Click);
            button6.Click -= new EventHandler(tictactoe_Click);
            button7.Click -= new EventHandler(tictactoe_Click);
            button8.Click -= new EventHandler(tictactoe_Click);
            button9.Click -= new EventHandler(tictactoe_Click);
        }
        public void checkforwinner()
        {
            if(button1.Text.Equals(button2.Text) && button2.Text.Equals(button3.Text))
            {
                if(button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player one";
                        playerone += 1;
                        

                    }
                }
                else if(button1.Text=="O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                   // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }

            else if (button4.Text.Equals(button5.Text) && button5.Text.Equals(button6.Text))
            {
                if (button4.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button4.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }



            else if (button7.Text.Equals(button8.Text) && button8.Text.Equals(button9.Text))
            {
                if (button7.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button7.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }

            else if (button1.Text.Equals(button4.Text) && button4.Text.Equals(button7.Text))
            {
                if (button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button1.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }


            else if (button2.Text.Equals(button5.Text) && button5.Text.Equals(button8.Text))
            {
                if (button2.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button2.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }

            else if (button3.Text.Equals(button6.Text) && button6.Text.Equals(button9.Text))
            {
                if (button3.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button3.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }


            else if (button1.Text.Equals(button5.Text) && button5.Text.Equals(button9.Text))
            {
                if (button1.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button1.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        //reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }

            if (button3.Text.Equals(button5.Text) && button5.Text.Equals(button7.Text))
            {
                if (button3.Text == "X")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player one wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player one";
                        playerone += 1;

                    }
                }
                else if (button3.Text == "O")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // MessageBox.Show("Player one wins", "Winner");
                    DialogResult result = MessageBox.Show("Player Two wins", "Winner", buttons);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        // reset();
                        stop();
                        winner = "player two";
                        playertwo += 1;
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
