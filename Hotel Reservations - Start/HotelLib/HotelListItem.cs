using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class HotelListItem
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public double Rating { get; set; }
        public Room Room { get; set; }

        public List<Room> Roomlist;

        public HotelListItem(String ID, String Name, double Rating)
        {
            this.ID = ID;
            this.Name = Name;
            this.Rating = Rating;
            Roomlist = new List<Room>();
        }

        public HotelListItem () { }

        public void addRoom(Room m)
        {
            Roomlist.Add(m);
        }

    }
}
