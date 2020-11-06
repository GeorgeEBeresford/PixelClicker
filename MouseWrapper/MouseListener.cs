using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace MouseWrapper
{
    public class MouseListener : IMouseListener
    {
        public Task<MouseEventArgs> WaitForClickAsync()
        {
            IKeyboardMouseEvents mouseObservable = Hook.GlobalEvents();
            MouseEventArgs mouseEventArguments = null;
            Task<MouseEventArgs> awaitedMouseEventArguments = new Task<MouseEventArgs>(() => mouseEventArguments);

            void ReturnMouseEventAction(object sender, MouseEventArgs mouseEventArgs)
            {
                mouseObservable.MouseClick -= ReturnMouseEventAction;
                mouseObservable.Dispose();

                mouseEventArguments = mouseEventArgs;
                awaitedMouseEventArguments.Start();
            }

            mouseObservable.MouseClick += ReturnMouseEventAction;

            return awaitedMouseEventArguments;
        }
    }
}