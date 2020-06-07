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
    public class Game
    {
        private string description;
        private int devID;
        private int GameID;
        private string genre;
        private string name;
        private byte thumbnailImage;

        public string Description { get => description; set => description = value; }
        public int DevID { get => devID; set => devID = value; }
        public int GameID1 { get => GameID; set => GameID = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Name { get => name; set => name = value; }
        public byte ThumbnailImage { get => thumbnailImage; set => thumbnailImage = value; }

        public Game()
        {

        }

        public Game(string description, int devID, int gameID1, string genre, string name, byte thumbnailImage)
        {
            this.Description = description;
            this.DevID = devID;
            this.GameID1 = gameID1;
            this.Genre = genre;
            this.Name = name;
            this.ThumbnailImage = thumbnailImage;
        }

        public List<Game> GetGames()
        {
            List<Game> games = new List<Game>();
            return games;
        }
    }
}