using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoTiffHeight
{
    public partial class ucProjectSettings : UserControl
    {
        internal String GeoTiffFilename;
        internal Int32 AdjustE;
        internal Int32 AdjustN;
        internal float AdjustHeight;

        public ucProjectSettings()
        {
            InitializeComponent();
        }

        public void updateComponents()
        {
            geoTiffFilename.Text = GeoTiffFilename;
            adjustETextBox.Text = AdjustE.ToString();
            adjustNTextBox.Text = AdjustN.ToString();
            textBox1.Text = AdjustHeight.ToString();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                geoTiffFilename.Text = openDialog.FileName;
                //loadFile();
                GeoTiffFilename = openDialog.FileName;
            }
        }

        private void adjustETextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AdjustE = Int32.Parse(adjustETextBox.Text);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void adjustNTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                AdjustN = Int32.Parse(adjustNTextBox.Text);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AdjustHeight = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
