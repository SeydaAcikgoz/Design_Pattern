using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Elevator_Responsible
{
    public interface Elevator
    {

        public void go(Floor desiredFloor);

        public void openDoor();

        public void closeDoor();

    }
}
