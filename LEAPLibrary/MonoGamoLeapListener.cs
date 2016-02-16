using System;
using System.Threading;
using Leap;


namespace LeapLibrary
{
    class MonoGameLeapListener : Listener
    {
        private Object thisLock = new Object(); //had to revert back to old version if Leap SDK new version thros PInoke Exception also needed to compile with .NET 4.5 this could be why

        

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnInit(Controller controller)
        {
            //SafeWriteLine("Initialized");
        }

        public override void OnConnect(Controller controller)
        {
            //SafeWriteLine("Connected");
            controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPEKEYTAP);
            controller.EnableGesture(Gesture.GestureType.TYPESCREENTAP);
            controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
        }

        public override void OnDisconnect(Controller controller)
        {
            //SafeWriteLine("Disconnected");
        }

        public override void OnExit(Controller controller)
        {
            //SafeWriteLine("Exited");
        }

        public override void OnFrame(Controller controller)
        {
            
        }
             
    }
}
