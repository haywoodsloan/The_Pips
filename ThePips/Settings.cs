using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureInPicture
{
    public partial class Settings : Form
    {
        public Settings(Pip pip)
        {
            InitializeComponent();

            fpsLabel.DataBindings.Add(new Binding("Text", fpsSlider, "Value"));
        }
    }
}
