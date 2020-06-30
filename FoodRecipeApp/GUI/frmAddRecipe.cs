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
        public List<Recipe> lstRecipe = new List<Recipe>();
        public List<Foods> lstFood = new List<Foods>();
        private List<Label> lstLabel = new List<Label>();
        private List<TextBox> lstTextbox = new List<TextBox>();
        private List<TextBox> lstTbImage = new List<TextBox>();
        private List<Button> lstButton = new List<Button>();
        public frmAddRecipe()
        {
            InitializeComponent();
            lstRecipe = DataProcess.lstRecipes;
            lstFood = DataProcess.lstFood;
            
        }

        public void numStep_ValueChanged(object sender, EventArgs e)
        {
            flpStep.Controls.Clear();
            for(int i = 0; i < numStep.Value; i++)
            {
                Label lbStep = addLabelStep(i);
                TextBox tbStep = addTextBoxStep(i);
                Label lbImage = addLabelImage(i);
                TextBox tbImage = addTextBoxImage(i);
                Button btnImage = AddButton(i);
                
                flpStep.Controls.Add(lbStep);
                flpStep.Controls.Add(tbStep);
                flpStep.Controls.Add(lbImage);
                flpStep.Controls.Add(tbImage);
                flpStep.Controls.Add(btnImage);

                btnImage.Click += new System.EventHandler(this.btnImage_Click);

                lstTextbox.Add(tbStep);
                lstTbImage.Add(tbImage);
                lstButton.Add(btnImage);

                
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
            tb.Width = 130;
            return tb;
        }
        public Button AddButton(int i)
        {
            Button btn = new Button();
            btn.Name = "" + i;
            btn.Font = new Font("Microsoft Sans Serif", 9);
            btn.Text = "Open File";
            btn.Width = 100;
            return btn;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                int id = lstFood.Count;
                string name = txtNameFood.Text.ToString();
                string urlimage = txtUrlImage.Text.ToString();
                bool islike = chkFavorite.ThreeState;
                Foods fd = new Foods(id, name, urlimage, islike);
                lstFood.Add(fd);
                List<Step> lstStep = new List<Step>();
                for(int i = 0; i < lstTextbox.Count; i++)
                {
                    Step stp = new Step(lstTbImage[i].Text, lstTextbox[i].Text);
                    lstStep.Add(stp);
                }
                Recipe rcp = new Recipe(id, txtLinkYoutube.Text, lstStep);
                lstRecipe.Add(rcp);
                if (check(id) == true)
                {
                    MessageBox.Show("Successes!");
                    txtNameFood.Text = "";
                    txtUrlImage.Text = "";
                    chkFavorite.ThreeState = true;
                    numStep.Value = 0;
                    txtLinkYoutube.Text = "";

                }
                else
                    MessageBox.Show("Fail!");
            }
        }


        private bool check(int id)
        {
            bool kt = false;
            for(int i = 1; i < lstFood.Count; i++)
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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              txtUrlImage.Text = openFile.FileName;
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int id = int.Parse(btn.Name);
                lstTbImage[id].Text = "a";
            }
        }
        private bool CheckValidation()
        {
            bool kt = true;
            for(int i  = 0; i < lstTextbox.Count; i++)
            {
                if(lstTextbox[i].Text == "")
                {
                    kt = false;
                    break;
                }
            }
            if (txtNameFood.Text == "" || txtUrlImage.Text == "" || txtLinkYoutube.Text == "" || kt == false)
            {
                kt = false;
            }
            return kt;
        }
    }
}
