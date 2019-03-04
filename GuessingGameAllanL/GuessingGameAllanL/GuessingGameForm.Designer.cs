namespace GuessingGameAllanL
{
    partial class frmGuessingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessingGame));
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PicRight = new System.Windows.Forms.PictureBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.PicWrong = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(333, 155);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // PicRight
            // 
            this.PicRight.Image = global::GuessingGameAllanL.Properties.Resources.checkmark;
            this.PicRight.Location = new System.Drawing.Point(28, 173);
            this.PicRight.Name = "PicRight";
            this.PicRight.Size = new System.Drawing.Size(160, 156);
            this.PicRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRight.TabIndex = 2;
            this.PicRight.TabStop = false;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(319, 91);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // PicWrong
            // 
            this.PicWrong.Image = ((System.Drawing.Image)(resources.GetObject("PicWrong.Image")));
            this.PicWrong.ImageLocation = "middle";
            this.PicWrong.Location = new System.Drawing.Point(28, 173);
            this.PicWrong.Name = "PicWrong";
            this.PicWrong.Size = new System.Drawing.Size(160, 156);
            this.PicWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicWrong.TabIndex = 4;
            this.PicWrong.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicWrong);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.PicRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game by AllanL";
            ((System.ComponentModel.ISupportInitialize)(this.PicRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicRight;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.PictureBox PicWrong;
        private System.Windows.Forms.Label label2;
    }
}

