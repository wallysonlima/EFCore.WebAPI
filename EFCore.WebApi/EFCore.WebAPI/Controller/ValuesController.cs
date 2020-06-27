public ActionResult<IEnumerable<string>> Get()
{
    return new string[] { "value1", "value2"};
}

// GET api/values/5
public ActionResult Get(int id)
{
    var heroi = new Heroi{};
    using(var contexto = new HeroiContext())
    {
        contexto.Herois.Add(heroi);
        //contexto.Add(heroi);
        contexto.SaveChanges();
    }

    return OK();
}

// POST api/values
[HttpPost]
public void Post([FromBody] string value)
{

}