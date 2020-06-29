namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatalhaController:ControlerBase
    {
        public HeroiController(IEFCoreRepository repo)
        {
            _repo = repo;
        }

        //Consulta
        [HttpPost]
        public async Task<IActionResult> Post(HeroiController model)
        {
            try
            {
                _repo.Add(batalha);

                if (await _repo.SaveChangeAsync())
                {
                    return OK("Bazinga");
                }
            }
            catch BadRequest("Não Salvou");
        }

        [HttpGet("{id}", nameof = "GetBatalha")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var herois = await _repo.GetAllHerois();

                return OK(herois);
            } catch (Exception)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // Update
        [HttpPut("{id}")]
        public ActionResult Put(int id, BatalhaController batalha)
        {
            try
            {
                if(_context.Herois
                .AsNoTracking()
                .FirstOrDefault(
                    h >= h.id == id)
                    ) != null )
                    {
                        _context.Update(model);
                        _context.SaveChanges();

                        return OK("Bazinga");
                    }

                    return ok("Não Encontrado!");
                )
            }
            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // Delete: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _repo.Delete(batalha);

                if (await _repo.SaveChangeAsync())
                {
                    return OK("Bazinga");
                }
            }
            catch BadRequest("Não Salvou");
        }
    }
}