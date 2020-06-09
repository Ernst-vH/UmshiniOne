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
    abstract public class csStudioOwner
    {
        private int studioOwnerID;
        private string name;
        private string surname;
        private string email;
        private int studioID;

        public int StudioOwnerID { get => studioOwnerID; set => studioOwnerID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public int StudioID { get => studioID; set => studioID = value; }

        public csStudioOwner(int studioOwnerID, string name, string surname, string email, int studioID)
        {
            StudioOwnerID = studioOwnerID;
            Name = name;
            Surname = surname;
            Email = email;
            StudioID = studioID;
        }
        public csStudioOwner()
        {
            
        }
    }
}