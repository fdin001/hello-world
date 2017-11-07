using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class DistanceType
    {
        public double beach { get; set; }
        public double shopping { get; set; }
        public double airport { get; set; }

        public DistanceType() { }

        public DistanceType(double beach, double shopping, double airport)
        {
            this.beach = beach;
            this.shopping = shopping;
            this.airport = airport;
        }
    }
}
