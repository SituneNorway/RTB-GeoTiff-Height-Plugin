using RTBPlugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GeoTiffHeight
{
    public class GeoTiffHeight : IPluginHeight
    {
        internal GeoTIFFReader.GeoTIFF geoTiff;
        internal String geoTiffFileName;
        internal Int32 adjustE;
        internal Int32 adjustN;
        internal float adjustHeight = 0.0f;
        internal double zeroHeight = 0.0;
        static MiniConfig config = null;
        internal static MiniConfig Config
        {
            get
            {
                if (config == null)
                    config = new MiniConfig(typeof(MiniConfig).Assembly.Location + ".config");
                return config;
            }
        }

        /// <summary>
        /// User control for displaying the slider on the RTB's New Venue window.
        /// </summary>
        ucNewProjectSettings ucNewProjectSettings = new ucNewProjectSettings();

        /// <summary>
        /// User control for displaying the slider on the RTB's Venue Properties window.
        /// </summary>
        ucProjectSettings ucProjectSettings = new ucProjectSettings();

        /// <summary>
        /// The amount the height will be multiplied by in the GetWaveHeight function.
        /// </summary>
        float HeightMultiplier = 100;

        public InputMethods InputMethod { get { return InputMethods.MetersXZ; } }

        public int TIMER_WAIT_SUCCESS { get { return 0; } }

        public int TIMER_WAIT_FAILED { get { return 0; } }

        public int MaximumPairCount { get { return 1000; } }

        public string Description { get { return "Geo TIFF Height Plugin by Smevik & Torvmark"; } }

        public string About { get { return "Read a Geo TIFF file and use as heights for your track !"; } }

        public void Initialize()
        {
            // Nothing required.
        }

        public void RenderNewProjectSettings(Panel panel)
        {
            ucNewProjectSettings.Dock = DockStyle.Fill;
            panel.Controls.Add(ucNewProjectSettings);
        }

        public void RenderProjectSettings(Panel panel)
        {
            ucProjectSettings = new ucProjectSettings();
            ucProjectSettings.AdjustE = adjustE;
            ucProjectSettings.AdjustN = adjustN;
            ucProjectSettings.AdjustHeight = adjustHeight;
            ucProjectSettings.GeoTiffFilename = geoTiffFileName;
            ucProjectSettings.updateComponents();
            ucProjectSettings.Dock = DockStyle.Fill;
            panel.Controls.Add(ucProjectSettings);
        }

        public bool ValidateNewProjectSettings(out string errorMessage)
        {
            errorMessage = "";
            return true;
        }

        public bool ValidateProjectSettings(out string errorMessage)
        {
            errorMessage = "";
            return true;
        }

        public void AcceptNewProjectSettings()
        {
            // Save the Noise setting.
            ucNewProjectSettings.AcceptNewProjectSettings();
            geoTiffFileName = ucNewProjectSettings.GeoTiffFilename;
            adjustE = ucNewProjectSettings.AdjustE;
            adjustN = ucNewProjectSettings.AdjustN;
            MessageBox.Show("Tiff File Name:" + geoTiffFileName);
            LoadGeoTiff(geoTiffFileName);
            Config.Save();
        }

        public void AcceptProjectSettings()
        {
            //HeightMultiplier = ucProjectSettings.HeightMultiplier;
            geoTiffFileName = ucProjectSettings.GeoTiffFilename;
            adjustE = ucProjectSettings.AdjustE;
            adjustN = ucProjectSettings.AdjustN;
            adjustHeight = ucProjectSettings.AdjustHeight;
            MessageBox.Show("Tiff File Name:" + geoTiffFileName);
            LoadGeoTiff(geoTiffFileName);
            Config.Save();
        }

        public double Fetch(double latitude_or_z, double longitude_or_x)
        {
           // return 14.0;
           return getHeightForLatLon(latitude_or_z, longitude_or_x);
        }

        public List<double> Fetch(List<LatLong> latitude_longitude_pairs)
        {
            /*
            List<double> heights = new List<double>(latitude_longitude_pairs.Count);
            foreach (var ll in latitude_longitude_pairs)
            {
                heights.Add(GetWaveHeight(ll.latitude_or_z, ll.longitude_or_x));
            }
            return heights;
            */
            List<double> heights = new List<double>(latitude_longitude_pairs.Count);
            foreach (var ll in latitude_longitude_pairs)
            {
                //heights.Add(15.0);
                heights.Add(getHeightForLatLon(ll.latitude_or_z, ll.longitude_or_x));
                //MessageBox.Show("Fetch: lat:" + ll.latitude_or_z.ToString() + " lon:" + ll.longitude_or_x.ToString());
                //heights.Add(GetWaveHeight(ll.latitude_or_z, ll.longitude_or_x));
            }
            
            return heights;

        }

        private double getHeightForLatLon(double lat, double lon)
        {
            //MessageBox.Show("Fetch: lat:" + lat.ToString() + " lon:" + lon.ToString() + " GeoTiff:" + geoTiff.ToString());
            if (geoTiff != null)
            {
                //Int32 tileW = (Int32)(lat / ucNewProjectSettings.gTiff.DW) + (15152 / 2);//+ (Int32)(ucNewProjectSettings.gTiff.NWidth * 2);//* Math.Abs(ucNewProjectSettings.gTiff.DH)) / 2);
                //Int32 tileH = (Int32)(lon / ucNewProjectSettings.gTiff.DH) + (6580 / 2);//+ (Int32)(ucNewProjectSettings.gTiff.NWidth * 2);//* Math.Abs(ucNewProjectSettings.gTiff.DW)) / 2);
                Int32 tileW = (Int32)(lat / geoTiff.DW) + adjustE + ((Int32)((geoTiff.NWidth / 2)));//* Math.Abs(ucNewProjectSettings.gTiff.DH)) / 2);
                Int32 tileH = (Int32)(lon / geoTiff.DH) + adjustN + ((Int32)((geoTiff.NHeight / 2)));//* Math.Abs(ucNewProjectSettings.gTiff.DW)) / 2);

                //MessageBox.Show("getHeightForLatLon: lat:" + lat.ToString() + " lon:" + lon.ToString() + ", TileE:" + tileW.ToString() + "TileN:" + tileH.ToString());

                Int32 width = (tileW >= geoTiff.NWidth) ? (geoTiff.NWidth - 1) : tileW;
                if (width < 0) width = 0;
                Int32 height = (tileH >= geoTiff.NHeight) ? (geoTiff.NHeight - 1) : tileH;
                if (height < 0) height = 0;
                return geoTiff.HeightMap[width, height] - zeroHeight;

            }
            else
            {
                return 18.0;
            }
        }

        private double GetWaveHeight(double latitude, double longitude)
        {
            return (Math.Sin(latitude * 0.01) + Math.Sin(longitude * 0.01)) * HeightMultiplier;
        }

        public List<GameEngines> GetSupportedEngines()
        {
            List<GameEngines> support = new List<GameEngines>();
            support.Add(GameEngines.None);
            support.Add(GameEngines.AssettoCorsa);
            support.Add(GameEngines.rFactor);
            return support;
        }

        /// <summary>
        /// This is called when RTB Saves a project. Use it to store values that are specific to this project, that can then be reloaded via the Load() function.
        /// </summary>
        /// <param name="xml"></param>
        public void Save(string filename)
        {
            // Replace existing file if it exists.
            if (File.Exists(filename)) File.Delete(filename);

            // Create new file.
            using (FileStream fs = File.Create(filename))
            {
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
                {
                    bw.Write(geoTiffFileName);
                    bw.Write(adjustE);
                    bw.Write(adjustN);
                    bw.Write(adjustHeight);
                }
            }
        }

        /// <summary>
        /// This is called when RTB loads an existing project. Use it to load values specific to this project.
        /// </summary>
        /// <param name="xmlNode"></param>
        public void Load(string filename)
        { 
            if (!File.Exists(filename)) return;
            using (FileStream fs = File.OpenRead(filename))
            {
                using (BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8))
                {
                    geoTiffFileName = br.ReadString();
                    adjustE = br.ReadInt32();
                    adjustN = br.ReadInt32();
                    //adjustHeight = br.ReadSingle();
                }
            }
            LoadGeoTiff(geoTiffFileName);
            MessageBox.Show("Loaded file : " + geoTiffFileName);
        }
        public void LoadGeoTiff(String filename)
        {
            geoTiff = new GeoTIFFReader.GeoTIFF(filename);
            zeroHeight = geoTiff.HeightMap[(int)(geoTiff.NWidth / 2.0), (int)(geoTiff.NHeight / 2.0)] + adjustHeight;
        }
    }
}
