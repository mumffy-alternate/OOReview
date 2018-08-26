using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    public interface IElevatorController
    {
        void SendTo(int floorNumber);
        void NotifyArrival();
    }
}