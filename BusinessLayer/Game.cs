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
    public class Game : csGame
    {              
        public Game(int gameID, string name, string description, string genre, int devID, byte thumbnailImage)
            :base(gameID, name, description, genre, devID, thumbnailImage)
        {
           
        }
        public Game() : base()
        {

        }

        public List<Game> GetData()
        {
            List<Game> returnList = new List<Game>();
            return returnList;
        }
    }
}