﻿namespace ControlObjectsAllanL
{
    partial class frmControlObjects
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
            this.btnColour = new System.Windows.Forms.Button();
            this.lblColour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnColour
            // 
            this.btnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColour.Location = new System.Drawing.Point(54, 36);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(124, 53);
            this.btnColour.TabIndex = 0;
            this.btnColour.Text = "Change Colour";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(50, 132);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(128, 20);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "Change Colour";
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 212);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.btnColour);
            this.Name = "frmControlObjects";
            this.Text = "Control Objects by Allan L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.Label lblColour;
    }
}

