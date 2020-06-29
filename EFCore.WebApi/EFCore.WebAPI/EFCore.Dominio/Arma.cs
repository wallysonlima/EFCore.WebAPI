using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Arma
    {
        public string Id { get; set; }
        public string Nome {get; set;}
        public Heroi Heroi{get; set;}
        public int HeroiId {get; set;}
    }
}