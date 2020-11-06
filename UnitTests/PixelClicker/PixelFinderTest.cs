using System.Drawing;
using WindowsWrapper.Graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PixelClicker.Utilities;

namespace UnitTests.PixelClicker
{
    [TestClass]
    public class PixelFinderTest
    {
        private readonly PixelFinder PixelFinder = new PixelFinder();

        [TestMethod]
        public void FindPixelPosition()
        {
            IVideoDisplay videoDisplay = new WindowsDisplay();
            ICursor cursor = new WindowsCursor();
            IColourPicker colorPicker = new ColourPicker();
            Color colourAtCursor = colorPicker.GetFromDisplayPosition(videoDisplay, cursor.GetPosition());
            var point = PixelFinder.FindPixelPosition(videoDisplay, colourAtCursor);

            Assert.IsNotNull(point, "Could not find the pixel you were hovering over on the screen.");
        }
    }
}