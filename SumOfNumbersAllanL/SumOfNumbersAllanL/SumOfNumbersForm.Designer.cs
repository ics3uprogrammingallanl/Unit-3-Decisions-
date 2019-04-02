namespace SumOfNumbersAllanL
{
    partial class frmSumOfNumbers
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudSumNum = new System.Windows.Forms.NumericUpDown();
            this.lstSumNum = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSumNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(155, 122);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 36);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudSumNum
            // 
            this.nudSumNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSumNum.Location = new System.Drawing.Point(145, 90);
            this.nudSumNum.Name = "nudSumNum";
            this.nudSumNum.Size = new System.Drawing.Size(120, 26);
            this.nudSumNum.TabIndex = 1;
            // 
            // lstSumNum
            // 
            this.lstSumNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSumNum.FormattingEnabled = true;
            this.lstSumNum.ItemHeight = 20;
            this.lstSumNum.Location = new System.Drawing.Point(146, 164);
            this.lstSumNum.Name = "lstSumNum";
            this.lstSumNum.Size = new System.Drawing.Size(120, 84);
            this.lstSumNum.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(73, 274);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblAnswer.TabIndex = 3;
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 381);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstSumNum);
            this.Controls.Add(this.nudSumNum);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum Of Numbers by AllanL";
            ((System.ComponentModel.ISupportInitialize)(this.nudSumNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudSumNum;
        private System.Windows.Forms.ListBox lstSumNum;
        private System.Windows.Forms.Label lblAnswer;
    }
}

