using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Heroi
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public identidadeSecreta Identidade{get; set;}
        public List<Arma> Armas {get; set;}

        public List<HeroiBatalha>HeroisBatalhas{get; set;}
    }
}