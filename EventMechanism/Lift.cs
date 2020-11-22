using System;

namespace EventMechanism
{
    delegate void EventHandler(string commandType, string direction, int quantity);
    class Lift : EventArgs
    {
        public static event EventHandler LiftEvents;

        public Lift()
        { }

        public void LiftUp(string commandType, string direction, int quantity)
        {
            if (commandType.Equals("Move"))
            {
                if (direction.Equals("LiftUp"))
                    Console.WriteLine("Lift is up " + quantity);
            }
        }
        public void LiftDown(string commandType, string direction, int quantity)
        {
            if (commandType.Equals("Move"))
            {
                if (direction.Equals("LiftDown"))
                    Console.WriteLine("Lift is down " + quantity);
            }
        }
        public void LiftForward(string commandType, string direction, int quantity)
        {
            if (commandType.Equals("Move"))
            {
                if (direction.Equals("LiftForward"))
                    Console.WriteLine("Lift is forward " + quantity);
            }
        }
        public void LiftBackward(string commandType, string direction, int quantity)
        {
            if (commandType.Equals("Move"))
            {
                if (direction.Equals("LiftBackward"))
                    Console.WriteLine("Lift is backward " + quantity);
            }
        }
        public void LiftStop(string commandType, string direction, int quantity)
        {
            if (commandType.Equals("Stop"))
            {
                Console.WriteLine("Lift is stopped ");
            }
        }

        public void AddLiftMovings()
        {
            //LiftEvents += LiftUp;
            LiftEvents += LiftDown;
            LiftEvents += LiftForward;
            //LiftEvents += LiftBackward;
            LiftEvents += LiftStop;

            Console.WriteLine("Movings added ");
        }

        public void ExecuteLiftEventsAccordingToInput(string commandType, string direction, int quantity)
        {
            LiftEvents(commandType, direction, quantity);
        }
    }
}


