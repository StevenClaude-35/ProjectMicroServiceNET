﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformServices.Dtos
{
    public class PlatformReadDto
    {
       
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Publisher { get; set; }
        
        public string Cost { get; set; }
    }
}
