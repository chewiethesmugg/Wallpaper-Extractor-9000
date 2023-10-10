namespace randomWallpaper
{
    partial class Form1
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
            this.getWallpaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getWallpaper
            // 
            this.getWallpaper.Location = new System.Drawing.Point(98, 150);
            this.getWallpaper.Name = "getWallpaper";
            this.getWallpaper.Size = new System.Drawing.Size(89, 23);
            this.getWallpaper.TabIndex = 0;
            this.getWallpaper.Text = " ";
            this.getWallpaper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.getWallpaper);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getWallpaperButton;
        private System.Windows.Forms.Button getWallpaper;
    }
}

