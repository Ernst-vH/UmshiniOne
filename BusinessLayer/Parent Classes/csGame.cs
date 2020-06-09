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
    abstract public class csGame
    {
        private int gameID;
        private string name;
        private string description;
        private string genre;
        private int devID;              
        private byte thumbnailImage;

        public int GameID { get => gameID; set => gameID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Genre { get => genre; set => genre = value; }
        public int DevID { get => devID; set => devID = value; }     
        public byte ThumbnailImage { get => thumbnailImage; set => thumbnailImage = value; }
       
        public csGame(int gameID, string name, string description, string genre, int devID, byte thumbnailImage)
        {       
            GameID = gameID;
            Name = name;
            Description = description;
            Genre = genre;
            DevID = devID;
            ThumbnailImage = thumbnailImage;
        }
        public csGame()
        {

        }
    }
}