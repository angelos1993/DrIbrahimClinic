namespace DrIbrahimClinic.PL
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.picBoxSplashLogo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSplashLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSplashLogo
            // 
            this.picBoxSplashLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxSplashLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSplashLogo.Image")));
            this.picBoxSplashLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxSplashLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxSplashLogo.Name = "picBoxSplashLogo";
            this.picBoxSplashLogo.Size = new System.Drawing.Size(300, 400);
            this.picBoxSplashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSplashLogo.TabIndex = 0;
            this.picBoxSplashLogo.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.picBoxSplashLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmSplash";
            this.Text = "FrmSplash";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSplashLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSplashLogo;
        private System.Windows.Forms.Timer timer;
    }
}