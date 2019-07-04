namespace TennisKata_TDD
{
    partial class Scoreboard
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
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.textPlayer1 = new System.Windows.Forms.TextBox();
            this.textPlayer2 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.PanelScore1 = new System.Windows.Forms.Panel();
            this.PanelScore2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerAdd1 = new System.Windows.Forms.Button();
            this.PlayerAdd2 = new System.Windows.Forms.Button();
            this.PlayerName1 = new System.Windows.Forms.Label();
            this.PlayerName2 = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Button();
            this.ScoreResult2 = new System.Windows.Forms.Label();
            this.ScoreResult1 = new System.Windows.Forms.Label();
            this.PanelScore1.SuspendLayout();
            this.PanelScore2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(27, 26);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(86, 20);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player One";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(28, 65);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(85, 20);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player Two";
            // 
            // textPlayer1
            // 
            this.textPlayer1.Location = new System.Drawing.Point(119, 23);
            this.textPlayer1.Name = "textPlayer1";
            this.textPlayer1.Size = new System.Drawing.Size(152, 26);
            this.textPlayer1.TabIndex = 2;
            // 
            // textPlayer2
            // 
            this.textPlayer2.Location = new System.Drawing.Point(119, 62);
            this.textPlayer2.Name = "textPlayer2";
            this.textPlayer2.Size = new System.Drawing.Size(152, 26);
            this.textPlayer2.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(646, 19);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(91, 35);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // PanelScore1
            // 
            this.PanelScore1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelScore1.Controls.Add(this.ScoreResult1);
            this.PanelScore1.Location = new System.Drawing.Point(68, 151);
            this.PanelScore1.Name = "PanelScore1";
            this.PanelScore1.Size = new System.Drawing.Size(294, 240);
            this.PanelScore1.TabIndex = 5;
            // 
            // PanelScore2
            // 
            this.PanelScore2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelScore2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelScore2.Controls.Add(this.ScoreResult2);
            this.PanelScore2.Location = new System.Drawing.Point(443, 151);
            this.PanelScore2.Name = "PanelScore2";
            this.PanelScore2.Size = new System.Drawing.Size(294, 240);
            this.PanelScore2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(385, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // PlayerAdd1
            // 
            this.PlayerAdd1.Location = new System.Drawing.Point(277, 19);
            this.PlayerAdd1.Name = "PlayerAdd1";
            this.PlayerAdd1.Size = new System.Drawing.Size(69, 33);
            this.PlayerAdd1.TabIndex = 8;
            this.PlayerAdd1.Text = "Score!";
            this.PlayerAdd1.UseVisualStyleBackColor = true;
            this.PlayerAdd1.Click += new System.EventHandler(this.PlayerAdd1_Click);
            // 
            // PlayerAdd2
            // 
            this.PlayerAdd2.Location = new System.Drawing.Point(277, 59);
            this.PlayerAdd2.Name = "PlayerAdd2";
            this.PlayerAdd2.Size = new System.Drawing.Size(69, 33);
            this.PlayerAdd2.TabIndex = 9;
            this.PlayerAdd2.Text = "Score!";
            this.PlayerAdd2.UseVisualStyleBackColor = true;
            this.PlayerAdd2.Click += new System.EventHandler(this.PlayerAdd2_Click);
            // 
            // PlayerName1
            // 
            this.PlayerName1.AutoSize = true;
            this.PlayerName1.Location = new System.Drawing.Point(92, 119);
            this.PlayerName1.Name = "PlayerName1";
            this.PlayerName1.Size = new System.Drawing.Size(0, 20);
            this.PlayerName1.TabIndex = 10;
            // 
            // PlayerName2
            // 
            this.PlayerName2.AutoSize = true;
            this.PlayerName2.Location = new System.Drawing.Point(468, 118);
            this.PlayerName2.Name = "PlayerName2";
            this.PlayerName2.Size = new System.Drawing.Size(0, 20);
            this.PlayerName2.TabIndex = 11;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(646, 65);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(91, 35);
            this.End.TabIndex = 12;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // ScoreResult2
            // 
            this.ScoreResult2.AutoSize = true;
            this.ScoreResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreResult2.Location = new System.Drawing.Point(108, 78);
            this.ScoreResult2.Name = "ScoreResult2";
            this.ScoreResult2.Size = new System.Drawing.Size(68, 64);
            this.ScoreResult2.TabIndex = 0;
            this.ScoreResult2.Text = "--";
            // 
            // ScoreResult1
            // 
            this.ScoreResult1.AutoSize = true;
            this.ScoreResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreResult1.Location = new System.Drawing.Point(88, 78);
            this.ScoreResult1.Name = "ScoreResult1";
            this.ScoreResult1.Size = new System.Drawing.Size(68, 64);
            this.ScoreResult1.TabIndex = 1;
            this.ScoreResult1.Text = "--";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.End);
            this.Controls.Add(this.PlayerName2);
            this.Controls.Add(this.PlayerName1);
            this.Controls.Add(this.PlayerAdd2);
            this.Controls.Add(this.PlayerAdd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelScore2);
            this.Controls.Add(this.PanelScore1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textPlayer2);
            this.Controls.Add(this.textPlayer1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelScore1.ResumeLayout(false);
            this.PanelScore1.PerformLayout();
            this.PanelScore2.ResumeLayout(false);
            this.PanelScore2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.TextBox textPlayer1;
        private System.Windows.Forms.TextBox textPlayer2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel PanelScore1;
        private System.Windows.Forms.Panel PanelScore2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayerAdd1;
        private System.Windows.Forms.Button PlayerAdd2;
        private System.Windows.Forms.Label PlayerName1;
        private System.Windows.Forms.Label PlayerName2;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label ScoreResult1;
        private System.Windows.Forms.Label ScoreResult2;
    }
}

