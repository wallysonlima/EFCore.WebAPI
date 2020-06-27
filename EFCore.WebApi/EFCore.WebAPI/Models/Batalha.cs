using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Batalha
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public DateTime myProperty{get;set;}
        public DateTime DtFim {get; set;}

        public List<HeroiBatalha> HeroisBatalhas{get; set;}
    }
}