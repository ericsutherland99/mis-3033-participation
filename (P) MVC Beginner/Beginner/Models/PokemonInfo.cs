using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beginner.Models
{
    public class PokemonInfo
    {
        public double height { get; set; }

        [JsonProperty("sprites")]
        public Sprite SquigglyWorm { get; set; }

        public double weight { get; set; }

        public string name { get; set; }
    }

    public class Sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}