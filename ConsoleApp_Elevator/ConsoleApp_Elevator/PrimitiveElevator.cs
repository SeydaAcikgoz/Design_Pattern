using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Elevator
{
    public class PrimitiveElevator
    {
        private bool DoorOpen = false;
        private int CurrentFloor = 1;
        private int Weight = 0;

        private readonly int CAPACITY = 1000;
        private readonly int TOP_FLOOR = 5;
        private readonly int BOTTOM_FLOOR = 1;

        public void OpenDoor()
        {
            if (!DoorOpen)
                DoorOpen = true;
            else
                Console.WriteLine("door already open");
        }

        private void CalculateCapacity()
        {
            Weight = 200;
        }

        public void CloseDoor()
        {
            CalculateCapacity();

            if (Weight < CAPACITY)
                DoorOpen = false;

            else
                Console.WriteLine("kapasite taştı");
        }

        public int GetFloor()
        {
            return CurrentFloor;
        }

        public bool GetDoorStatus()
        {
            return DoorOpen;
        }

        public void GoUp() // kapıyı kim kapatmalı
        {
            if (!DoorOpen)
            {
                if (CurrentFloor < TOP_FLOOR)
                {
                    CurrentFloor++;
                    Console.WriteLine("yukarı kata çıkıldı.");
                }
                else
                    Console.WriteLine("zaten en üst katta");
            }
            else
            {
                Console.WriteLine("kapı acık kardeşim!");
            }
        }

        public void GoDown()
        {
            if (CurrentFloor > BOTTOM_FLOOR)
            {
                CurrentFloor--;
                Console.WriteLine("aşağı kata İNİLDİ.");
            }
            else
            {
                Console.WriteLine("ZATEN EN AŞAĞIDAYIZ..");
            }
        }

        public void Go(int destination) // negatif kata gidebilir?
        {
            if (destination <= TOP_FLOOR && destination >= BOTTOM_FLOOR)
            {
                while (CurrentFloor != destination)
                {
                    if (CurrentFloor < destination)
                    {
                        GoUp();
                    }
                    else
                    {
                        GoDown();
                    }
                }
            }
            else
            {
                Console.WriteLine("sınırları astık galiba...");
            }
        }
    }
}
