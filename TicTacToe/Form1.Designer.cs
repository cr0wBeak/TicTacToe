namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnB3 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            btnC3 = new Button();
            btnC2 = new Button();
            btnC1 = new Button();
            lblTitle = new Label();
            btnResetGame = new Button();
            lblTurn = new Label();
            SuspendLayout();
            // 
            // btnA1
            // 
            btnA1.Location = new Point(294, 319);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(70, 70);
            btnA1.TabIndex = 14;
            btnA1.UseVisualStyleBackColor = true;
            btnA1.Click += PlayerMarkCell;
            // 
            // btnA2
            // 
            btnA2.Location = new Point(294, 243);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(70, 70);
            btnA2.TabIndex = 15;
            btnA2.UseVisualStyleBackColor = true;
            btnA2.Click += PlayerMarkCell;
            // 
            // btnA3
            // 
            btnA3.Location = new Point(294, 167);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(70, 70);
            btnA3.TabIndex = 16;
            btnA3.UseVisualStyleBackColor = true;
            btnA3.Click += PlayerMarkCell;
            // 
            // btnB3
            // 
            btnB3.Location = new Point(370, 167);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(70, 70);
            btnB3.TabIndex = 19;
            btnB3.UseVisualStyleBackColor = true;
            btnB3.Click += PlayerMarkCell;
            // 
            // btnB2
            // 
            btnB2.Location = new Point(370, 243);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(70, 70);
            btnB2.TabIndex = 18;
            btnB2.UseVisualStyleBackColor = true;
            btnB2.Click += PlayerMarkCell;
            // 
            // btnB1
            // 
            btnB1.Location = new Point(370, 319);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(70, 70);
            btnB1.TabIndex = 17;
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += PlayerMarkCell;
            // 
            // btnC3
            // 
            btnC3.Location = new Point(446, 167);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(70, 70);
            btnC3.TabIndex = 22;
            btnC3.UseVisualStyleBackColor = true;
            btnC3.Click += PlayerMarkCell;
            // 
            // btnC2
            // 
            btnC2.Location = new Point(446, 243);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(70, 70);
            btnC2.TabIndex = 21;
            btnC2.UseVisualStyleBackColor = true;
            btnC2.Click += PlayerMarkCell;
            // 
            // btnC1
            // 
            btnC1.Location = new Point(446, 319);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(70, 70);
            btnC1.TabIndex = 20;
            btnC1.UseVisualStyleBackColor = true;
            btnC1.Click += PlayerMarkCell;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(308, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 48);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Tic Tac Toe";
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(352, 404);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(112, 34);
            btnResetGame.TabIndex = 24;
            btnResetGame.Text = "Reset";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += ResetGameBoard;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(339, 112);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(130, 25);
            lblTurn.TabIndex = 25;
            lblTurn.Text = "Current Turn: X";
            lblTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTurn);
            Controls.Add(btnResetGame);
            Controls.Add(lblTitle);
            Controls.Add(btnC3);
            Controls.Add(btnC2);
            Controls.Add(btnC1);
            Controls.Add(btnB3);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(btnA3);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            Name = "Form1";
            Text = "TicTacToe.exe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnB3;
        private Button btnB2;
        private Button btnB1;
        private Button btnC3;
        private Button btnC2;
        private Button btnC1;
        private Label lblTitle;
        private Button btnResetGame;
        private Label lblTurn;
    }
}
