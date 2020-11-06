using System.Drawing;
using WindowsWrapper.Graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PixelClicker.Utilities;

namespace UnitTests.PixelClicker
{
    [TestClass]
    public class ColourPickerTest
    {
        private readonly ColourPicker ColourPicker = new ColourPicker();

        [TestMethod]
        public void GetFromDisplayPosition()
        {
            IVideoDisplay videoDisplay = new WindowsScreen();
            ICursor cursor = new WindowsCursor();
            Point cursorPosition = cursor.GetPosition();
            Color colourAtCursor = ColourPicker.GetFromDisplayPosition(videoDisplay, cursorPosition);

            Assert.IsNotNull(colourAtCursor);
        }
    }
}