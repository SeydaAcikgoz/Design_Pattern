using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Elevator
{
    public class GetterSetterElevator // tip sorunu engellendi
    {
        public bool DoorOpen { get; set; } = false;
        public int CurrentFloor { get; set; } = 1;
        public int Weight { get; set; } = 0;

        public readonly int CAPACITY = 1000;
        public readonly int TOP_FLOOR = 5;
        public readonly int BOTTOM_FLOOR = 1;
    }
}
