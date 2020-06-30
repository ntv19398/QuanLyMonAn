namespace FoodRecipeApp.GUI
{
    partial class frmAddRecipe
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
            this.chkFavorite = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlImage = new System.Windows.Forms.TextBox();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.txtLinkYoutube = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.flpStep = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            this.SuspendLayout();
            // 
            // chkFavorite
            // 
            this.chkFavorite.AutoSize = true;
            this.chkFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFavorite.Location = new System.Drawing.Point(148, 86);
            this.chkFavorite.Name = "chkFavorite";
            this.chkFavorite.Size = new System.Drawing.Size(79, 21);
            this.chkFavorite.TabIndex = 9;
            this.chkFavorite.Text = "Ưa thích";
            this.chkFavorite.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Món ăn ưa thich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Link hình ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên món ăn";
            // 
            // txtUrlImage
            // 
            this.txtUrlImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImage.Location = new System.Drawing.Point(148, 49);
            this.txtUrlImage.Name = "txtUrlImage";
            this.txtUrlImage.Size = new System.Drawing.Size(163, 23);
            this.txtUrlImage.TabIndex = 3;
            // 
            // txtNameFood
            // 
            this.txtNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFood.Location = new System.Drawing.Point(148, 12);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(235, 23);
            this.txtNameFood.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numStep);
            this.panel1.Controls.Add(this.txtLinkYoutube);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.txtNameFood);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkFavorite);
            this.panel1.Controls.Add(this.txtUrlImage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 322);
            this.panel1.TabIndex = 10;
            // 
            // numStep
            // 
            this.numStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStep.Location = new System.Drawing.Point(148, 123);
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(235, 23);
            this.numStep.TabIndex = 10;
            this.numStep.ValueChanged += new System.EventHandler(this.numStep_ValueChanged);
            // 
            // txtLinkYoutube
            // 
            this.txtLinkYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkYoutube.Location = new System.Drawing.Point(148, 167);
            this.txtLinkYoutube.Name = "txtLinkYoutube";
            this.txtLinkYoutube.Size = new System.Drawing.Size(235, 23);
            this.txtLinkYoutube.TabIndex = 4;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(317, 45);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(66, 30);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Link Youtube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số bước nấu món ăn";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(338, 401);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(94, 37);
            this.btnAddRecipe.TabIndex = 11;
            this.btnAddRecipe.Text = "Add";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // flpStep
            // 
            this.flpStep.AutoScroll = true;
            this.flpStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpStep.Location = new System.Drawing.Point(404, 73);
            this.flpStep.Name = "flpStep";
            this.flpStep.Size = new System.Drawing.Size(373, 322);
            this.flpStep.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpStep);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddRecipe";
            this.Text = "Thêm món ăn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlImage;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpStep;
        private System.Windows.Forms.TextBox txtLinkYoutube;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}