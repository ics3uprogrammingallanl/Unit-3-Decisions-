namespace NumberGuessingAllanL
{
    partial class frmNumberGuessing
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.picRightWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(116, 76);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 41);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(40, 33);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(202, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Please enter a number between 1 and 10";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(248, 30);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(28, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // picRightWrong
            // 
            this.picRightWrong.Location = new System.Drawing.Point(92, 136);
            this.picRightWrong.Name = "picRightWrong";
            this.picRightWrong.Size = new System.Drawing.Size(150, 124);
            this.picRightWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightWrong.TabIndex = 3;
            this.picRightWrong.TabStop = false;
            // 
            // frmNumberGuessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 272);
            this.Controls.Add(this.picRightWrong);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmNumberGuessing";
            this.Text = "Number Guessing Game by AllanL";
            this.Load += new System.EventHandler(this.frmNumberGuessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.PictureBox picRightWrong;
    }
}

