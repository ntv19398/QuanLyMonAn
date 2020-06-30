using FoodRecipeApp.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipeApp.GUI
{
    public partial class frmHomeScreen : Form
    {
		public int FirstIndex = 0;
		public int PageSize = 5;
		public int MaxPage = 0;
        private List<Foods>lstFood = new List<Foods>();
        public  frmHomeScreen()
        {

            InitializeComponent();
            lstFood = DataProcess.lstFood;
            LoadButtonFavoriteDish();
            LoadButtonListDish();
        }
        public frmHomeScreen(List<Foods> lstfood)
        {

            InitializeComponent();
            lstFood = lstfood;
            LoadButtonFavoriteDish();
            LoadButtonListDish();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmDetailFood frm = new frmDetailFood(int.Parse(btn.Name));
            frm.Show();
        }
        public void RelLoad()
        {
            lstFood = DataProcess.lstFood;
            LoadButtonFavoriteDish();
            LoadButtonListDish();
        }
        public void LoadButtonFavoriteDish()
        {
            
            for (int i = 0; i < lstFood.Count; i++)
            {
                if(lstFood[i].isLike == true)
                {
                    Button btn = addButton(lstFood[i].Id, lstFood[i].Name, lstFood[i].urlImage);
                    flpFavoriteDish.Controls.Add(btn);
                    btn.Click += new System.EventHandler(this.button_Click);
                }
            }
        }
        public void LoadButtonListDish()
        {
			MaxPage = FirstIndex * PageSize + PageSize;

			if (MaxPage >= lstFood.Count())
			{
				MaxPage = lstFood.Count();
			}
			flpListDish.Controls.Clear();
			for (int i = FirstIndex* PageSize; i < MaxPage; i++)
            {
                Button btn = addButton(lstFood[i].Id, lstFood[i].Name, lstFood[i].urlImage);
                flpListDish.Controls.Add(btn);
                btn.Click += new System.EventHandler(this.button_Click);
            }
        }
        public Button addButton(int id, string name, string url)
        {
            Button btn = new Button();
            btn.Name = ""+ id;
            btn.Width = 150;
            btn.Height = 150;
            btn.Text = name;
            Image image = Image.FromFile(url);
            Image img = resizeImage(image, 150, 120);
            btn.Image = img;
            btn.ImageAlign = ContentAlignment.TopLeft;
            btn.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            btn.FlatStyle = FlatStyle.Flat;
            return btn;
        }

        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            frmSearch frm = new frmSearch(txtSearch.Text);
            frm.Show();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frm = new frmAddRecipe(this);
            frm.Show();

        }

		private void btnListDishNext_Click(object sender, EventArgs e)
		{
			FirstIndex++;
			MaxPage = FirstIndex * PageSize + PageSize;
			if(MaxPage > lstFood.Count)
			{
				btnListDishNext.Enabled = false;
			}
			else
			{
				LoadButtonListDish();
			}
			btnPreListDish.Enabled = true;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			FirstIndex--;
			if (FirstIndex <= 0)
			{
				FirstIndex = 0;
				btnPreListDish.Enabled = false;

			}
			btnListDishNext.Enabled = true;
			LoadButtonListDish();

		}
	}
}
