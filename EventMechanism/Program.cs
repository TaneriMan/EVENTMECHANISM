using System;

namespace EventMechanism
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift lift = new Lift();

            lift.AddLiftMovings();

            lift.ExecuteLiftEventsAccordingToInput("Move", "LiftUp", 5); //Lift is not in LiftEvents Lift.cs Line 59
            lift.ExecuteLiftEventsAccordingToInput("Move", "LiftDown", 1); //Lift Down is in LiftEvents Lift.cs Line 60
            lift.ExecuteLiftEventsAccordingToInput("Move", "LiftForward", 45); //LiftForward is in LiftEvents Lift.cs Line 61
            lift.ExecuteLiftEventsAccordingToInput("Move", "LiftBackward", 55); //LiftBackward is not in LiftEvents Lift.cs Line 62
            lift.ExecuteLiftEventsAccordingToInput("Stop", "LiftStop", 5); //LiftBackward is in LiftEvents Lift.cs Line 63




            Console.ReadLine();
        }
    }
}
