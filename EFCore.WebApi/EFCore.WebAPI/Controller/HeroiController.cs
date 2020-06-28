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