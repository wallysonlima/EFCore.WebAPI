using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Heroi
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public Batalha  Batalha {get; set;}
        public int BatalhaId {get; set;}
    }
}