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
    public class User : csUser
    {
        public User(int userID, string username, string password, string email)
            : base(userID, username, password, email)
        {
            
        }
        public User() : base()
        {
            
        }

        public List<User> GetData()
        {
            List<User> returnList = new List<User>();
            return returnList;
        }
    }
}