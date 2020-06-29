namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        private readonly HeroiContext _context;
        public HeroiController(HeroiContext context)
        {
            _repo = repo;
        }

        [HttpPost]
        public  async Task<IActionResult> Post(Heroi model)
        {
            try
            {
                _repo.Add(heroi);

                if ( await _repo.SaveChangeAsync())
                {
                    return OK("Bazinga");
                }
            }
            catch BadRequest("Não Salvo");
        }

        [HttpGet("{id}", nameof = "GetBatalha")]
        public async Task<IActionResult> Get(int id)
        {
            try 
            {
                var herois = await _repo.GetHeroiByID(id, true); 
            } catch (Exception)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var herois = await _repo.GetAllHerois(true);

                return OK(herois);
            }

            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, HeroiController heroi)
        {
            try
            {
                var heroi = await _repo.getHeroiById(id)
                
                if ( heroi != null)
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

        // Delete: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var heroi = await _repo.getHeroiById(id) != null
                
                if(heroi != null)
                {
                    _context.Delete(model);
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