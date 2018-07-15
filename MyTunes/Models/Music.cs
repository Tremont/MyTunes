using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTunes.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Jazz { get; set; }
        public string RandB { get; set; }
        public string Urban { get; set; }
        public string Pop { get; set; }

        
        public string Album { get; set; }
        public string Artist { get; set; }
        

       
    }
}