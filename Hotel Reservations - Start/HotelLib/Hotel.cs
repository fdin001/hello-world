using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Hotel
    {
        public String ID { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public FeatureType Features { get; set; }
        public List<Room> Roomlist;

        public Hotel (String ID, String Name, String Address, FeatureType Features)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Features = Features;
            Roomlist = new List<Room>();

        }

        public Hotel() { }

        public void addRoom (Room m)
        {
            Roomlist.Add(m);
        }

    }
}
