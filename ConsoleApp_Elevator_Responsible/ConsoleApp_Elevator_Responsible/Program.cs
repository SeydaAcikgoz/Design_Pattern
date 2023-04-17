using System.Drawing;

namespace ConsoleApp_Elevator_Responsible
{
    class Program
    {
        public static void Main(String[] args)
        {

            Elevator elevator = new ResponsibleElevator();
            elevator.openDoor();  // Get into the elevator
            elevator.go(Floor.FIFTH);

            elevator.openDoor(); // Somebody is coming :)
            elevator.go(Floor.FIRST);
            elevator.go(Floor.FIFTH);
        }
    }
}