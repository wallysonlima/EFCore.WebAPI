namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatalhaController:ControlerBase
    {
        private readonly BatalhaContext _context;

        public HeroiController(BatalhaContext context)
        {
            _context;
        }

        //Consulta
        [HttpPost]
        public ActionResult Post(HeroiController model)
        {
            try
            {
                _context.Batalha.Add(batalha);
                _context.SaveChanges();

                return OK(BAZINGA);
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(new Batalha());
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
    }
}