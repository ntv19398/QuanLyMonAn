namespace FoodRecipeApp.GUI
{
    partial class frmHomeScreen
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.flpFavoriteDish = new System.Windows.Forms.FlowLayoutPanel();
			this.flpListDish = new System.Windows.Forms.FlowLayoutPanel();
			this.btnListDishNext = new System.Windows.Forms.Button();
			this.btnFavoriteDishNext = new System.Windows.Forms.Button();
			this.btnAddRecipe = new System.Windows.Forms.Button();
			this.btnFavoriteDishPrev = new System.Windows.Forms.Button();
			this.btnPreListDish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(552, 24);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(139, 20);
			this.txtSearch.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnSearch.Location = new System.Drawing.Point(713, 23);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Tìm Kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(407, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tìm kiếm tên món ăn";
			// 
			// flpFavoriteDish
			// 
			this.flpFavoriteDish.AutoScroll = true;
			this.flpFavoriteDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpFavoriteDish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.flpFavoriteDish.Location = new System.Drawing.Point(2, 84);
			this.flpFavoriteDish.Name = "flpFavoriteDish";
			this.flpFavoriteDish.Size = new System.Drawing.Size(795, 170);
			this.flpFavoriteDish.TabIndex = 5;
			// 
			// flpListDish
			// 
			this.flpListDish.AutoScroll = true;
			this.flpListDish.Location = new System.Drawing.Point(2, 294);
			this.flpListDish.Name = "flpListDish";
			this.flpListDish.Size = new System.Drawing.Size(795, 169);
			this.flpListDish.TabIndex = 5;
			// 
			// btnListDishNext
			// 
			this.btnListDishNext.Location = new System.Drawing.Point(722, 469);
			this.btnListDishNext.Name = "btnListDishNext";
			this.btnListDishNext.Size = new System.Drawing.Size(75, 23);
			this.btnListDishNext.TabIndex = 6;
			this.btnListDishNext.Text = "Next Page";
			this.btnListDishNext.UseVisualStyleBackColor = true;
			this.btnListDishNext.Click += new System.EventHandler(this.btnListDishNext_Click);
			// 
			// btnFavoriteDishNext
			// 
			this.btnFavoriteDishNext.Location = new System.Drawing.Point(722, 260);
			this.btnFavoriteDishNext.Name = "btnFavoriteDishNext";
			this.btnFavoriteDishNext.Size = new System.Drawing.Size(75, 23);
			this.btnFavoriteDishNext.TabIndex = 6;
			this.btnFavoriteDishNext.Text = "Next Page";
			this.btnFavoriteDishNext.UseVisualStyleBackColor = true;
			// 
			// btnAddRecipe
			// 
			this.btnAddRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRecipe.Location = new System.Drawing.Point(2, 16);
			this.btnAddRecipe.Name = "btnAddRecipe";
			this.btnAddRecipe.Size = new System.Drawing.Size(115, 30);
			this.btnAddRecipe.TabIndex = 7;
			this.btnAddRecipe.Text = "Add Recipe";
			this.btnAddRecipe.UseVisualStyleBackColor = true;
			this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
			// 
			// btnFavoriteDishPrev
			// 
			this.btnFavoriteDishPrev.Location = new System.Drawing.Point(2, 260);
			this.btnFavoriteDishPrev.Name = "btnFavoriteDishPrev";
			this.btnFavoriteDishPrev.Size = new System.Drawing.Size(75, 23);
			this.btnFavoriteDishPrev.TabIndex = 6;
			this.btnFavoriteDishPrev.Text = "Previous Page";
			this.btnFavoriteDishPrev.UseVisualStyleBackColor = true;
			// 
			// btnPreListDish
			// 
			this.btnPreListDish.Location = new System.Drawing.Point(2, 469);
			this.btnPreListDish.Name = "btnPreListDish";
			this.btnPreListDish.Size = new System.Drawing.Size(75, 23);
			this.btnPreListDish.TabIndex = 6;
			this.btnPreListDish.Text = "Previous Page";
			this.btnPreListDish.UseVisualStyleBackColor = true;
			this.btnPreListDish.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmHomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 496);
			this.Controls.Add(this.btnAddRecipe);
			this.Controls.Add(this.btnFavoriteDishPrev);
			this.Controls.Add(this.btnFavoriteDishNext);
			this.Controls.Add(this.btnPreListDish);
			this.Controls.Add(this.btnListDishNext);
			this.Controls.Add(this.flpListDish);
			this.Controls.Add(this.flpFavoriteDish);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Name = "frmHomeScreen";
			this.Text = "Food Recipe App";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFavoriteDish;
        private System.Windows.Forms.FlowLayoutPanel flpListDish;
        private System.Windows.Forms.Button btnListDishNext;
        private System.Windows.Forms.Button btnFavoriteDishNext;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnFavoriteDishPrev;
        private System.Windows.Forms.Button btnPreListDish;
    }
}