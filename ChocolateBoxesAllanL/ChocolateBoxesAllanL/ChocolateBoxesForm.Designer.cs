namespace ChocolateBoxesAllanL
{
    partial class frmChocolateBoxes
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
            this.lblNumberofBoxes = new System.Windows.Forms.Label();
            this.nudBoxesSold = new System.Windows.Forms.NumericUpDown();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.lblYourReward = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberofBoxes
            // 
            this.lblNumberofBoxes.AutoSize = true;
            this.lblNumberofBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofBoxes.Location = new System.Drawing.Point(12, 79);
            this.lblNumberofBoxes.Name = "lblNumberofBoxes";
            this.lblNumberofBoxes.Size = new System.Drawing.Size(398, 20);
            this.lblNumberofBoxes.TabIndex = 0;
            this.lblNumberofBoxes.Text = "Please enter the number of boxes you have sold:";
            // 
            // nudBoxesSold
            // 
            this.nudBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBoxesSold.Location = new System.Drawing.Point(451, 77);
            this.nudBoxesSold.Name = "nudBoxesSold";
            this.nudBoxesSold.Size = new System.Drawing.Size(48, 26);
            this.nudBoxesSold.TabIndex = 1;
            // 
            // btnGetReward
            // 
            this.btnGetReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(211, 154);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(138, 66);
            this.btnGetReward.TabIndex = 2;
            this.btnGetReward.Text = "Get Reward";
            this.btnGetReward.UseVisualStyleBackColor = true;
            this.btnGetReward.Click += new System.EventHandler(this.btnGetReward_Click);
            // 
            // lblYourReward
            // 
            this.lblYourReward.AutoSize = true;
            this.lblYourReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourReward.Location = new System.Drawing.Point(73, 252);
            this.lblYourReward.Name = "lblYourReward";
            this.lblYourReward.Size = new System.Drawing.Size(129, 20);
            this.lblYourReward.TabIndex = 3;
            this.lblYourReward.Text = "Your reward is:";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(313, 252);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(0, 20);
            this.lblReward.TabIndex = 4;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 360);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblYourReward);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.nudBoxesSold);
            this.Controls.Add(this.lblNumberofBoxes);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes by Allan L";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberofBoxes;
        private System.Windows.Forms.NumericUpDown nudBoxesSold;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.Label lblYourReward;
        private System.Windows.Forms.Label lblReward;
    }
}

