using MyTunes.Models;
using System.Data.Entity;
using System;
using System.Web.Configuration;
using System.Linq;

namespace MyTunes
{
    public class MyTunesContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }

        public MyTunesContext()
        {
            SeedData();

        }
        public void SeedData()
        {
           // if (Songs.Count() <= 0)
           // {
                Songs song = new Songs
                {

                    SongTitle = "When Doves Cry"

                };
                Songs.Add(song);


               //  }
                SaveChanges();
            }
    }

}

      