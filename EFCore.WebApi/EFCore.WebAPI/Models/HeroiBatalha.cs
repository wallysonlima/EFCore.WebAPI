using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class HeroiBatalha
    {
        public Heroi HeroiId {get; set;}
        public Batalha BatalhaId { get; set; }
        public Heroi Heroi {get; set;}
        public Batalha Batalha {get; set;}
    }
}