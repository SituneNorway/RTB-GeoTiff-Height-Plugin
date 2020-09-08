namespace GeoTiffHeight
{
    partial class ucProjectSettings
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
            this.browseButton = new System.Windows.Forms.Button();
            this.geoTiffFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adjustNTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adjustETextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(909, 39);
            this.browseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(150, 44);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // geoTiffFilename
            // 
            this.geoTiffFilename.Location = new System.Drawing.Point(248, 42);
            this.geoTiffFilename.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.geoTiffFilename.Name = "geoTiffFilename";
            this.geoTiffFilename.Size = new System.Drawing.Size(646, 31);
            this.geoTiffFilename.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filename to load:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "units";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "units";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "N:";
            // 
            // adjustNTextBox
            // 
            this.adjustNTextBox.Location = new System.Drawing.Point(502, 97);
            this.adjustNTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adjustNTextBox.Name = "adjustNTextBox";
            this.adjustNTextBox.Size = new System.Drawing.Size(120, 31);
            this.adjustNTextBox.TabIndex = 20;
            this.adjustNTextBox.Text = "0";
            this.adjustNTextBox.TextChanged += new System.EventHandler(this.adjustNTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "E:";
            // 
            // adjustETextBox
            // 
            this.adjustETextBox.Location = new System.Drawing.Point(285, 97);
            this.adjustETextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adjustETextBox.Name = "adjustETextBox";
            this.adjustETextBox.Size = new System.Drawing.Size(102, 31);
            this.adjustETextBox.TabIndex = 18;
            this.adjustETextBox.Text = "0";
            this.adjustETextBox.TextChanged += new System.EventHandler(this.adjustETextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adjust Center:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Adjust Center Height:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 156);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 31);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "meter";
            // 
            // ucProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adjustNTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adjustETextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.geoTiffFilename);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ucProjectSettings";
            this.Size = new System.Drawing.Size(1092, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox geoTiffFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adjustNTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adjustETextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}
