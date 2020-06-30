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
	public partial class WelcomeForm : Form
	{
		public WelcomeForm()
		{
			InitializeComponent();
		}

		private void cbUnShow_CheckedChanged(object sender, EventArgs e)
		{
			if (cbUnShow.Checked == true)
			{
				Properties.Settings.Default["IsOpen"] = false;
				Properties.Settings.Default.Save();
			}
			else
			{
				Properties.Settings.Default["IsOpen"] = true;
				Properties.Settings.Default.Save();
			}
		}
	}
}
