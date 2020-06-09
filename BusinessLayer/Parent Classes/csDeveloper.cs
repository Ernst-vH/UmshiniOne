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
    abstract public class csDeveloper
    {
        private int devID;
        private string name;
        private string surname;
        private string password;
        private string email;      
        private int studioID;
        private int studioOwnerID;
        
        public int DevID { get => devID; set => devID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }      
        public int StudioID { get => studioID; set => studioID = value; }
        public int StudioOwnerID { get => studioOwnerID; set => studioOwnerID = value; }        

        public csDeveloper(int devID, string name, string surname, string password, string email, int studioID, int studioOwnerID)
        {
            DevID = devID;
            Name = name;
            Surname = surname;
            Password = password;
            Email = email;           
            StudioID = studioID;
            StudioOwnerID = studioOwnerID;         
        }
        public csDeveloper()
        {

        }
    }
}