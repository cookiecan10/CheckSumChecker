namespace CheckSumChecker
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
            this.FilePath = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectHashFunctionBox = new System.Windows.Forms.ComboBox();
            this.TitleBar = new System.Windows.Forms.Label();
            this.HashButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.HashFunctionLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CheckSumLabel = new System.Windows.Forms.Label();
            this.CheckSumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GivenTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilePath.Location = new System.Drawing.Point(66, 83);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(563, 20);
            this.FilePath.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(644, 81);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SelectHashFunctionBox
            // 
            this.SelectHashFunctionBox.FormattingEnabled = true;
            this.SelectHashFunctionBox.Location = new System.Drawing.Point(508, 122);
            this.SelectHashFunctionBox.Name = "SelectHashFunctionBox";
            this.SelectHashFunctionBox.Size = new System.Drawing.Size(121, 21);
            this.SelectHashFunctionBox.TabIndex = 2;
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TitleBar.Location = new System.Drawing.Point(223, 28);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(288, 24);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.Text = "Welcome To CheckSumChecker";
            // 
            // HashButton
            // 
            this.HashButton.Location = new System.Drawing.Point(644, 120);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(75, 23);
            this.HashButton.TabIndex = 4;
            this.HashButton.Text = "Hash";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 86);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(48, 13);
            this.FilePathLabel.TabIndex = 5;
            this.FilePathLabel.Text = "FilePath:";
            // 
            // HashFunctionLabel
            // 
            this.HashFunctionLabel.AutoSize = true;
            this.HashFunctionLabel.Location = new System.Drawing.Point(390, 125);
            this.HashFunctionLabel.Name = "HashFunctionLabel";
            this.HashFunctionLabel.Size = new System.Drawing.Size(112, 13);
            this.HashFunctionLabel.TabIndex = 6;
            this.HashFunctionLabel.Text = "Select Hash Function:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(176, 52);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(400, 17);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckSumLabel
            // 
            this.CheckSumLabel.AutoSize = true;
            this.CheckSumLabel.Location = new System.Drawing.Point(12, 167);
            this.CheckSumLabel.Name = "CheckSumLabel";
            this.CheckSumLabel.Size = new System.Drawing.Size(62, 13);
            this.CheckSumLabel.TabIndex = 8;
            this.CheckSumLabel.Text = "CheckSum:";
            // 
            // CheckSumBox
            // 
            this.CheckSumBox.BackColor = System.Drawing.Color.FloralWhite;
            this.CheckSumBox.Location = new System.Drawing.Point(80, 164);
            this.CheckSumBox.Name = "CheckSumBox";
            this.CheckSumBox.ReadOnly = true;
            this.CheckSumBox.Size = new System.Drawing.Size(549, 20);
            this.CheckSumBox.TabIndex = 9;
            this.CheckSumBox.Text = "CheckSum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Given Hash:";
            // 
            // GivenTextBox
            // 
            this.GivenTextBox.Location = new System.Drawing.Point(80, 197);
            this.GivenTextBox.Name = "GivenTextBox";
            this.GivenTextBox.Size = new System.Drawing.Size(549, 20);
            this.GivenTextBox.TabIndex = 11;
            this.GivenTextBox.TextChanged += new System.EventHandler(this.GivenTextBox_TextChanged);
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.BackColor = System.Drawing.SystemColors.Control;
            this.IncorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLabel.Location = new System.Drawing.Point(279, 220);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(162, 23);
            this.IncorrectLabel.TabIndex = 12;
            this.IncorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 249);
            this.Controls.Add(this.IncorrectLabel);
            this.Controls.Add(this.GivenTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckSumBox);
            this.Controls.Add(this.CheckSumLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.HashFunctionLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.SelectHashFunctionBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.ComboBox SelectHashFunctionBox;
        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label HashFunctionLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label CheckSumLabel;
        private System.Windows.Forms.TextBox CheckSumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GivenTextBox;
        private System.Windows.Forms.Label IncorrectLabel;
    }
}

