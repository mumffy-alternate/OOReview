using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public class ElevatorBrain : IElevatorController
    {
        public IEnumerable<Elevator.MyElevator> Elevators
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public IEnumerable<Elevator.Floor> Floors
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void NotifyArrival()
        {
            throw new NotImplementedException();
        }

        public void SendTo(int floorNumber)
        {
            throw new NotImplementedException();
        }
    }
}