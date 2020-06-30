using FoodRecipeApp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Properties.Settings.Default["IsOpen"] = true;
			Properties.Settings.Default.Save();
			if (Properties.Settings.Default.IsOpen)
			{
				Application.Run(new WelcomeForm());
			}
            Application.Run(new frmHomeScreen());
        }
    }
}
