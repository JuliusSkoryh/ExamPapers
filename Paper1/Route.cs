using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper1
{
    public record Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int RouteNumber { get; set; }

        public Route(string startPoint, string endPoint, int routeNumber)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            RouteNumber = routeNumber;
        }       
    }
}
