﻿namespace FoodRecipeApp.GUI
{
	partial class WelcomeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbUnShow = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(340, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hello Vinh óc chó";
			// 
			// cbUnShow
			// 
			this.cbUnShow.AutoSize = true;
			this.cbUnShow.Location = new System.Drawing.Point(343, 274);
			this.cbUnShow.Name = "cbUnShow";
			this.cbUnShow.Size = new System.Drawing.Size(84, 17);
			this.cbUnShow.TabIndex = 1;
			this.cbUnShow.Text = "Click Cái CC";
			this.cbUnShow.UseVisualStyleBackColor = true;
			this.cbUnShow.CheckedChanged += new System.EventHandler(this.cbUnShow_CheckedChanged);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbUnShow);
			this.Controls.Add(this.label1);
			this.Name = "WelcomeForm";
			this.Text = "WelcomeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbUnShow;
	}
}