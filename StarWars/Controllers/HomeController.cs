using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWars.Controllers
{
    public class HomeController : Controller
    {

        List<Character> Characters = new List<Character>()
        {
            new Jedi(){ 
                Name="Yoda", 
                LightSaber="Green", 
                isLightSide=true, 
                Motto="Do or do not, there is no try.", 
                Rank=Rank.Master, 
                Teacher="N'Kata Del Gormo", 
                Picture="http://img1.wikia.nocookie.net/__cb20131106213953/starwars/images/d/d6/Yoda_SWSB.png"  
            },
            new Jedi(){
                Name="Luke", 
                LightSaber="Green", 
                isLightSide=true, 
                Rank=Rank.Jedi,
                Teacher="Yoda",
                Motto="Nooooooooooooo!",
                Picture="https://communities.bmc.com/servlet/JiveServlet/showImage/38-6375-59098/LukeSkywalker.jpg"
            },
            new Jedi(){
                Name="Darth Vader", 
                LightSaber="Red", 
                isLightSide=false, 
                Rank=Rank.Apprentice,
                Teacher="Emperor Palpatine",
                Motto="Come to the Dark Side!",
                Picture="http://www.ibeta.eu/blog/wp-content/uploads/2012/02/darthvader-design.jpg"
            },
            new BountyHunter(){
             Name = "Bobba Fett",
             CurrentTarget = "Han Solo",
             Motto = "He's no good to me dead",
             PastTargets = new List<string>(){"Old","Targets"},
             Ship= "Slave 1",
             Weapon="Thermal Detonator",
             Picture="http://img2.wikia.nocookie.net/__cb20130920001614/starwars/images/5/58/BobaFettMain2.jpg"
            },
            new BountyHunter(){
             Name = "Greedo",
             CurrentTarget = "Han Solo",
             Motto = "EEeeee",
             PastTargets = new List<string>(){"Old","Targets"},
             Weapon="Blaster",
             Picture="http://img4.wikia.nocookie.net/__cb20111104205225/starwars/images/c/c6/Greedo.jpg"
            }
        };


        public ActionResult Index()
        {
            HomeIndexVM model = new HomeIndexVM();
            model.Fact = "The Ewoks were originally naked, clothing was added to hide the seams of the cosutmes.";
            int chosen = new Random().Next(0, Characters.Count());
            model.FeaturedCharacter = Characters[chosen];
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}