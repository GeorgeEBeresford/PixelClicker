using System.Drawing;

namespace PixelClicker.Utilities
{
    public interface IClicker
    {
        bool Click(int windowHandle, int positionX, int positionY);
        bool Click(int windowHandle, Point position);
    }
}
