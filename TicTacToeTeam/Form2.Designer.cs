namespace TicTacToeTeam
{
    partial class Form2
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
            this.winnerLabel = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.scoreXLabel = new System.Windows.Forms.Label();
            this.scoreOLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(12, 29);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(122, 38);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "Winner";
            this.winnerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(67, 115);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(107, 33);
            this.playerOneLabel.TabIndex = 1;
            this.playerOneLabel.Text = "Winner";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(246, 116);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(83, 33);
            this.playerTwoLabel.TabIndex = 2;
            this.playerTwoLabel.Text = "Loser";
            // 
            // okayButton
            // 
            this.okayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okayButton.ForeColor = System.Drawing.Color.White;
            this.okayButton.Location = new System.Drawing.Point(286, 256);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(97, 42);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = false;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // scoreXLabel
            // 
            this.scoreXLabel.AutoSize = true;
            this.scoreXLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreXLabel.Location = new System.Drawing.Point(74, 168);
            this.scoreXLabel.Name = "scoreXLabel";
            this.scoreXLabel.Size = new System.Drawing.Size(96, 33);
            this.scoreXLabel.TabIndex = 4;
            this.scoreXLabel.Text = "scoreX";
            // 
            // scoreOLabel
            // 
            this.scoreOLabel.AutoSize = true;
            this.scoreOLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOLabel.Location = new System.Drawing.Point(246, 169);
            this.scoreOLabel.Name = "scoreOLabel";
            this.scoreOLabel.Size = new System.Drawing.Size(98, 33);
            this.scoreOLabel.TabIndex = 5;
            this.scoreOLabel.Text = "scoreO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(202, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 129);
            this.panel1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(426, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scoreOLabel);
            this.Controls.Add(this.scoreXLabel);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.winnerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We have a winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label scoreXLabel;
        private System.Windows.Forms.Label scoreOLabel;
        private System.Windows.Forms.Panel panel1;
    }
}