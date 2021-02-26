using System;
using System.Collections.Generic;
using System.Text;

namespace _P_Json
{
    public class AllPokemonAPI
    {
        public List<resultobject> results { get; set; }
    }

    public class resultobject
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
