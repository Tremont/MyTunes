using MyTunes.Models;
using System.Web.Mvc;

namespace MyTunes.Controllers
{
    public class HomeController : Controller
    {
        
       
            public ActionResult Index()
            {
            Music music = new Music()
            {
                Album = "Controversy"
            };
            
                
               

                return View(music);
            }
            
        



        
            

            
        
    }
}