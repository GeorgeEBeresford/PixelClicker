using System.Drawing;
using WindowsWrapper.Graphics;

namespace PixelClicker.Utilities
{
    public interface IPixelFinder
    {
        Point? FindPixelPosition(IVideoDisplay videoDisplay, Color pixelColour);
    }
}
