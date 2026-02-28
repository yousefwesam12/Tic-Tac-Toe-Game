using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        enum enWinner { Player1, Player2, Draw, None };
        short Counter = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 398, 291, 871, 291);
            e.Graphics.DrawLine(pen, 400, 439, 874, 439);

            // Vertical
            e.Graphics.DrawLine(pen, 536, 159, 536, 561);
            e.Graphics.DrawLine(pen, 723, 161, 723, 561);
        }
        public Form1()
        {
            InitializeComponent();
        } 
        void UpdateStatusOfTheGame(PictureBox PBox)
        {

            if (PBox.Tag.ToString() != "?")
            {
                return;
            }

            if (currentPlayerLabel.Text == "Player 1")
            {
                PBox.Image = Resources.X;
                PBox.Tag = "X";
                currentPlayerLabel.Text = "Player 2";
            }
            else
            {
                PBox.Image = Resources.O;
                PBox.Tag = "O";
                currentPlayerLabel.Text = "Player 1";
            }
            Counter++;
            UpdateWinnerStatus();
        }
        void ChangePictureBoxColorToGreen(PictureBox pBox1, PictureBox pBox2, PictureBox pBox3)
        {
            pBox1.BackColor = Color.DarkGreen;
            pBox2.BackColor = Color.DarkGreen;
            pBox3.BackColor = Color.DarkGreen;
        }
        void ResetPictureBoxColor()
        {
            pBox1.BackColor = Color.FromArgb(47, 47, 47);
            pBox2.BackColor = Color.FromArgb(47, 47, 47);
            pBox3.BackColor = Color.FromArgb(47, 47, 47);
            pBox4.BackColor = Color.FromArgb(47, 47, 47);
            pBox5.BackColor = Color.FromArgb(47, 47, 47);
            pBox6.BackColor = Color.FromArgb(47, 47, 47);
            pBox7.BackColor = Color.FromArgb(47, 47, 47);
            pBox7.BackColor = Color.FromArgb(47, 47, 47);
            pBox9.BackColor = Color.FromArgb(47, 47, 47);
        }      
        bool IsTheSameTag(PictureBox pBox1, PictureBox pBox2, PictureBox pBox3)
        {
           if(pBox1.Tag.ToString() == "?" || pBox2.Tag.ToString() == "?"||pBox3.Tag.ToString()=="?")
           {
                return false;
           }
            if(pBox1.Tag.ToString() != pBox2.Tag.ToString())
            {
                return false;
            }
            if(pBox2.Tag.ToString() != pBox3.Tag.ToString())
            {
                return false;
            }
            return true;
        }
        private enWinner IsThereVerticalWinner()
        {
            if(IsTheSameTag(pBox1,pBox4,pBox7))
            {
                if (pBox1.Tag.ToString() == "X")
                {

                    ChangePictureBoxColorToGreen(pBox1, pBox4, pBox7);
                    return enWinner.Player1;
                }
                else
                {
                    ChangePictureBoxColorToGreen(pBox1, pBox4, pBox7);
                    return enWinner.Player2;

                }      
            }

            else if(IsTheSameTag(pBox2,pBox5,pBox8))
            {
                if (pBox2.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox2, pBox5, pBox8);
                    return enWinner.Player1;
                }
                else
                {
                    ChangePictureBoxColorToGreen(pBox2, pBox5, pBox8);
                    return enWinner.Player2;
                }
            }
            else if(IsTheSameTag(pBox3,pBox6,pBox9))
            {
                if (pBox3.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox3, pBox6, pBox9);
                    return enWinner.Player1;
                }
                else
                {
                    ChangePictureBoxColorToGreen(pBox3, pBox6, pBox9);
                    return enWinner.Player2;
                }
            }

            return enWinner.None;
        }   
        private enWinner IsThereHorizontalWinner()
        {
            if (IsTheSameTag(pBox1,pBox2,pBox3))
            {
                if (pBox1.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox1, pBox2, pBox3);
                    return enWinner.Player1;
                }
                    ChangePictureBoxColorToGreen(pBox1, pBox2, pBox3);
                    return enWinner.Player2;

            }
            if (IsTheSameTag(pBox4,pBox5,pBox6))
            {
                if (pBox4.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox4, pBox5, pBox6);
                    return enWinner.Player1;
                }
                    ChangePictureBoxColorToGreen(pBox4, pBox5, pBox6);
                    return enWinner.Player2;
  
            }
            if (IsTheSameTag(pBox7,pBox8,pBox9))
            {
                if (pBox7.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox7, pBox8, pBox9);
                    return enWinner.Player1;
                }

                    ChangePictureBoxColorToGreen(pBox7, pBox8, pBox9);
                    return enWinner.Player2;
                    
            }
            return enWinner.None;
        }
        private enWinner IsThereDiagonalWinner()
        {
            if (IsTheSameTag(pBox1,pBox5,pBox9))
            {
                if (pBox1.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox1, pBox5, pBox9);
                    return enWinner.Player1;
                }
                    ChangePictureBoxColorToGreen(pBox1, pBox5, pBox9);
                    return enWinner.Player2;     
            }
            if (IsTheSameTag(pBox3,pBox5,pBox7))
            {
                if (pBox3.Tag.ToString() == "X")
                {
                    ChangePictureBoxColorToGreen(pBox3, pBox5, pBox7);
                    return enWinner.Player1;
                }
                    ChangePictureBoxColorToGreen(pBox3, pBox5, pBox7);
                    return enWinner.Player2;                  
            }
            return enWinner.None;
        }  
        enWinner WhoWon()
        {
               enWinner Winner = IsThereVerticalWinner();

                if (Winner != enWinner.None)
                {
                    return Winner;
                }

                Winner = IsThereHorizontalWinner();

                if (Winner != enWinner.None)
                {
                    return Winner;
                }
                Winner = IsThereDiagonalWinner();

                if (Winner != enWinner.None)
                {
                    return Winner;
                }

            return enWinner.None;
        } 
        void UpdateWinnerStatus()
        {
           
            enWinner Winner = WhoWon();

            // I Check if there is a winner, if there is, I change the label and show the message box..
            if (Winner != enWinner.None)
            {
                ChangeWinnerLabel(Winner);
                ShowGameOverMessageBox();
                Reset();
                return;
            }

            // At Here, No Winner, and all the boxes are filled, so it's a draw
            if (Counter == 9)
            {
                ChangeWinnerLabel(enWinner.Draw);
                ShowGameOverMessageBox();
                Reset();
            }
        }
        void ShowGameOverMessageBox()
        {
            MessageBox.Show("Game Over","GameOver",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void ChangeWinnerLabel(enWinner winner)
        {
            switch (winner)
            {
                case enWinner.Player1:
                    winnerLabel.Location = new Point(80, 360);
                    winnerLabel.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    winnerLabel.Location = new Point(80, 360);
                    winnerLabel.Text = "Player 2";
                    break;

                case enWinner.Draw:
                    winnerLabel.Location = new Point(100,360);
                    winnerLabel.Text = "Draw";
                    break;

                case enWinner.None:
                    break;

            }
        }       
        private void PictureBoxClicked(object sender, EventArgs e)
        {
            UpdateStatusOfTheGame((PictureBox)sender);
        }
        private void ResetTags()
        {
            pBox1.Tag = "?";
            pBox2.Tag = "?";
            pBox3.Tag = "?";
            pBox4.Tag = "?";
            pBox5.Tag = "?";
            pBox6.Tag = "?";
            pBox7.Tag = "?";
            pBox8.Tag = "?";
            pBox9.Tag = "?";
        }     
        private void ResetImagesToQuestionMark()
        {
            pBox1.Image = Resources.QuestionMark;
            pBox2.Image = Resources.QuestionMark;
            pBox3.Image = Resources.QuestionMark;
            pBox4.Image = Resources.QuestionMark;
            pBox5.Image = Resources.QuestionMark;
            pBox6.Image = Resources.QuestionMark;
            pBox7.Image = Resources.QuestionMark;
            pBox8.Image = Resources.QuestionMark;
            pBox9.Image = Resources.QuestionMark;
        }
        private void Reset()
        {
            ResetPictureBoxColor();
            ResetTags();
            ResetImagesToQuestionMark();
            winnerLabel.Location = new Point(55, 360);
            currentPlayerLabel.Text = "Player 1";
            winnerLabel.Text = "In Progress";
            Counter = 0;
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
