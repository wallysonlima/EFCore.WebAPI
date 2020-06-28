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
        public ActionResult Post(Heroi model)
        {
            try
            {
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
                return Ok(new Heroi());
            } catch (Exception)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Heroi)
        {
            try
            {
                if(_context.Herois
                .AsNoTracking()
                .FirstOrDefault(
                h => h.id == id)
                ) != null)
                {
                    _context.Update(model);
                    _context.SaveChanges();

                    return OK("Bazinga");
                }

                return ok("Não Encontrado!");
            }
            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}