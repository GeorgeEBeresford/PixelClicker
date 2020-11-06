using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WindowsWrapper.Graphics;
using Gma.System.MouseKeyHook;
using PixelClicker.Utilities;

namespace PixelClicker.Services
{
    public class ClickerService : IClickerService
    {
        private IKeyboardMouseEvents MouseObservable { get; set; }
        private bool IsClickingEnabled { get; set; }

        public void Start()
        {
            MouseObservable = Hook.GlobalEvents();
            MouseObservable.KeyPress += StartClicking;
        }

        public void Reset()
        {
            IsClickingEnabled = false;
        }

        private void StartClicking(object sender, KeyPressEventArgs keyEventArguments)
        {
            if (keyEventArguments.KeyChar == 'p' && !IsClickingEnabled)
            {
                IColourPicker colourPicker = new ColourPicker();
                IVideoDisplay display = new WindowsScreen();
                IVideoDisplay currentWindow = WindowsApplication.GetForeground();
                ICursor cursor = new WindowsCursor();
                Color colour = colourPicker.GetFromDisplayPosition(display, cursor.GetPosition());
                IPixelFinder pixelFinder = new PixelFinder();

                IClicker clicker = new Clicker();

                Thread clickingThread = new Thread(() =>
                {
                    IsClickingEnabled = true;
                    while (IsClickingEnabled)
                    {
                        var clickedPosition = pixelFinder.FindPixelPosition(currentWindow, colour);

                        if (clickedPosition.HasValue) clicker.Click((int) currentWindow.Handle, clickedPosition.Value);

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                    }
                });

                clickingThread.Start();
            }
        }
    }
}