using System;
using System.Drawing;
using WindowsInput;

namespace Cinnamine
{
    public class NormalAction : ITriggeredAction
    {
        Color color;
        NormalConfig config;
        InputSimulator sim = new InputSimulator();
        DateTime LastShot = DateTime.Now;

        public void OnColourUpdate(Color color, ParsableDynamicObject config)
        {
            this.color = color;
            this.config = (NormalConfig)config;
            this.config.Parse();

            DoAction();
        }

        private void DoAction()
        {
            if(GreaterThanOrEqualToPrimaryMin & LessThanOrEqualToPrimaryMax)
            {
                //Primary Color Match

                var now = DateTime.Now;
                if ((now - LastShot).TotalMilliseconds < config.Interval)
                    return;

                sim.Mouse.LeftButtonClick();
                LastShot = now;
            }
            else if (GreaterThanOrEqualToSecondaryMin & LessThanOrEqualToSecondaryMax)
            {
                //Secondary Color Match

                var now = DateTime.Now;
                if ((now - LastShot).TotalMilliseconds < config.Interval)
                    return;

                sim.Mouse.LeftButtonClick();
                LastShot = now;
            }
        }

        private bool GreaterThanOrEqualToPrimaryMin => config.PrimaryMin.R <= color.R & 
            config.PrimaryMin.G <= color.G & 
            config.PrimaryMin.B <= color.B;

        private bool LessThanOrEqualToPrimaryMax => config.PrimaryMax.R >= color.R &
            config.PrimaryMax.G >= color.G &
            config.PrimaryMax.B >= color.B;

        private bool GreaterThanOrEqualToSecondaryMin => config.SecondaryMin.R <= color.R &
            config.SecondaryMin.G <= color.G &
            config.SecondaryMin.B <= color.B;

        private bool LessThanOrEqualToSecondaryMax => config.SecondaryMax.R >= color.R &
            config.SecondaryMax.G >= color.G &
            config.SecondaryMax.B >= color.B;
    }
}
