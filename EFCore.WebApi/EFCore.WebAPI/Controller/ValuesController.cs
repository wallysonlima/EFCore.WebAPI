

public readonly HeroiContext _context {get; set;}

public ValuesController(HeroiContext context)
{
    _context = context;
}

[HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
    return new string[] { "value1", "value2"};
}

// Select
[HttpGet("filtro/nome")]
public ActionResult Get(string nome)
{
    var list Heroi = _context.Herois
                    .Where( h => h.Nome.Contains(nome))
                    .ToList();
   //var listHeroi = _context.Herois.ToList();
   (from heroi in _context.Herois
   where heroi.Nome.Contains(nome) 
   select heroi).ToList();
   return Ok(listHeroi);

   foreach(var item in listHeroi)
   {
       realizaCalculo();
       criaArquivos();
       salvaRelatorio();
   }
}

//Update
[HttpGet("{nameHero}")]
// GET api/values/5
public ActionResult Get(int nameHero)
{
    var listHeroi = _context.Herois
                    .Where( h => h.id ==1)
                    FirstOrDefault();
    
    listHeroi.Nome = "Homem Aranha";

    return OK();
}

// POST api/values
[HttpGet]("AddRange")]
public ActionResult GetAddRange()
{
    _context.AddRange(
        new Heroi { Nome = "Capitão América"},
        new Heroi { Nome = "Doutor Estranho"},
        new Heroi { Nome = "Homem Aranha"},
        new Heroi { Nome = ""}
    )
}

[httpDelete("{id}")]
public void Delete(int id)
{
    var heroi = _context.Herois
                    .Where(x => x.Id == id)
                    .Single();

    _context.Herois.Remove(heroi);
    _context.SaveChanges();
}