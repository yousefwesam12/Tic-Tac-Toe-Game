using System.Drawing;

namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox5 = new System.Windows.Forms.PictureBox();
            this.pBox6 = new System.Windows.Forms.PictureBox();
            this.pBox7 = new System.Windows.Forms.PictureBox();
            this.pBox8 = new System.Windows.Forms.PictureBox();
            this.pBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(206)))));
            this.lblHeader.Location = new System.Drawing.Point(357, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(589, 94);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tic-Tac-Toe Game";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurn.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(206)))));
            this.lblTurn.Location = new System.Drawing.Point(112, 128);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(115, 58);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.currentPlayerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.currentPlayerLabel.Location = new System.Drawing.Point(79, 186);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(185, 62);
            this.currentPlayerLabel.TabIndex = 2;
            this.currentPlayerLabel.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(80, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Winner";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.winnerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winnerLabel.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(55, 360);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(245, 58);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(164)))));
            this.btnRestartGame.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Black;
            this.btnRestartGame.Location = new System.Drawing.Point(42, 474);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(271, 95);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pBox1
            // 
            this.pBox1.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox1.Location = new System.Drawing.Point(382, 159);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(132, 111);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 6;
            this.pBox1.TabStop = false;
            this.pBox1.Tag = "?";
            this.pBox1.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox2
            // 
            this.pBox2.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox2.Location = new System.Drawing.Point(563, 159);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(132, 111);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox2.TabIndex = 7;
            this.pBox2.TabStop = false;
            this.pBox2.Tag = "?";
            this.pBox2.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox3
            // 
            this.pBox3.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox3.Location = new System.Drawing.Point(735, 159);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(132, 111);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox3.TabIndex = 8;
            this.pBox3.TabStop = false;
            this.pBox3.Tag = "?";
            this.pBox3.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox4
            // 
            this.pBox4.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox4.Location = new System.Drawing.Point(382, 308);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(132, 111);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox4.TabIndex = 9;
            this.pBox4.TabStop = false;
            this.pBox4.Tag = "?";
            this.pBox4.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox5
            // 
            this.pBox5.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox5.Location = new System.Drawing.Point(563, 308);
            this.pBox5.Name = "pBox5";
            this.pBox5.Size = new System.Drawing.Size(132, 111);
            this.pBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox5.TabIndex = 10;
            this.pBox5.TabStop = false;
            this.pBox5.Tag = "?";
            this.pBox5.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox6
            // 
            this.pBox6.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox6.Location = new System.Drawing.Point(735, 308);
            this.pBox6.Name = "pBox6";
            this.pBox6.Size = new System.Drawing.Size(132, 111);
            this.pBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox6.TabIndex = 11;
            this.pBox6.TabStop = false;
            this.pBox6.Tag = "?";
            this.pBox6.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox7
            // 
            this.pBox7.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox7.Location = new System.Drawing.Point(382, 456);
            this.pBox7.Name = "pBox7";
            this.pBox7.Size = new System.Drawing.Size(132, 111);
            this.pBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox7.TabIndex = 12;
            this.pBox7.TabStop = false;
            this.pBox7.Tag = "?";
            this.pBox7.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox8
            // 
            this.pBox8.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox8.Location = new System.Drawing.Point(563, 456);
            this.pBox8.Name = "pBox8";
            this.pBox8.Size = new System.Drawing.Size(132, 111);
            this.pBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox8.TabIndex = 13;
            this.pBox8.TabStop = false;
            this.pBox8.Tag = "?";
            this.pBox8.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // pBox9
            // 
            this.pBox9.Image = global::Tic_Tac_Toe.Properties.Resources.QuestionMark;
            this.pBox9.Location = new System.Drawing.Point(735, 456);
            this.pBox9.Name = "pBox9";
            this.pBox9.Size = new System.Drawing.Size(132, 111);
            this.pBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox9.TabIndex = 14;
            this.pBox9.TabStop = false;
            this.pBox9.Tag = "?";
            this.pBox9.Click += new System.EventHandler(this.PictureBoxClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1172, 626);
            this.Controls.Add(this.pBox9);
            this.Controls.Add(this.pBox8);
            this.Controls.Add(this.pBox7);
            this.Controls.Add(this.pBox6);
            this.Controls.Add(this.pBox5);
            this.Controls.Add(this.pBox4);
            this.Controls.Add(this.pBox3);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox5;
        private System.Windows.Forms.PictureBox pBox6;
        private System.Windows.Forms.PictureBox pBox7;
        private System.Windows.Forms.PictureBox pBox8;
        private System.Windows.Forms.PictureBox pBox9;
    }
}

