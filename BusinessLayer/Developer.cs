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
    public class Developer: csDeveloper
    {
        public Developer(int devID, string name, string surname, string password, string email,  int studioID, int studioOwnerID)
            :base(devID, name, surname, password, email, studioID, studioOwnerID)
        {

        }
        public Developer() : base()
        { 

        }

        public List<Developer> GetData()
        {
            List<Developer> returnList = new List<Developer>();
            return returnList;
        }
    }
}