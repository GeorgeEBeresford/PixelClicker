using System.Drawing;
using WindowsWrapper.Graphics;

namespace PixelClicker.Utilities
{
    public interface IColourPicker
    {
        Color GetFromDisplayPosition(IVideoDisplay display, Point position);
    }
}
