using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cinnamine
{
    class PixelReader
    {
        public bool Draw = true;

        public Color GetPixel(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            if (Draw)
                DrawRect(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);



            return color;
        }

        void DrawRect(IntPtr hdc, int x, int y)
        {
            using (Graphics g = Graphics.FromHdc(hdc))
            {
                SolidBrush b = new SolidBrush(Color.Red);
                g.FillRectangle(b, new Rectangle(x - 1, y - 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x, y - 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x - 1, y, 1, 1));
                g.FillRectangle(b, new Rectangle(x + 1, y - 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x + 1, y, 1, 1));
                g.FillRectangle(b, new Rectangle(x + 1, y + 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x, y + 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x - 1, y + 1, 1, 1));
                g.FillRectangle(b, new Rectangle(x - 1, y, 1, 1));
            }
        }
        
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("gdi32.dll")]
        static extern uint SetPixel(IntPtr hdc, int X, int Y, uint crColor);
    }
}
