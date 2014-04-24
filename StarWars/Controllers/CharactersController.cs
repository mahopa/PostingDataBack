using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWars.Controllers
{

    public class CharactersController : Controller
    {

        List<Character> Characters = new List<Character>()
        {
            new Jedi(){
                 Id =1,
                Name="Yoda", 
                LightSaber="Green", 
                isLightSide=true, 
                Motto="Do or do not, there is no try.", 
                Rank=Rank.Apprentice, 
                Teacher="N'Kata Del Gormo", 
                Picture="http://img1.wikia.nocookie.net/__cb20131106213953/starwars/images/d/d6/Yoda_SWSB.png"  
            },
            new Jedi(){
                Id = 2,
                Name="Luke", 
                LightSaber="Green", 
                isLightSide=true, 
                Rank=Rank.Jedi,
                Teacher="Yoda",
                Motto="Nooooooooooooo!",
                Picture="https://communities.bmc.com/servlet/JiveServlet/showImage/38-6375-59098/LukeSkywalker.jpg"
            },
            new Jedi(){
                Id = 3,
                Name="Darth Vader", 
                LightSaber="Red", 
                isLightSide=false, 
                Rank=Rank.Apprentice,
                Teacher="Emperor Palpatine",
                Motto="Come to the Dark Side!",
                Picture="http://www.ibeta.eu/blog/wp-content/uploads/2012/02/darthvader-design.jpg"
            },
            new BountyHunter(){
                Id= 4,
             Name = "Bobba Fett",
             CurrentTarget = "Han Solo",
             Motto = "He's no good to me dead",
             PastTargets = new List<string>(){"Old","Targets"},
             Ship= "Slave 1",
             Weapon="Thermal Detonator",
             Picture="http://img2.wikia.nocookie.net/__cb20130920001614/starwars/images/5/58/BobaFettMain2.jpg"
            },
            new BountyHunter(){
                Id = 5,
             Name = "Greedo",
             CurrentTarget = "Han Solo",
             Motto = "EEeeee",
             PastTargets = new List<string>(){"Old","Targets"},
             Weapon="Blaster",
             Picture="http://img4.wikia.nocookie.net/__cb20111104205225/starwars/images/c/c6/Greedo.jpg"
            }
        };
        //
        // GET: /Characters/
        public ActionResult Index()
        {
            return View(Characters.OrderBy(y=>y.Name).ToList());
        }

        public ActionResult Jedi()
        {
           
            var jediModel = Characters.OfType<Jedi>().OrderBy(x=>x.Name).ToList();
            List<Character> model = new List<Character>();
            foreach (var item in jediModel)
            {
                model.Add(item);
            }
            return View("Index", model);
        }
        public ActionResult BountyHunters()
        {
            var hunterModel = Characters.OfType<BountyHunter>().OrderBy(x => x.Name).ToList();
            List<Character> model = new List<Character>();
            foreach (var item in hunterModel)
            {
                model.Add(item);
            }
            return View("Index", model);
        }
        [HttpGet]
        public ActionResult AddJedi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJedi(Jedi Someone)
        {
            return View();
        }

        public ActionResult AddHunter()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            
            foreach (var character in Characters)
            {
                if (character.Id == id)
                {
                    var type = character.GetType();
                    var compType = new Jedi().GetType();
                    if (type == compType)
                    {
                        Jedi model =  Characters
                            .OfType<Jedi>()
                            .Where(x=>x.Id == id)
                            .FirstOrDefault();
                        return View("DetailJedi", model);
                    }
                    else
                    {
                        BountyHunter model = Characters
                            .OfType<BountyHunter>()
                            .Where(x => x.Id == id)
                            .FirstOrDefault(); ;
                        return View("DetailHunter", model);
                    }
                }
            }
            //If it gets here something went wrong!
            return View();
        }
	}
}