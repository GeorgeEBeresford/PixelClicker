using System.Drawing;
using WindowsWrapper.Graphics;

namespace PixelClicker.Utilities
{
    public class Clicker : IClicker
    {
        private readonly ICursor Cursor = new WindowsCursor();

        public bool Click(int windowHandle, int positionX, int positionY)
        {
            bool isSuccess = Cursor.LeftClick(windowHandle, positionX, positionY);
            return isSuccess;
        }

        public bool Click(int windowHandle, Point position)
        {
            bool isSuccess = Click(windowHandle, position.X, position.Y);
            return isSuccess;
        }
    }
}