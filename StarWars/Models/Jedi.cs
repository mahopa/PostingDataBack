using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class Jedi:Character
    {
        public Rank Rank { get; set; }
        public string LightSaber  { get; set; }
        public bool isLightSide { get; set; }
        public string Teacher { get; set; }
    }
    public enum Rank
    {
        Youngling,
        Padawan,
        Apprentice,
        Jedi,
        Master,
        Lord
    }
}