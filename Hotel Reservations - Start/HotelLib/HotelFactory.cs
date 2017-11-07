using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HotelLib
{
    public class HotelFactory
    {
        public List<Hotel> shotels;
        public List<RoomType> dsroomtypes;
        public List<HotelListItem> shotelist;

        public List<Inventory> InventoryType;

        public String filepathhotels = @"..\..\hotels.xml";
        public String filepathroominventory = @"..\..\roominventory.xml";
        public String filepathroomtypes = @"..\..\roomtypes.xml";
        public String filepathhotelitemlist = @"..\..\hotellistitem.xml";

        public String[] hotelID = { "000111", "000222", "000333", "000444", "000555",
                                    "000666", "000777", "000888", "000999", "111000"};

        public double[] ratings = { 4.0, 3.0, 2.5, 1.5, 4.5, 2.0,
                                    3.5, 5.0};

        StreamWriter sw;
        StreamReader sr;

        public string filepath;

        XmlSerializer serial;

        public void CreateHotelList()
        {
            shotels = new List<Hotel>();
            Hotel h;
            
            h = new Hotel("000111",
                          "Comfort Suites Miami",
                          "3901 SW 117th Ave, Miami, FL 33175",
                          new FeatureType(false, true, true, false,
                          new DistanceType(1.2, 0.5, 2.0)));
            h.addRoom(new Room("KB", 225, 3));
            h.addRoom(new Room("QB", 180, 3));
            h.addRoom(new Room("DB", 140, 3));
            h.addRoom(new Room("BS", 250, 3));

            shotels.Add(h);

            h = new Hotel("000222",
                          "Courtyard by Marriot Miami",
                          "11275 NW 12th ST, Miami, FL 33172",
                          new FeatureType(true, true, true, false,
                          new DistanceType(2.0, 0.2, 3.0)));
            h.addRoom(new Room("KB", 190, 3));
            h.addRoom(new Room("QB", 140, 3));
            h.addRoom(new Room("DB", 110, 3));
            h.addRoom(new Room("BS", 225, 3));

            shotels.Add(h);

            h = new Hotel("000333",
                          "Nuvo Suites Miami Airport West Doral",
                          "1750 NW 107th Ave, Miami, FL 33172",
                          new FeatureType(true, true, true, true,
                          new DistanceType(4.0, 2.0, 5.0)));
            h.addRoom(new Room("KB", 175, 3));
            h.addRoom(new Room("QB", 130, 3));
            h.addRoom(new Room("DB", 95, 3));
            h.addRoom(new Room("BS", 200, 3));

            shotels.Add(h);

            h = new Hotel("000444",
                          "Hilton Garden Inn Miami Dolphin Mall",
                          "1695 NW 111th Ave a, Miami, FL 33172",
                          new FeatureType(true, true, true, false,
                          new DistanceType(3.0, 1.5, 4.0)));
            h.addRoom(new Room("KB", 120, 3));
            h.addRoom(new Room("QB", 100, 3));
            h.addRoom(new Room("DB", 75, 3));
            h.addRoom(new Room("BS", 160, 3));

            shotels.Add(h);

            h = new Hotel("000555",
                          "Holiday Inn Miami-Doral Area",
                          "3255 NW 87th Ave, Miami, FL 33172",
                          new FeatureType(false, true, true, false,
                          new DistanceType(2.5, 1.5, 3.0)));
            h.addRoom(new Room("KB", 250, 3));
            h.addRoom(new Room("QB", 210, 3));
            h.addRoom(new Room("DB", 200, 3));
            h.addRoom(new Room("BS", 310, 3));

            shotels.Add(h);

            h = new Hotel("000666",
                          "InterContinental At Doral Miami",
                          "2505 NW 87th Ave, Doral, FL 33172",
                          new FeatureType(false, true, true, false,
                          new DistanceType(2.8, 1.5, 7.0)));
            h.addRoom(new Room("KB", 130, 3));
            h.addRoom(new Room("QB", 115, 3));
            h.addRoom(new Room("DB", 85, 3));
            h.addRoom(new Room("BS", 180, 3));

            shotels.Add(h);


            h = new Hotel("000777",
                          "Hotel Nuvo Suites",
                          "10760 NW 17th St, Miami, FL 33172",
                          new FeatureType(true, true, true, false,
                          new DistanceType(3.0, 2.0, 9.0)));
            h.addRoom(new Room("KB", 200, 3));
            h.addRoom(new Room("QB", 160, 3));
            h.addRoom(new Room("DB", 125, 3));
            h.addRoom(new Room("BS", 235, 3));

            shotels.Add(h);

            h = new Hotel("000888",
                          "Modern Cabin 1",
                          "12335 NW 6th St, Miami, FL 33182",
                          new FeatureType(true, true, false, false,
                          new DistanceType(1.5, 2.5, 9.2)));
            h.addRoom(new Room("KB", 100, 3));
            h.addRoom(new Room("QB", 160, 3));
            h.addRoom(new Room("DB", 210, 3));
            h.addRoom(new Room("BS", 400, 3));

            shotels.Add(h);

            h = new Hotel("000999",
                          "Marriott Residence Inn",
                          "NW 82nd Ave, Doral, FL 33126",
                          new FeatureType(true, true, false, true,
                          new DistanceType(1.8, 2.9, 7.5)));
            h.addRoom(new Room("KB", 99, 3));
            h.addRoom(new Room("QB", 75, 3));
            h.addRoom(new Room("DB", 9.99, 3));
            h.addRoom(new Room("BS", 140, 3));

            shotels.Add(h);

            h = new Hotel("111000",
                          "Marriott Private Inn",
                          "NE 22nd Ave, Brickel, FL 33126",
                          new FeatureType(true, true, false, true,
                          new DistanceType(1.8, 2.9, 7.5)));
            h.addRoom(new Room("KB", 260, 3));
            h.addRoom(new Room("QB", 200, 3));
            h.addRoom(new Room("DB", 150, 3));
            h.addRoom(new Room("BS", 280, 3));

            shotels.Add(h);

        }

        public void CreateHotelListItem()
        {
            int counterratings = 0;

            shotelist = new List<HotelListItem>();

            for (int y = 0; y < shotels.Count; y++)
            {
                HotelListItem s;

                if (counterratings > ratings.Length - 1)
                {
                    counterratings = 3;
                    
                }

                s = new HotelListItem(shotels[y].ID, shotels[y].Name, ratings[counterratings]);

                s.addRoom(new Room(transform(shotels[y].Roomlist[0].Type), shotels[y].Roomlist[0].DailyRate, 2));
                s.addRoom(new Room(transform(shotels[y].Roomlist[1].Type), shotels[y].Roomlist[1].DailyRate, 2));
                s.addRoom(new Room(transform(shotels[y].Roomlist[2].Type), shotels[y].Roomlist[2].DailyRate, 2));
                s.addRoom(new Room(transform(shotels[y].Roomlist[3].Type), shotels[y].Roomlist[3].DailyRate, 2));

                shotelist.Add(s);

                counterratings++;
            }
        }

        public void CreateInventoryList()
        {
            InventoryType = new List<Inventory>();

            DateTime dt = new DateTime(2017, 09, 01);

            for (int l = 0; l < 30; l++) {

                


                for (int k = 0; k < hotelID.Length; k++) {

                    Inventory i = new Inventory(dt.ToString("yyyy,mM,dd"), hotelID[k], "KB", "3");

                    InventoryType.Add(i);

                    i = new Inventory(dt.ToString("yyyy,mM,dd"), hotelID[k], "QB", "3");

                    InventoryType.Add(i);

                    i = new Inventory(dt.ToString("yyyy,mM,dd"), hotelID[k], "DB", "3");

                    InventoryType.Add(i);

                    i = new Inventory(dt.ToString("yyyy,mM,dd"), hotelID[k], "BS", "3");

                    InventoryType.Add(i);
                }

                dt = dt.AddDays(1);

            }


        }

        public Boolean SerializehotelList()
        {
            sw = new StreamWriter(filepathhotels);
            serial = new XmlSerializer(shotels.GetType());
            serial.Serialize(sw, shotels);
            sw.Close();

            return true;
        }

        public Boolean SerializeroominvenotryList()
        {
            sw = new StreamWriter(filepathroominventory);
            serial = new XmlSerializer(InventoryType.GetType());
            serial.Serialize(sw, InventoryType);
            sw.Close();

            return true;
        }

        public Boolean SerializenewList()
        {
            sw = new StreamWriter(filepathhotelitemlist);
            serial = new XmlSerializer(shotelist.GetType());
            serial.Serialize(sw, shotelist);
            sw.Close();

            return true;
        }

        public List<RoomType> DesirealizeRoomInventoryList()
        {
            dsroomtypes = new List<RoomType>();
            sr = new StreamReader(filepathroomtypes);
            serial = new XmlSerializer(dsroomtypes.GetType());
            dsroomtypes = (List<RoomType>)serial.Deserialize(sr);

            sr.Close();

            return dsroomtypes;
        }

        public List<Hotel> DesiralizeHotelList()
        {
            shotels = new List<Hotel>();
            sr = new StreamReader(filepathhotels);
            serial = new XmlSerializer(shotels.GetType());
            shotels = (List<Hotel>)serial.Deserialize(sr);

            sr.Close();

            return shotels;
        }

        public List<Inventory> DesiralizeInventoryList()
        {
            sr = new StreamReader(filepathroominventory);
            serial = new XmlSerializer(InventoryType.GetType());
            InventoryType = (List<Inventory>)serial.Deserialize(sr);

            sr.Close();

            return InventoryType;
        }

        private String transform(String Type)
        {

            for(int k =0; k < dsroomtypes.Count; k++)
            {
                if (Type.Equals(dsroomtypes[k].id))
                {
                    Type = dsroomtypes[k].name;

                }
            }
            return Type;
        }
    }
}
