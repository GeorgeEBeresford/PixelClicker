using System.Drawing;
using WindowsWrapper.Graphics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.WindowsWrapper
{
    [TestClass]
    public class WindowsCursorTest
    {
        [TestMethod]
        public void GetPosition()
        {
            Point cursorPosition = WindowsCursor.GetPosition();
            Assert.AreNotEqual(new Point(0, 0), cursorPosition);
        }

        [TestMethod]
        public void LeftClick()
        {
            WindowsApplication currentApplication = WindowsApplication.GetForeground();

            bool isSuccess = WindowsCursor.LeftClick((int)currentApplication.Handle, 0, 0);

            Assert.IsTrue(isSuccess);
        }

        private readonly WindowsCursor WindowsCursor = new WindowsCursor();
    }
}
