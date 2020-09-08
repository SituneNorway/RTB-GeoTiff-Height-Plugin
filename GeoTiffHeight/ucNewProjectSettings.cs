using System;
using System.Windows.Forms;
using Oware;

namespace GeoTiffHeight
{
    public partial class ucNewProjectSettings : UserControl
    {
        internal String GeoTiffFilename;
        internal Int32 AdjustE;
        internal Int32 AdjustN;
        internal Int32 UTMZone;
        public ucNewProjectSettings()
        {
            InitializeComponent();
            try
            {
                // Load the setting from last time.
                //GeoTiffHeight.Config.TryGet<int>("HeightMultiplier", out int heightMultiplier);
                GeoTiffHeight.Config.TryGet<String>("GeoTiffFileName", out String tmpFileName);
                GeoTiffHeight.Config.TryGet<Int32>("AdjustE", out Int32 tmpAdjustE);
                GeoTiffHeight.Config.TryGet<Int32>("AdjustN", out Int32 tmpAdjustN);
                GeoTiffHeight.Config.TryGet<Int32>("UTMZone", out Int32 tmpUTMZone);
                geoTiffFilename.Text = tmpFileName;
                GeoTiffFilename = tmpFileName;
                AdjustE = tmpAdjustE;
                AdjustN = tmpAdjustN;
                UTMZone = tmpUTMZone;
                adjustETextBox.Text = tmpAdjustE.ToString();
                adjustNTextBox.Text = tmpAdjustN.ToString();
                textBox1.Text = tmpUTMZone.ToString();
                loadFile();
            }
            catch (Exception ex)
            {
                // Do nothing.
                ex.ToString();
            }
        }

        internal void AcceptNewProjectSettings()
        {
            // Keep the setting for next time a New Project is created.
            //GeoTiffHeight.Config.AddOrUpdate("HeightMultiplier", trkHeightMultiplier.Value.ToString());
            GeoTiffHeight.Config.AddOrUpdate("GeoTiffFilename", geoTiffFilename.Text);
            GeoTiffHeight.Config.AddOrUpdate("AdjustE", adjustETextBox.Text);
            GeoTiffHeight.Config.AddOrUpdate("AdjustN", adjustNTextBox.Text);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                geoTiffFilename.Text = openDialog.FileName;
                loadFile();
                GeoTiffFilename = openDialog.FileName;
            }
        }
        private void loadFile()
        {
            if (geoTiffFilename.Text.Length > 0)
            {
                GeoTIFFReader.GeoTIFF geoTiff = new GeoTIFFReader.GeoTIFF(geoTiffFilename.Text);
                double rangeW = geoTiff.NWidth * geoTiff.DW;
                double rangeH = geoTiff.NHeight * geoTiff.DH;
                rangeW /= 2;
                rangeH /= 2;
                double centerW = (geoTiff.StartW + rangeW);
                double centerH = (geoTiff.StartH + rangeH);
                LatLngUTMConverter converter = new LatLngUTMConverter("EUREF89");
                LatLngUTMConverter.LatLng center = converter.convertUtmToLatLng((geoTiff.StartW + rangeW), (geoTiff.StartH + rangeH), Int32.Parse(textBox1.Text) , "N");

                geoTiffCenterLabel.Text = "E: " + centerW.ToString() + " m N: " + centerH.ToString() + " m" + " ( " + center.Lat.ToString() + ", " + center.Lng.ToString() + " )";
                centerHeightLabel.Text = geoTiff.HeightMap[(int)(geoTiff.NWidth / 2.0) , (int)(geoTiff.NHeight / 2.0)].ToString() + " m";
                heightResolutionLabel.Text = "E: " + geoTiff.DH.ToString() + "m N: " + geoTiff.DW.ToString() + "m";
                
            }
            else
            {
                MessageBox.Show("No valid filename selected, cannot load file !");
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
                UTMZone = Int32.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
