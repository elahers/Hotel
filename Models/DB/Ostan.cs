﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.Models.DB
{
    public class Ostan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<JoziayteHotel> JoziayteHotels { get; set; }
    }
}
