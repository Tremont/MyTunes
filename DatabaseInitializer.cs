using System;
using MyTunes.Models;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;


namespace MyTunes
{
    public MyTunesContext()
    {
        Database.SetInitializer<MyTunesContext>(new DatabaseIntializer());
    }

    public class DatabaseIntializer: DropdatabaseIfModelChanges<MyTunesContext>
    {
        
    
        protected override void Seed(MyTunesContext context)
        {

            IList<Album> albums = new IList<Album>();
            albums.Add(new Album()
            {
                SongTitle = "Cry For You" 
            });
        }
    }














}