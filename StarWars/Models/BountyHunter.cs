using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class BountyHunter:Character
    {
        public string Ship { get; set; }
        public string Weapon { get; set; }
        public string CurrentTarget { get; set; }
        public List<string> PastTargets { get; set; }
    }
}