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
    public partial class frmDetailFood : Form
    {
        private List<Recipe> lstRecipe = new List<Recipe>();
        private List<Foods> lstFood = new List<Foods>();
        int vitri = -1;
        int pos = 0;
        int max = 0;
        int idfood = -1;
        int imgNum = 0;
        List<string> lstImg = new List<string>();
        
       
        public frmDetailFood()
        {
            InitializeComponent();
        }
        public frmDetailFood(int id)
        {
            InitializeComponent();
            idfood = id;
            lstFood = DataProcess.lstFood;
            lstRecipe = DataProcess.lstRecipes;
            LoadDetailFood(idfood, pos);
            getListImage();
            LoadVideo();
        }
        void LoadDetailFood(int id, int step)
        {
            for(int i = 0; i < lstFood.Count; i++)
            {
                if(lstFood[i].Id == id)
                {
                    lbFoodName.Text = lstFood[i].Name;
                    vitri = i;
                }
            }
            max = lstRecipe[vitri].lstStep.Count;
            txtStep.Text = lstRecipe[vitri].lstStep[step].Description;
            
            
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(pos == 0)
            {
                btnPrevious.Enabled = false;

            }
            else
            {
                btnPrevious.Enabled = true;
                pos--;
                LoadDetailFood(idfood, pos);
            }
            btnNextStep.Enabled = true;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if(pos >= max -1)
            {
                btnNextStep.Enabled = false;
                
                pos = max - 1;
            }
            else
            {
                btnNextStep.Enabled = true;
                pos++;
                LoadDetailFood(idfood, pos);
            }
            btnPrevious.Enabled = true;
        }
        void getListImage()
        {
            for (int i = 0; i < lstRecipe[vitri].lstStep.Count; i++)
            {
                string img = lstRecipe[vitri].lstStep[i].urlImage;
                if (String.IsNullOrEmpty(img))
                {
                    continue;
                }
                else
                {
                    lstImg.Add(img);
                }
            }
        }
        
        void LoadNextImage()
        {
            
            if (imgNum > lstImg.Count - 1)
            {
                imgNum = 0;
            }
            //slidePic.ImageLocation = lstRecipe[vitri].lstStep[imgNum].urlImage;
            
            slidePic.ImageLocation = lstImg[imgNum];
            imgNum++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        void LoadVideo()
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='392' height='213' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, lstRecipe[vitri].urlVideo.Split('=')[1]);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            vitri = -1;
        }
    }
}
