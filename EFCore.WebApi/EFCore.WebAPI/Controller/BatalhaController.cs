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
        public async Task<IActionResult> Post(Heroi model)
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
                var herois = await _repo.GetBatalhaByID(id, true);

                return OK(herois);
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
                var herois = await _repo.GetAllBatalhas(true);

                return OK(herois);
            }

            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // Update
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, BatalhaController batalha)
        {
            try
            {
                var heroi = await _repo.getBatalhaById(id) != null
                
                if(heroi != null)
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
                var heroi = await _repo.getBatalhaById(id) != null
                
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