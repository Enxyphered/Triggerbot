using System.Drawing;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace Cinnamine
{
    public class PixelScanner
    {
        public Color CurrentColour { get; private set; }
        public delegate void OnCurrentColourUpdate(Color currentColor);
        public event OnCurrentColourUpdate CurrentColourUpdatedEvent;
        public InputSimulator sim = new InputSimulator();
        
        public void ToggleScanner(int x, int y)
        {
            isActive = !isActive;

            if (isActive)
                Task.Factory.StartNew(() => Scan(x,y));
        }

        private bool isActive = false;
        private void Scan(int x, int y)
        {
            var pr = new PixelReader();

            while (isActive)
            {
                if (!sim.InputDeviceState.IsHardwareKeyDown(VirtualKeyCode.SHIFT))
                {
                    CurrentColour = pr.GetPixel(x, y);
                    CurrentColourUpdatedEvent.Invoke(CurrentColour);
                }
            }
        }
    }
}
