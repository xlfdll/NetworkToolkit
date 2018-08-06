namespace GUIPing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.pingButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            resources.ApplyResources(this.urlLabel, "urlLabel");
            this.urlLabel.Name = "urlLabel";
            // 
            // urlTextBox
            // 
            resources.ApplyResources(this.urlTextBox, "urlTextBox");
            this.urlTextBox.Name = "urlTextBox";
            // 
            // ipTextBox
            // 
            resources.ApplyResources(this.ipTextBox, "ipTextBox");
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = true;
            // 
            // ipLabel
            // 
            resources.ApplyResources(this.ipLabel, "ipLabel");
            this.ipLabel.Name = "ipLabel";
            // 
            // pingButton
            // 
            resources.ApplyResources(this.pingButton, "pingButton");
            this.pingButton.Name = "pingButton";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // timeTextBox
            // 
            resources.ApplyResources(this.timeTextBox, "timeTextBox");
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
            this.copyrightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copyrightLabel.Name = "copyrightLabel";
            // 
            // MainForm
            // 
            this.AcceptButton = this.pingButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

