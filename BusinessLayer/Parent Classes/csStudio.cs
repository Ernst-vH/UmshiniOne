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
    public abstract class csStudio
    {
        private int studioID;
        private string studioName;
        private string studioAddress;

        public int StudioID { get => studioID; set => studioID = value; }
        public string StudioName { get => studioName; set => studioName = value; }
        public string StudioAddress { get => studioAddress; set => studioAddress = value; }

        public csStudio(int studioID, string studioName, string studioAddress)
        {
            StudioID = studioID;
            StudioName = studioName;
            StudioAddress = studioAddress;
        }
        public csStudio()
        {
            
        }
    }
}