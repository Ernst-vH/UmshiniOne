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
    public class Studio : csStudio
    {        
        public Studio(int studioID, string studioName, string studioAddress)
            : base(studioID,studioName,studioAddress)
        {
            
        }
        public Studio() : base()
        {

        }

        public List<Studio> GetData()
        {
            List<Studio> returnList = new List<Studio>();
            return returnList;
        }
    }
}