using MyTunes.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;



namespace MyTunes.Controllers
{
    public class HomeController : Controller
    {
        private MyTunesContext db = new MyTunesContext();
       
            public ActionResult Index()
            {
            
            List<Songs> songs = (db.Songs.ToList());
            
            
            // songs.SongTitle = new List<Music>();



            Music music = new Music()
            {
                Album = "Controversy",
                Artist = "Prince",
                Id = 0,
                Jazz = "Muddy Waters",
                Urban = "Commodores",
                Pop = "Thriller",
                RandB = "Confessions"

                

            };
            
                
               

                return View(songs);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Songs song)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(song);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }







    }
}