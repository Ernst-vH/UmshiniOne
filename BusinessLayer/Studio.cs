using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BusinessLayer
{
    public class Studio
    {
        private string studioAddress;
        private int studioID;
        private string studioName;

        public string StudioAddress { get => studioAddress; set => studioAddress = value; }
        public int StudioID { get => studioID; set => studioID = value; }
        public string StudioName { get => studioName; set => studioName = value; }

        public Studio()
        {

        }

        public Studio(string studioAddress, int studioID, string studioName)
        {
            this.StudioAddress = studioAddress;
            this.StudioID = studioID;
            this.StudioName = studioName;
        }

        public List<Studio> GetStudios()
        {
            List<Studio> studios = new List<Studio>();
            return studios;
        }
    }
}