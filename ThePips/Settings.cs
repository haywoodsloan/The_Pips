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
        private Pip pip;

        public Settings(Pip pip)
        {
            this.pip = pip;

            InitializeComponent();
            fpsSlider.Value = Math.Min(fpsSlider.Maximum, 1000 / Properties.Settings.Default.RefreshDelay);
            fpsLabel.Text = fpsSlider.Value.ToString();
            alwayOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;

            fpsLabel.DataBindings.Add(new Binding("Text", fpsSlider, "Value"));
            fpsSlider.DataBindings.Add(new Binding("Value", fpsLabel, "Text"));

            screenCombo.Items.AddRange(Enumerable.Range(0, Screen.AllScreens.Length).Cast<object>().ToArray());
            if (Properties.Settings.Default.CaptureScreenIndex < Screen.AllScreens.Length)
            {
                screenCombo.SelectedIndex = Properties.Settings.Default.CaptureScreenIndex;
            }
            else
            {
                screenCombo.SelectedIndex = 0;
            }

            CaptureScreen(screenCombo.SelectedIndex);
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            pip.SetupCaptureTimer(1000 / fpsSlider.Value);
            pip.SetCaptureScreen(screenCombo.SelectedIndex);
            pip.SaveTopMost(alwayOnTop.Checked);

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CaptureScreen(int screenIndex)
        {
            var bounds = Screen.AllScreens[screenIndex].Bounds;
            var bitmap = new Bitmap(bounds.Width, bounds.Height);
            var graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
            screenPreview.Image = bitmap;
        }

        private void OnSelectedChange(object sender, EventArgs e)
        {
            CaptureScreen(screenCombo.SelectedIndex);
        }
    }
}
