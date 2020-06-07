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
    public class Developer
    {
        private int devID;
        private string email;
        private string name;
        private string password;
        private int studioID;
        private int studioOwnerID;
        private string surname;

        public int DevID { get => devID; set => devID = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int StudioID { get => studioID; set => studioID = value; }
        public int StudioOwnerID { get => studioOwnerID; set => studioOwnerID = value; }
        public string Surname { get => surname; set => surname = value; }

        public Developer()
        {

        }

        public Developer(int devID, string email, string name, string password, int studioID, int studioOwnerID, string surname)
        {
            this.DevID = devID;
            this.Email = email;
            this.Name = name;
            this.Password = password;
            this.StudioID = studioID;
            this.StudioOwnerID = studioOwnerID;
            this.Surname = surname;
        }

        public List<Developer> GetDevelopers()
        {
            List<Developer> developers = new List<Developer>();
            return developers;
        }
    }
}