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
    public partial class frmSearch : Form
    {
        private List<Foods> lstFood = new List<Foods>();
        public frmSearch()
        {
            InitializeComponent();
        }
        public frmSearch(string search)
        {
            InitializeComponent();
            lstFood = DataProcess.lstFood;
            LoadResult(search);
        }
        public void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmDetailFood frm = new frmDetailFood(int.Parse(btn.Name));
            frm.Show();
        }
        void LoadResult(string key)
        {
            List<Foods> lstResult = lstFood.Where(x => x.Name.Contains(key)).ToList();
            if(lstResult.Count > 0)
            {
                for(int i = 0; i <lstResult.Count; i++)
                {
                    Button btn = addButton(lstResult[i].Id, lstResult[i].Name, lstResult[i].urlImage);
                    flpSearch.Controls.Add(btn);
                    btn.Click += new System.EventHandler(this.button_Click);
                }
                
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
