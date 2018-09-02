using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureInPicture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Properties.Settings.Default.Upgrade();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Pip());
            } catch (Exception e)
            {
                MessageBox.Show($"The following exception was thrown:\n\n{e.ToString()}", "The Pips Fatal Error");
            }
        }
    }
}
