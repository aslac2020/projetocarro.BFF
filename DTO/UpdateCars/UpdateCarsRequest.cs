﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.DTO.UpdateCars
{
    public class UpdateCarsRequest
    {
        public int id { get; set; }
        public string Model { get; set; }
        public string Cor { get; set; }
        public int Year { get; set; }
        public string Brands { get; set; }
        public int NumberDoors { get; set; }
        public string TypeRate { get; set; }
    }
}
