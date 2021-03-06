﻿using MyTunes.Models;
using System.Data.Entity;
using System;
using System.Web.Configuration;
using System.Linq;
using MyTunes.Data;

namespace MyTunes
{
    public class MyTunesContext : DbContext
    {
        
        public DbSet<Songs> Songs { get; set; }

        public MyTunesContext()
            
        {
            Database.SetInitializer<MyTunesContext>(new DatabaseInitializer());
            SeedData();
             
        }
        public void SeedData()
        {
            if (Songs.Count() == 0)
            {
                Songs song = new Songs
                {

                    SongTitle = "When Doves Cry",
                    SongType = "Blues ",
                    SongVideo = "Vimeo"



                };
                 Songs.Add(song);

                

            }
            SaveChanges();
        }
    }

}

      