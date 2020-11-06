using System.Drawing;
using WindowsWrapper.Graphics;

namespace PixelClicker.Utilities
{
    public class ColourPicker : IColourPicker
    {
        public Color GetFromDisplayPosition(IVideoDisplay display, Point position)
        {
            Color pixel = display.GetPixel(position);

            return pixel;
        }
    }
}