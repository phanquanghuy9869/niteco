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
    /// It contains 4 trafficlights, and 1 processing car
    /// </summary>
    public class CrossRoad
    {
        public Car ProcessingCar { get; private set; }
        public bool PreceedingCarHasLeft {get; private set;}
        public Car[] Cars { get; private set; }
        private TrafficLight[] _trafficLights;

        /// <summary>
        /// Initialization of a cross road with trafficlights and cars
        /// </summary>
        /// <param name="x1Color">Starting color of traffic lights</param>
        /// <param name="x2Color">Starting color of traffic lights/param>
        /// <param name="leavingSpeed">How fast cars leave crossroad</param>
        public CrossRoad(TrafficLightColor x1Color, TrafficLightColor x2Color, int leavingSpeed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A car arrive to crossroads from a start intersection
        /// </summary>
        /// <param name="startIntersection"></param>
        public void CarArrive(Intersection startIntersection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A car leaves crossroads
        /// </summary>
        public void CarLeave()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crossroad change it's trafficlights's color
        /// </summary>
        public void ChangeTrafficLightColor()
        {
            throw new NotImplementedException();
        }
    }
}
