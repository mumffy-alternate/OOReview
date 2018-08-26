using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public class MyElevator

    {
        public IElevatorController IElevatorController
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void GoTo(int floorNumber)
        {
            throw new System.NotImplementedException();
        }

        public void ArriveAtFloor()
        {
            throw new System.NotImplementedException();
        }
    }
}