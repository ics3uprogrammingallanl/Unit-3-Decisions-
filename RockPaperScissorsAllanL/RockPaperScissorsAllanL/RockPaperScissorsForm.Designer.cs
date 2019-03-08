namespace RockPaperScissorsAllanL
{
    partial class frmRockPaperScissors
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.grbComp = new System.Windows.Forms.GroupBox();
            this.radCompRock = new System.Windows.Forms.RadioButton();
            this.radCompPaper = new System.Windows.Forms.RadioButton();
            this.radCompScissors = new System.Windows.Forms.RadioButton();
            this.lblWin = new System.Windows.Forms.Label();
            this.grbUser.SuspendLayout();
            this.grbComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(135, 472);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(58, 30);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 1;
            this.radUserRock.TabStop = true;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.radUserScissors);
            this.grbUser.Controls.Add(this.radUserPaper);
            this.grbUser.Controls.Add(this.radUserRock);
            this.grbUser.Location = new System.Drawing.Point(67, 65);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(200, 178);
            this.grbUser.TabIndex = 2;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "User";
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Location = new System.Drawing.Point(58, 125);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(64, 17);
            this.radUserScissors.TabIndex = 3;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Location = new System.Drawing.Point(58, 77);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(53, 17);
            this.radUserPaper.TabIndex = 2;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            this.radUserPaper.CheckedChanged += new System.EventHandler(this.radUserPaper_CheckedChanged);
            // 
            // grbComp
            // 
            this.grbComp.Controls.Add(this.radCompRock);
            this.grbComp.Controls.Add(this.radCompPaper);
            this.grbComp.Controls.Add(this.radCompScissors);
            this.grbComp.Location = new System.Drawing.Point(67, 272);
            this.grbComp.Name = "grbComp";
            this.grbComp.Size = new System.Drawing.Size(200, 183);
            this.grbComp.TabIndex = 3;
            this.grbComp.TabStop = false;
            this.grbComp.Text = "Computer";
            // 
            // radCompRock
            // 
            this.radCompRock.AutoSize = true;
            this.radCompRock.Location = new System.Drawing.Point(58, 38);
            this.radCompRock.Name = "radCompRock";
            this.radCompRock.Size = new System.Drawing.Size(51, 17);
            this.radCompRock.TabIndex = 4;
            this.radCompRock.TabStop = true;
            this.radCompRock.Text = "Rock";
            this.radCompRock.UseVisualStyleBackColor = true;
            // 
            // radCompPaper
            // 
            this.radCompPaper.AutoSize = true;
            this.radCompPaper.Location = new System.Drawing.Point(58, 83);
            this.radCompPaper.Name = "radCompPaper";
            this.radCompPaper.Size = new System.Drawing.Size(53, 17);
            this.radCompPaper.TabIndex = 5;
            this.radCompPaper.TabStop = true;
            this.radCompPaper.Text = "Paper";
            this.radCompPaper.UseVisualStyleBackColor = true;
            this.radCompPaper.CheckedChanged += new System.EventHandler(this.radCompPaper_CheckedChanged);
            // 
            // radCompScissors
            // 
            this.radCompScissors.AutoSize = true;
            this.radCompScissors.Location = new System.Drawing.Point(58, 134);
            this.radCompScissors.Name = "radCompScissors";
            this.radCompScissors.Size = new System.Drawing.Size(64, 17);
            this.radCompScissors.TabIndex = 6;
            this.radCompScissors.TabStop = true;
            this.radCompScissors.Text = "Scissors";
            this.radCompScissors.UseVisualStyleBackColor = true;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(86, 513);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 38);
            this.lblWin.TabIndex = 4;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 560);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.grbComp);
            this.Controls.Add(this.grbUser);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors by Allan L";
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbComp.ResumeLayout(false);
            this.grbComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.GroupBox grbComp;
        private System.Windows.Forms.RadioButton radCompRock;
        private System.Windows.Forms.RadioButton radCompPaper;
        private System.Windows.Forms.RadioButton radCompScissors;
        private System.Windows.Forms.Label lblWin;
    }
}

