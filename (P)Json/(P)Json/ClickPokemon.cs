using System;
using System.Collections.Generic;
using System.Text;

namespace _P_Json
{
    public class ClickPokemon
    {
        public int height { get; set; }
        public int weight { get; set; }
        public sprites sprites { get; set; }


    }

    public class sprites
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }

}
