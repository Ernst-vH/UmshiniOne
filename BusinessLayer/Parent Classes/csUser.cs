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
    abstract public class csUser
    {
        private int userID;
        private string username;
        private string password;
        private string email;       

        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public csUser(int userID, string username, string password, string email)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Email = email;
        }
        public csUser()
        {
            
        }
    }
}