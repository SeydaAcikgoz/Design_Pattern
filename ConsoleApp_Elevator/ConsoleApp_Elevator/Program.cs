using System;

namespace ConsoleApp_Elevator
{
    class Program
    {

        static void RunEncapsulatedElevator()
        {
            EncapsulatedElevator elevator = new EncapsulatedElevator();

            elevator.OpenDoor();
            elevator.GoDown();
            elevator.Go(FloorType.FOURTH);
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.Go(FloorType.FIFTH);
            elevator.GoUp();
            elevator.GoUp();
            elevator.GoUp();
            elevator.OpenDoor();

        }

        static void RunPrimitiveElevator()
        {
            PrimitiveElevator elevator = new PrimitiveElevator();

            elevator.OpenDoor();
            elevator.CloseDoor();
            elevator.Go(-2);
            elevator.GoUp();
            elevator.GoDown();
            elevator.GoUp();
            elevator.GoUp();
            elevator.GoDown();
            elevator.GoDown();
            elevator.GoDown();
            elevator.Go(2);
            elevator.CloseDoor();
            elevator.GoUp();

            int curFloor = elevator.GetFloor();

            if (curFloor != 5 && elevator.GetDoorStatus())
            {
                elevator.Go(5);
            }
        }



        static void RunDataOnlyElevator()
        {
            DataOnlyElevator elevator = new DataOnlyElevator();

            elevator.currentFloor--;
            elevator.currentFloor++;
            elevator.currentFloor = 5;
            elevator.currentFloor = -200;
            elevator.doorOpen = false;
            elevator.doorOpen = true;
            elevator.weight = 20;
        }





        static void RunGetterSetterElevator()
        {
            GetterSetterElevator elevator = new GetterSetterElevator();

            elevator.CurrentFloor--;
            elevator.CurrentFloor++;
            elevator.CurrentFloor = -20;
            elevator.DoorOpen = false;
            elevator.DoorOpen = true;
            elevator.Weight = 20;
        }


        static void Main(string[] args)
        {

            // RunDataOnlyElevator();
            //RunGetterSetterElevator();
            RunPrimitiveElevator();
            //RunEncapsulatedElevator();
            Console.Read();
        }
    }
}
