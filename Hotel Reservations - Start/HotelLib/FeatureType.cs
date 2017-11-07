using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class FeatureType
    {
        public bool laundry { get; set; }
        public bool aircon { get; set; }
        public bool breakfest { get; set; }
        public bool shuttle { get; set; }

        public DistanceType Distance { get; set; }


        public FeatureType(bool laundry, bool aircon, bool breakfast, bool shuttle, DistanceType Distance)
        {
            this.laundry = laundry;
            this.aircon = aircon;
            this.breakfest = breakfest;
            this.shuttle = shuttle;
            this.Distance = Distance;

        }

        public FeatureType() { }
    }
}
