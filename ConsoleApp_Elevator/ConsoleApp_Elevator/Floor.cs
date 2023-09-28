using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Elevator
{
    public enum FloorType //java da enum içinde floor classı da tanımlanabilirken c# böyle olmuyor
    {
        ENTRANCE = 0, FIRST = 1, SECOND = 2, THIRD = 3, FOURTH = 4, FIFTH = 5
    }

    public class Floor
    {
        private FloorType FloorType;
        public void SetFloor(FloorType floorType)
        {
            this.FloorType = floorType;
        }
        public FloorType GetFloorType()
        {
            return this.FloorType;
        }

        public FloorType GoUp()
        {
            int currentFloor = (int)FloorType;

            if (currentFloor == 0)
            {
                FloorType = FloorType.FIRST;
            }
            if (currentFloor == 1)
            {
                FloorType = FloorType.SECOND;
            }
            else if (currentFloor == 2)
            {
                FloorType = FloorType.THIRD;
            }
            else if (currentFloor == 3)
            {
                FloorType = FloorType.FOURTH;
            }
            else if (currentFloor == 4)
            {
                FloorType = FloorType.FIFTH;
            }
            Console.WriteLine("go up " + FloorType.ToString());

            return FloorType;
        }

        public FloorType GoDown()
        {
            int currentFloor = (int)FloorType;

            if (currentFloor == 1)
            {
                FloorType = FloorType.ENTRANCE;
            }
            if (currentFloor == 2)
            {
                FloorType = FloorType.FIRST;
            }
            else if (currentFloor == 3)
            {
                FloorType = FloorType.SECOND;
            }
            else if (currentFloor == 4)
            {
                FloorType = FloorType.THIRD;
            }
            else if (currentFloor == 5)
            {
                FloorType = FloorType.FOURTH;
            }

            Console.WriteLine("go down: " + FloorType.ToString());

            return FloorType;
        }
    }
}
