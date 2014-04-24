using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class HomeIndexVM
    {
        public Character FeaturedCharacter { get; set; }
        public string Fact { get; set; }
    }
}