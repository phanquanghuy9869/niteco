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
        public Intersection StartIntersection { get; private set; }
        public Intersection TargetIntersection { get; private set; }
    }
}
