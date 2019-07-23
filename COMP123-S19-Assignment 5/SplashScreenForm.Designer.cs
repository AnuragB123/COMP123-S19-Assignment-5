namespace COMP123_S19_Assignment_5
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SplashScreenImagePictureBox = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(195, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(275, 129);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Dollar Computers";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenImagePictureBox
            // 
            this.SplashScreenImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SplashScreenImagePictureBox.Image")));
            this.SplashScreenImagePictureBox.Location = new System.Drawing.Point(12, 183);
            this.SplashScreenImagePictureBox.Name = "SplashScreenImagePictureBox";
            this.SplashScreenImagePictureBox.Size = new System.Drawing.Size(266, 258);
            this.SplashScreenImagePictureBox.TabIndex = 1;
            this.SplashScreenImagePictureBox.TabStop = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(254, 138);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(161, 28);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "We Sell for Less!";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SplashScreenImagePictureBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox SplashScreenImagePictureBox;
        private System.Windows.Forms.Label MessageLabel;
    }
}

