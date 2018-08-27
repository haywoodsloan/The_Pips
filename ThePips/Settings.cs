using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Timer = System.Threading.Timer;

namespace PictureInPicture
{
    public partial class Settings : Form
    {
        private Pip pip;
        private Timer timer;

        private object captureLock = new object();
        private Graphics graphics;
        private Rectangle bounds;
        private Bitmap bitmap;

        public Settings(Pip pip)
        {
            this.pip = pip;

            InitializeComponent();

            fpsLabel.Text = fpsSlider.Value.ToString();
            alwayOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;

            int rawValue = (int)Math.Round(1000 / Properties.Settings.Default.RefreshDelay);
            fpsSlider.Value = Math.Min(Math.Max(rawValue, fpsSlider.Minimum), fpsSlider.Maximum);
            fpsLabel.DataBindings.Add(new Binding("Text", fpsSlider, "Value"));

            screenCombo.Items.AddRange(Enumerable.Range(0, Screen.AllScreens.Length).Cast<object>().ToArray());
            screenCombo.SelectedIndex = Math.Min(Properties.Settings.Default.CaptureScreenIndex,
                Screen.AllScreens.Length);
            
            timer = new Timer(CaptureScreen);
            SetCaptureScreen(screenCombo.SelectedIndex);
            timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(2));
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            pip.SetupCaptureTimer(1000f / fpsSlider.Value);
            pip.SetCaptureScreen(screenCombo.SelectedIndex);
            pip.SaveTopMost(alwayOnTop.Checked);

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CaptureScreen(object state)
        {
            try
            {
                lock (captureLock)
                {
                    graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
                }

                screenPreview.BeginInvoke(new Action(() => screenPreview.Refresh()));
            }
            catch { }
        }

        private void SetCaptureScreen(int screenIndex)
        {
            lock (captureLock)
            {
                bounds = Screen.AllScreens[screenCombo.SelectedIndex].Bounds;
                bitmap = new Bitmap(bounds.Width, bounds.Height);
                graphics = Graphics.FromImage(bitmap);
                screenPreview.Image = bitmap;
            }
        }

        private void OnSelectedChange(object sender, EventArgs e)
        {
            SetCaptureScreen(screenCombo.SelectedIndex);
            timer?.Change(TimeSpan.Zero, TimeSpan.FromSeconds(2));
        }
    }
}
