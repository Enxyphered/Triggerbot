using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Cinnamine
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private static Color DefaultColor => Color.FromArgb(0);
        private NormalConfig config =
            new NormalConfig(0, 0, DefaultColor, DefaultColor, DefaultColor, DefaultColor, 1000);
        private PixelScanner scanner = new PixelScanner();
        private ITriggeredAction action = new NormalAction();

        public Form1()
        {
            InitializeComponent();
            scanner.CurrentColourUpdatedEvent += Scanner_CurrentColourUpdatedEvent;
        }
        
        private void OnStartBtnClick(object sender, EventArgs e)
        {
            ToggleStartBtnText();
            UpdateConfig();
            scanner.ToggleScanner((config).XPos, (config).YPos);
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            UpdateConfig();
            var jsonString = JsonConvert.SerializeObject(config);
            File.WriteAllText("Config", jsonString);
        }

        private void LoadBtnClick(object sender, EventArgs e)
        {
            UpdateConfig();
            string jsonString;
            LoadJsonString(out jsonString);
            if (String.IsNullOrWhiteSpace(jsonString))
                return;

            config = JsonConvert.DeserializeObject<NormalConfig>(jsonString);
            UpdateConfigUI();

        }

        private void UpdateConfig()
        {
            int x, y, interval;
            Color pMax, pMin, sMax, sMin;

            GetPos(out x, out y);
            GetPrimaryMax(out pMax);
            GetPrimaryMin(out pMin);
            GetSecondaryMax(out sMax);
            GetSecondaryMin(out sMin);
            GetInterval(out interval);

            config.XPos = x;
            config.YPos = y;
            config.PrimaryMax = pMax;
            config.SecondaryMax = sMax;
            config.PrimaryMin = pMin;
            config.SecondaryMin = sMin;
            config.Interval = interval;
        }

        private void UpdateConfigUI()
        {
            XPosTB.Text = config.XPos.ToString();
            YPosTB.Text = config.YPos.ToString();

            PMinRTB.Text = config.PrimaryMin.R.ToString();
            PMinGTB.Text = config.PrimaryMin.G.ToString();
            PMinBTB.Text = config.PrimaryMin.B.ToString();

            PMaxRTB.Text = config.PrimaryMax.R.ToString();
            PMaxGTB.Text = config.PrimaryMax.G.ToString();
            PMaxBTB.Text = config.PrimaryMax.B.ToString();

            SMinRTB.Text = config.SecondaryMin.R.ToString();
            SMinGTB.Text = config.SecondaryMin.G.ToString();
            SMinBTB.Text = config.SecondaryMin.B.ToString();

            SMaxRTB.Text = config.SecondaryMax.R.ToString();
            SMaxGTB.Text = config.SecondaryMax.G.ToString();
            SMaxBTB.Text = config.SecondaryMax.B.ToString();

            IntervalTB.Text = config.Interval.ToString();
        }

        private void ToggleStartBtnText()
        {
            if (StartBtn.Text == "Start")
                StartBtn.Text = "Stop";
            else
                StartBtn.Text = "Start";
        }

        private void LoadJsonString(out string jsonString)
        {
            try
            {
                jsonString = File.ReadAllText("Config");
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
                jsonString = "";
            }
        }
        private void GetPos(out int x, out int y)
        {
            try
            {
                x = Convert.ToInt32(XPosTB.Text);
                y = Convert.ToInt32(YPosTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid position. Resetting to default.");
                XPosTB.Text = "0";
                YPosTB.Text = "0";
                x = 0;
                y = 0;
            }
        }
        private void GetPrimaryMax(out Color pMax)
        {
            try
            {
                var r = Convert.ToInt32(PMaxRTB.Text);
                var g = Convert.ToInt32(PMaxGTB.Text);
                var b = Convert.ToInt32(PMaxBTB.Text);

                pMax = Color.FromArgb(r, g, b);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Primary Max. Resetting to default.");
                PMaxRTB.Text = "0";
                PMaxGTB.Text = "0";
                PMaxBTB.Text = "0";

                pMax = Color.FromArgb(0, 0, 0);
            }
        }
        private void GetPrimaryMin(out Color pMin)
        {
            try
            {
                var r = Convert.ToInt32(PMinRTB.Text);
                var g = Convert.ToInt32(PMinGTB.Text);
                var b = Convert.ToInt32(PMinBTB.Text);

                pMin = Color.FromArgb(r, g, b);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Primary Min. Resetting to default.");
                PMinRTB.Text = "0";
                PMinGTB.Text = "0";
                PMinBTB.Text = "0";

                pMin = Color.FromArgb(0, 0, 0);
            }
        }
        private void GetSecondaryMax(out Color sMax)
        {
            try
            {
                var r = Convert.ToInt32(SMaxRTB.Text);
                var g = Convert.ToInt32(SMaxGTB.Text);
                var b = Convert.ToInt32(SMaxBTB.Text);

                sMax = Color.FromArgb(r, g, b);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Secondary Max. Resetting to default.");
                SMaxRTB.Text = "0";
                SMaxGTB.Text = "0";
                SMaxBTB.Text = "0";

                sMax = Color.FromArgb(0, 0, 0);
            }
        }
        private void GetSecondaryMin(out Color sMin)
        {
            try
            {
                var r = Convert.ToInt32(SMinRTB.Text);
                var g = Convert.ToInt32(SMinGTB.Text);
                var b = Convert.ToInt32(SMinBTB.Text);

                sMin = Color.FromArgb(r, g, b);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Secondary Min. Resetting to default.");
                SMinRTB.Text = "0";
                SMinGTB.Text = "0";
                SMinBTB.Text = "0";

                sMin = Color.FromArgb(0, 0, 0);
            }
        }
        private void GetInterval(out int interval)
        {
            try
            {
                interval = Convert.ToInt32(IntervalTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Interval. Resetting to default.");
                IntervalTB.Text = "1000";
                interval = 1000;
            }
        }
        private void Scanner_CurrentColourUpdatedEvent(Color currentColor)
        {
            action.OnColourUpdate(currentColor, config);
        }
        
    }
}
