namespace GeoTiffHeight
{
    partial class ucNewProjectSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geoTiffFilename = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.geoTiffCenterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.centerHeightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.heightResolutionLabel = new System.Windows.Forms.Label();
            this.adjustETextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adjustNTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geo TIFF Plugin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filename to load:";
            // 
            // geoTiffFilename
            // 
            this.geoTiffFilename.Location = new System.Drawing.Point(160, 43);
            this.geoTiffFilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.geoTiffFilename.Name = "geoTiffFilename";
            this.geoTiffFilename.Size = new System.Drawing.Size(432, 22);
            this.geoTiffFilename.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(601, 41);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 28);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Center Of Geo TIFF:";
            // 
            // geoTiffCenterLabel
            // 
            this.geoTiffCenterLabel.AutoSize = true;
            this.geoTiffCenterLabel.Location = new System.Drawing.Point(161, 84);
            this.geoTiffCenterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.geoTiffCenterLabel.Name = "geoTiffCenterLabel";
            this.geoTiffCenterLabel.Size = new System.Drawing.Size(89, 16);
            this.geoTiffCenterLabel.TabIndex = 5;
            this.geoTiffCenterLabel.Text = "no file loaded";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Center Height:";
            // 
            // centerHeightLabel
            // 
            this.centerHeightLabel.AutoSize = true;
            this.centerHeightLabel.Location = new System.Drawing.Point(161, 108);
            this.centerHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.centerHeightLabel.Name = "centerHeightLabel";
            this.centerHeightLabel.Size = new System.Drawing.Size(89, 16);
            this.centerHeightLabel.TabIndex = 7;
            this.centerHeightLabel.Text = "no file loaded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adjust Center:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "E,N Resolution";
            // 
            // heightResolutionLabel
            // 
            this.heightResolutionLabel.AutoSize = true;
            this.heightResolutionLabel.Location = new System.Drawing.Point(161, 137);
            this.heightResolutionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightResolutionLabel.Name = "heightResolutionLabel";
            this.heightResolutionLabel.Size = new System.Drawing.Size(89, 16);
            this.heightResolutionLabel.TabIndex = 10;
            this.heightResolutionLabel.Text = "no file loaded";
            // 
            // adjustETextBox
            // 
            this.adjustETextBox.Location = new System.Drawing.Point(184, 164);
            this.adjustETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adjustETextBox.Name = "adjustETextBox";
            this.adjustETextBox.Size = new System.Drawing.Size(69, 22);
            this.adjustETextBox.TabIndex = 11;
            this.adjustETextBox.Text = "0";
            this.adjustETextBox.TextChanged += new System.EventHandler(this.adjustETextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "E:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "N:";
            // 
            // adjustNTextBox
            // 
            this.adjustNTextBox.Location = new System.Drawing.Point(329, 164);
            this.adjustNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adjustNTextBox.Name = "adjustNTextBox";
            this.adjustNTextBox.Size = new System.Drawing.Size(81, 22);
            this.adjustNTextBox.TabIndex = 13;
            this.adjustNTextBox.Text = "0";
            this.adjustNTextBox.TextChanged += new System.EventHandler(this.adjustNTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "units";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "units";
            // 
            // ucNewProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adjustNTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adjustETextBox);
            this.Controls.Add(this.heightResolutionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.centerHeightLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.geoTiffCenterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.geoTiffFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucNewProjectSettings";
            this.Size = new System.Drawing.Size(715, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox geoTiffFilename;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label geoTiffCenterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label centerHeightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label heightResolutionLabel;
        private System.Windows.Forms.TextBox adjustETextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adjustNTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
