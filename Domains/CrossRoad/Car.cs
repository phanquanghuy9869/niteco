using Niteco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Domains.CrossRoad
{
    public class Car
    {
        public string Name { get; private set; }
        public int LeavingRoadSpeed { get; private set; }
        public Intersection StartingIntersection { get; private set; }

        public Car(string name, int leavingRoadSpeed, Intersection startingIntersection)
        {
            Name = name;
            LeavingRoadSpeed = leavingRoadSpeed;
            StartingIntersection = startingIntersection;
        }
    }
}
