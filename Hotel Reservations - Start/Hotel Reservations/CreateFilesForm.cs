using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using HotelLib;
using System.Xml.Xsl;
using System.Diagnostics;

namespace Hotel_Reservations
{
    
    public partial class CreateFilesForm : Form
    {
        string[] fileNames = null;
        const string outfile = "hotel.html";
        String path;
        HotelFactory myf;
       
        public CreateFilesForm()
        {
           
            InitializeComponent();
            path = Application.StartupPath;
            
        }

        private void btnDisplayHotels_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory.xml";
            frm.ShowDialog();
        }

        private void btnCreateHotels_Click(object sender, EventArgs e)
        {
            myf = new HotelFactory();

            myf.CreateHotelList();

            myf.SerializehotelList();
        }

        private void btnCreateInventory_Click(object sender, EventArgs e)
        {
            myf = new HotelFactory();

            myf.CreateInventoryList();

            myf.SerializeroominvenotryList();
        }

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {

        }

        private void createTheHotelsxmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myf = new HotelFactory();

            myf.CreateHotelList();

            myf.SerializehotelList();
        }

        private void displayTheHotelxmlFileInAWebBrowserWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void createTheRoominventoryxmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myf = new HotelFactory();

            myf.CreateInventoryList();

            myf.SerializeroominvenotryList();
        }

        private void displayTheRoominventoryxmlFileInAWebBrowserWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory.xml";
            frm.ShowDialog();
        }

        private void btnLoadHotelFile_Click(object sender, EventArgs e)
        {
            myf = new HotelFactory();
            myf.DesiralizeHotelList();
            
            myf.DesirealizeRoomInventoryList();
            //myf.DesiralizeInventoryList();
            myf.CreateHotelListItem();
            myf.SerializenewList();
        }

        private void btnCreateListOfAllFiles_Click(object sender, EventArgs e)
        {


            BrowserForm frm = new BrowserForm();

            frm.URL = "hotellistitem.xml";

            frm.ShowDialog();
        }

        private void btnShowHotelList_Click(object sender, EventArgs e)
        {   

                try
                {
                   XslCompiledTransform xslt = new XslCompiledTransform();
                   String filename = path + @"..\..\..\hotellistitem.xslt";

                    xslt.Load(filename);
                    xslt.Transform(path + @"..\..\..\hotellistitem.xml", outfile);
                    Process.Start(outfile);
                  
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                }
            
            
        }
    }
}
