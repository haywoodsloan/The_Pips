namespace PictureInPicture
{
    partial class Pip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pip));
            this.screenPicture = new System.Windows.Forms.PictureBox();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.screenPicture)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenPicture
            // 
            this.screenPicture.BackColor = System.Drawing.Color.Black;
            this.screenPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPicture.Enabled = false;
            this.screenPicture.Location = new System.Drawing.Point(0, 0);
            this.screenPicture.Margin = new System.Windows.Forms.Padding(0);
            this.screenPicture.Name = "screenPicture";
            this.screenPicture.Size = new System.Drawing.Size(480, 270);
            this.screenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenPicture.TabIndex = 0;
            this.screenPicture.TabStop = false;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.BackColor = System.Drawing.Color.DimGray;
            this.RightClickMenu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenuItem,
            this.SettingsMenuItem});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.ShowImageMargin = false;
            this.RightClickMenu.Size = new System.Drawing.Size(103, 48);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.CloseMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CloseMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(102, 22);
            this.CloseMenuItem.Text = "Close";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseClick);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(102, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.OnSettings);
            // 
            // Pip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.ContextMenuStrip = this.RightClickMenu;
            this.ControlBox = false;
            this.Controls.Add(this.screenPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Pip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Picture-In-Picture";
            this.TopMost = true;
            this.ClientSizeChanged += new System.EventHandler(this.OnClientResize);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.Move += new System.EventHandler(this.OnMove);
            ((System.ComponentModel.ISupportInitialize)(this.screenPicture)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenPicture;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
    }
}

