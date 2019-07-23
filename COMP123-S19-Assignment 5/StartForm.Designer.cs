namespace COMP123_S19_Assignment_5
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.OrderLabel = new System.Windows.Forms.Label();
            this.CompanyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(12, 9);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(257, 30);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order Your Computer Today!";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyLogoPictureBox
            // 
            this.CompanyLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CompanyLogoPictureBox.Image")));
            this.CompanyLogoPictureBox.Location = new System.Drawing.Point(12, 71);
            this.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox";
            this.CompanyLogoPictureBox.Size = new System.Drawing.Size(263, 261);
            this.CompanyLogoPictureBox.TabIndex = 1;
            this.CompanyLogoPictureBox.TabStop = false;
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewOrderButton.Location = new System.Drawing.Point(13, 339);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(256, 46);
            this.StartNewOrderButton.TabIndex = 2;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 443);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(256, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(12, 391);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(256, 46);
            this.OpenSavedOrderButton.TabIndex = 4;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 495);
            this.ControlBox = false;
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.CompanyLogoPictureBox);
            this.Controls.Add(this.OrderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.PictureBox CompanyLogoPictureBox;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
    }
}