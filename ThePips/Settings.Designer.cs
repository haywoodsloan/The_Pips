namespace PictureInPicture
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.screenCombo = new System.Windows.Forms.ComboBox();
            this.screenPreview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.fpsSlider = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.alwayOnTop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.screenPreview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSlider)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen";
            // 
            // screenCombo
            // 
            this.screenCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.screenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenCombo.DropDownWidth = 55;
            this.screenCombo.ForeColor = System.Drawing.Color.DimGray;
            this.screenCombo.FormattingEnabled = true;
            this.screenCombo.Location = new System.Drawing.Point(56, -1);
            this.screenCombo.Name = "screenCombo";
            this.screenCombo.Size = new System.Drawing.Size(61, 21);
            this.screenCombo.TabIndex = 1;
            this.screenCombo.SelectedIndexChanged += new System.EventHandler(this.OnScreenSelectedChange);
            // 
            // screenPreview
            // 
            this.screenPreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.screenPreview.BackColor = System.Drawing.Color.Black;
            this.screenPreview.Location = new System.Drawing.Point(162, 12);
            this.screenPreview.Name = "screenPreview";
            this.screenPreview.Size = new System.Drawing.Size(160, 100);
            this.screenPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenPreview.TabIndex = 2;
            this.screenPreview.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.03798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.96202F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.screenPreview, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 125);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.screenCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 23);
            this.panel1.TabIndex = 4;
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fpsLabel.Location = new System.Drawing.Point(-3, 0);
            this.fpsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(22, 16);
            this.fpsLabel.TabIndex = 5;
            this.fpsLabel.Text = "15";
            // 
            // fpsSlider
            // 
            this.fpsSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsSlider.Location = new System.Drawing.Point(3, 3);
            this.fpsSlider.Maximum = 144;
            this.fpsSlider.Minimum = 1;
            this.fpsSlider.Name = "fpsSlider";
            this.fpsSlider.Size = new System.Drawing.Size(263, 25);
            this.fpsSlider.TabIndex = 6;
            this.fpsSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.fpsSlider.Value = 15;
            this.fpsSlider.Scroll += new System.EventHandler(this.OnFpsSelectedChange);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.07692F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.92308F));
            this.tableLayoutPanel2.Controls.Add(this.fpsSlider, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 31);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fpsLabel);
            this.panel2.Location = new System.Drawing.Point(274, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 16);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "fps";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(107, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(177, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnCloseClick);
            // 
            // alwayOnTop
            // 
            this.alwayOnTop.AutoSize = true;
            this.alwayOnTop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alwayOnTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alwayOnTop.Location = new System.Drawing.Point(15, 173);
            this.alwayOnTop.Name = "alwayOnTop";
            this.alwayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alwayOnTop.Size = new System.Drawing.Size(121, 20);
            this.alwayOnTop.TabIndex = 10;
            this.alwayOnTop.Text = "Always On Top";
            this.alwayOnTop.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(349, 238);
            this.Controls.Add(this.alwayOnTop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.screenPreview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSlider)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox screenCombo;
        private System.Windows.Forms.PictureBox screenPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TrackBar fpsSlider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox alwayOnTop;
    }
}