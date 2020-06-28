namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        private readonly HeroiContext _context;
        public HeroiController(HeroiContext context)
        {
            _context;
        }

        [HttpPost]
        public ActionResult Post(HeroiController value)
        {
            try
            {
            
               var heroi = new HeroiController
               {
                   Id = id,
                   Nome = "Homem de ferro",
                   Armas = new List<Arma>
                   {
                       new Arma {Nome = "Mac 3"},
                       new Arma {Nome = "Mac 5"}
                   }
               };

               _context.Herois.Add(heroi);
               _context.SaveChanges();

               return OK(BAZINGA);
            }


            catch (Exception ex)
            {
                return BadRequest
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try 
            {
                return Ok();
            } catch (Exception)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}