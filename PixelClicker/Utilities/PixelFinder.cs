using System.Drawing;
using WindowsWrapper.Graphics;

namespace PixelClicker.Utilities
{
    public class PixelFinder : IPixelFinder
    {
        public Point? FindPixelPosition(IVideoDisplay videoDisplay, Color pixelColour)
        {
            pixelColour = Color.FromArgb(0, pixelColour);
            Bitmap screenshot = videoDisplay.GetAsImage();

            screenshot.Save(@"E:\test.bmp");

            Point? pixelPosition = null;

            for (int widthIndex = 0; widthIndex < screenshot.Width && pixelPosition == null; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < screenshot.Height && pixelPosition == null; heightIndex++)
                {
                    Color pixel = screenshot.GetPixel(widthIndex, heightIndex);
                    pixel = Color.FromArgb(0, pixel);

                    bool isPixelMatch = pixel.Equals(pixelColour);

                    if (isPixelMatch)
                    {
                        pixelPosition = new Point(widthIndex, heightIndex);
                    }
                }
            }

            return pixelPosition;
        }
    }
}
