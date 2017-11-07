using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLib
{
    public class Inventory
    {
        public string Date { get; set; }
        public string HotelID { get; set; }
        public string roomType { get; set; }
        public string Quantity { get; set; }

        public Inventory() { }

        public Inventory(string Date, string HotelID, string roomType,
                         string Quantity)
        {
            this.Date = Date;
            this.HotelID = HotelID;
            this.roomType = roomType;
            this.Quantity = Quantity;
        }
    }
}
