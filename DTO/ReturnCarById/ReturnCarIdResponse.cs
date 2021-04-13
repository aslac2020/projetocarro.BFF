using projetocarro.BFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF.DTO.ReturnCarById
{
    public class ReturnCarIdResponse
    {
        public Cars cars { get; set; }
        public string msg { get; set; }
        public int id { get; set; }
    }
}
