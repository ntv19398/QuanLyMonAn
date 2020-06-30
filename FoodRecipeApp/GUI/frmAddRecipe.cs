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
    public partial class frmAddRecipe : Form
    {
        private List<Recipe> lstRecipe = new List<Recipe>();
        private List<Foods> lstFood = new List<Foods>();
        private List<Label> lstLabel = new List<Label>();
        private List<TextBox> lstTexybox = new List<TextBox>();
        public frmAddRecipe()
        {
            InitializeComponent();
            lstRecipe = DataProcess.lstRecipes;
            lstFood = DataProcess.lstFood;
        }

        private void numStep_ValueChanged(object sender, EventArgs e)
        {
            flpStep.Controls.Clear();
            for(int i = 1; i <= numStep.Value; i++)
            {
                Label lbStep = addLabelStep(i);
                TextBox tbStep = addTextBoxStep(i);
                Label lbImage = addLabelImage(i);
                TextBox tbImage = addTextBoxImage(i);
                flpStep.Controls.Add(lbStep);
                flpStep.Controls.Add(tbStep);
                flpStep.Controls.Add(lbImage);
                flpStep.Controls.Add(tbImage);
            }
        }
        public Label addLabelStep(int i)
        {
            Label lb = new Label();
            lb.Name = "lbStep" + i;
            lb.Text = "Bước " + i;
            lb.Font = new Font("Microsoft Sans Serif", 10);
            return lb;
        }
        public Label addLabelImage(int i)
        {
            Label lb = new Label();
            lb.Name = "lbImage" + i;
            lb.Text = "Image " + i;
            lb.Font = new Font("Microsoft Sans Serif", 10);
            return lb;
        }
        public TextBox addTextBoxStep(int i)
        {
            TextBox tb = new TextBox();
            tb.Name = "txtStep" + i;
            tb.Font = new Font("Microsoft Sans Serif", 10);
            tb.Width = 250;
            tb.Height = 50;
            tb.Multiline = true;
            tb.ScrollBars = ScrollBars.Vertical;
            tb.AcceptsReturn = true;
            tb.WordWrap = true;

            return tb;
        }
        public TextBox addTextBoxImage(int i)
        {
            TextBox tb = new TextBox();
            tb.Name = "txtImage" + i;
            tb.Font = new Font("Microsoft Sans Serif", 10);
            tb.Width = 250;
            tb.Multiline = true;
            return tb;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            int id = lstFood.Count;
            string name = txtNameFood.Text.ToString();
            string urlimage = @txtUrlImage.Text.ToString();
            bool islike = chkFavorite.ThreeState;
            Foods fd = new Foods(id, name, urlimage, islike);
            lstFood.Add(fd);
            if(check(id) == true)
            {
                MessageBox.Show("Successes!");
            }
            else
                MessageBox.Show("Fail!");
        }
        private bool check(int id)
        {
            bool kt = false;
            for(int i = 0; i < lstFood.Count; i++)
            {
                if (lstFood[i].Id == id)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
