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
    public class StudioOwner : csStudioOwner
    {
        public StudioOwner(int studioOwnerID, string name, string surname, string email, int studioID)
            : base(studioOwnerID, name, surname, email, studioID)
        {
            
        }
        public StudioOwner() : base()
        {
            
        }

        public List<StudioOwner> GetData()
        {
            List<StudioOwner> returnList = new List<StudioOwner>();
            return returnList;
        }
    }
}