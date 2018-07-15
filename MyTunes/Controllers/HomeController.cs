using MyTunes.Models;
using System.Web.Mvc;
using System.Collections.Generic;



namespace MyTunes.Controllers
{
    public class HomeController : Controller
    {
        
       
            public ActionResult Index()
            {

            Songs songs = new Songs();
           // songs.SongTitle = new List<Music>();
          
            
            
            Music music = new Music()
            {
                Album = "Controversy",
                Artist ="Prince"
            };
            
                
               

                return View(music);
            }
            
        



        
            

            
        
    }
}