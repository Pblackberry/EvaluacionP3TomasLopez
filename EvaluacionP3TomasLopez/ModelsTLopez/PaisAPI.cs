﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionP3TomasLopez.ModelsTLopez
{
    
        public class PaisAPI
        {
            public Name Name { get; set; }
            public string Region { get; set; }
            public Maps Maps { get; set; }
        }

        public class Name
        {
            public string Official { get; set; }
        }

        public class Maps
        {
            public string GoogleMaps { get; set; }
        }
    
}
