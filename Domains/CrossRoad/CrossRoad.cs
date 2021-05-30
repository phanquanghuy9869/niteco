using Niteco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Domains.CrossRoad
{
    /// <summary>
    /// Object model of cross road
    /// It includes 4 traffic light and 1 processing car
    /// </summary>
    public class CrossRoad
    {
        public Car ProcessingCar { get; private set; }
        public TrafficLight North { get; private set; }
        public TrafficLight South { get; private set; }
        public TrafficLight West { get; private set; }
        public TrafficLight East { get; private set; }
        private bool PreceedingCarHasLeft;

        public CrossRoad(TrafficLightColor x1PeriodColor, TrafficLightColor x2PeriodColor)
        {
            North = new TrafficLight(Intersection.North, x1PeriodColor);
            South = new TrafficLight(Intersection.South, x1PeriodColor);
            West = new TrafficLight(Intersection.West, x2PeriodColor);
            East = new TrafficLight(Intersection.East, x2PeriodColor);
            PreceedingCarHasLeft = false;
        }


    }
}
