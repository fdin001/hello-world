using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Room
    {
        public String Type { get; set; }
        public double DailyRate { get; set; }
        public int Capacity { get; set; }



        public Room(String Type, double DailyRate, int Capacity)
        {
            this.Type = Type;
            this.DailyRate = DailyRate;
            this.Capacity = Capacity;
        }

        public Room() { }
        
    }
}
