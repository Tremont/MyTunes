using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTunes.Models
{
    public class Songs
    {
        public int Id { get; set; }
        [Required]
        public string SongTitle { get; set; }
        public string SongType { get; set; }
        public string SongVideo { get; set; }
       

    }
}