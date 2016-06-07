using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swg
{
    class Planet
    {

        public string[] cities { get; set; }
        public string name { get; set; }

        public Planet(string n)
        {
            name = n;
        }

    }
}
