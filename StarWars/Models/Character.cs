using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public bool? isHuman { get; set; }
        //public string Species { get; set; }
        //public string Planet { get; set; }
        //public List<string> Affiliations { get; set; }
        public string Motto { get; set; }
        public string Picture { get; set; }
    }
}