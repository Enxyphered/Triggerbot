using System.Drawing;

namespace Cinnamine
{
    public class NormalConfig : ParsableDynamicObject
    {
        public int XPos
        {
            get => (int)Dictionary["xpos"];
            set => Dictionary["xpos"] = (int)value;
        }

        public int YPos
        {
            get => (int)Dictionary["ypos"];
            set => Dictionary["ypos"] = (int)value;
        }

        public Color PrimaryMin
        {
            get => Dictionary["pmin"];
            set => Dictionary["pmin"] = value;
        }

        public Color PrimaryMax
        {
            get => Dictionary["pmax"];
            set => Dictionary["pmax"] = value;
        }

        public Color SecondaryMin
        {
            get => Dictionary["smin"];
            set => Dictionary["smin"] = value;
        }

        public Color SecondaryMax
        {
            get => Dictionary["smax"];
            set => Dictionary["smax"] = value;
        }

        public int Interval
        {
            get => (int)Dictionary["interval"];
            set => Dictionary["interval"] = (int)value;
        }

        public NormalConfig(int xPos, int yPos, Color pMin, Color pMax, Color sMin, Color sMax, int interval)
        {
            XPos = xPos;
            YPos = yPos;
            PrimaryMin = pMin;
            PrimaryMax = pMax;
            SecondaryMin = sMin;
            SecondaryMax = sMax;
            Interval = interval;
        }

        public override void Parse()
        {

        }
    }
}
