using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Elevator
{
    public class EncapsulatedElevator
    {
        private bool DoorOpen = false;
        private Floor currentFloor = new Floor();

        private int Weight = 0;
        private readonly int CAPACITY = 1000;

        public EncapsulatedElevator()
        {
            currentFloor.SetFloor(FloorType.ENTRANCE);
        }

        public void OpenDoor()
        {
            if (!DoorOpen)
                DoorOpen = true;
            else
                Console.WriteLine("door already open");
        }

        private void CalculateCapacity()
        {
            Weight = 20;
        }

        public void CloseDoor()
        {
            CalculateCapacity();

            if (Weight < CAPACITY)
                DoorOpen = false;

            else
                Console.WriteLine("kapasite taştı");
        }

        public FloorType GetFloor()
        {
            return currentFloor.GetFloorType();
        }

        public bool GetDoorStatus()
        {
            return DoorOpen;
        }

        public void GoUp() // kapıyı kim kapatmalı
        {
            if (DoorOpen)
                CloseDoor();

            if (currentFloor.GetFloorType().CompareTo(FloorType.FIFTH) < 0)
            {
                currentFloor.GoUp();
                Console.WriteLine("yukarı kata çıkıldı.");
            }
            else
            {
                Console.WriteLine("ZATEN EN ÜST KATTA! ");
            }
            OpenDoor();
        }

        public void GoDown()
        {
            if (DoorOpen)
                CloseDoor();

            if (currentFloor.GetFloorType().CompareTo(FloorType.ENTRANCE) > 0)
            {
                currentFloor.GoDown();
                Console.WriteLine("aşağı kata İNİLDİ.");
            }
            else
            {
                Console.WriteLine("ZATEN EN AŞAĞIDAYIZ..");
            }

            OpenDoor();
        }

        public void Go(FloorType destination) // negatif kata gidebilir?
        {
            int compare = currentFloor.GetFloorType().CompareTo(destination);

            while (compare != 0)
            {
                if (compare < 0)
                {
                    GoUp();
                }
                else
                {
                    GoDown();
                }
                compare = currentFloor.GetFloorType().CompareTo(destination);
            }
        }
    }
}
