namespace COMP123_S19_Assignment_5
{
    partial class SelectForm
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
            this.HardwareListLabel = new System.Windows.Forms.Label();
            this.HardwareDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HardwareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HardwareListLabel
            // 
            this.HardwareListLabel.Location = new System.Drawing.Point(10, 10);
            this.HardwareListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HardwareListLabel.Name = "HardwareListLabel";
            this.HardwareListLabel.Size = new System.Drawing.Size(389, 37);
            this.HardwareListLabel.TabIndex = 0;
            this.HardwareListLabel.Text = "Dollar Computer Hardware List";
            // 
            // HardwareDataGridView
            // 
            this.HardwareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwareDataGridView.Location = new System.Drawing.Point(10, 49);
            this.HardwareDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HardwareDataGridView.Name = "HardwareDataGridView";
            this.HardwareDataGridView.RowTemplate.Height = 24;
            this.HardwareDataGridView.Size = new System.Drawing.Size(1385, 355);
            this.HardwareDataGridView.TabIndex = 1;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.Location = new System.Drawing.Point(10, 440);
            this.SelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(201, 33);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Your Selection:";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Location = new System.Drawing.Point(216, 440);
            this.YourSelectionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.Size = new System.Drawing.Size(631, 36);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(932, 432);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(188, 50);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1184, 430);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(188, 50);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 498);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.HardwareDataGridView);
            this.Controls.Add(this.HardwareListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.HardwareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HardwareListLabel;
        private System.Windows.Forms.DataGridView HardwareDataGridView;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}