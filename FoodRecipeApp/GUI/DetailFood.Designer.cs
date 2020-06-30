namespace FoodRecipeApp.GUI
{
    partial class frmDetailFood
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
            this.components = new System.ComponentModel.Container();
            this.pnFoodName = new System.Windows.Forms.Panel();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.pnImage = new System.Windows.Forms.Panel();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.pnStep = new System.Windows.Forms.Panel();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnFoodName.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.pnStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFoodName
            // 
            this.pnFoodName.Controls.Add(this.lbFoodName);
            this.pnFoodName.Location = new System.Drawing.Point(224, 12);
            this.pnFoodName.Name = "pnFoodName";
            this.pnFoodName.Size = new System.Drawing.Size(339, 40);
            this.pnFoodName.TabIndex = 0;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(0, 0);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(0, 20);
            this.lbFoodName.TabIndex = 0;
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.slidePic);
            this.pnImage.Location = new System.Drawing.Point(12, 183);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(378, 216);
            this.pnImage.TabIndex = 0;
            // 
            // slidePic
            // 
            this.slidePic.Location = new System.Drawing.Point(3, 3);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(372, 210);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePic.TabIndex = 0;
            this.slidePic.TabStop = false;
            // 
            // pnStep
            // 
            this.pnStep.Controls.Add(this.txtStep);
            this.pnStep.Location = new System.Drawing.Point(89, 78);
            this.pnStep.Name = "pnStep";
            this.pnStep.Size = new System.Drawing.Size(612, 73);
            this.pnStep.TabIndex = 0;
            // 
            // txtStep
            // 
            this.txtStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep.Location = new System.Drawing.Point(0, 0);
            this.txtStep.Multiline = true;
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(612, 73);
            this.txtStep.TabIndex = 0;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(713, 128);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(713, 78);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Các bước\r\nthực hiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(679, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(396, 183);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(392, 213);
            this.webBrowser1.TabIndex = 4;
            // 
            // frmDetailFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.pnStep);
            this.Controls.Add(this.pnImage);
            this.Controls.Add(this.pnFoodName);
            this.Name = "frmDetailFood";
            this.pnFoodName.ResumeLayout(false);
            this.pnFoodName.PerformLayout();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.pnStep.ResumeLayout(false);
            this.pnStep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnFoodName;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.Panel pnStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}