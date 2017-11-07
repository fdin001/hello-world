using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class RoomType
    {
        public String id { get; set; }
        public String name { get; set; }

        public RoomType(string ID, String Name)
        {
            this.id = ID;
            this.name = Name;
        }

        public RoomType() { }

    }
}
