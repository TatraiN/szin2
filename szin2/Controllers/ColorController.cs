using Microsoft.AspNetCore.Mvc;
using szin2.BookModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace szin2.Controllers
{
    [Route("api/color")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        // GET: api/<ColorController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.ColorsAndMeanings.ToList());
        }

        // GET api/<ColorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var color = (from x in context.ColorsAndMeanings
                         where x.ColorId == id
                         select x).FirstOrDefault();
            if (color == null)
            {
                return NotFound("Nincs ilyen azonosító");

            }

            return Ok(color);
        }

        // POST api/<ColorController>
        [HttpPost]
        public void Post([FromBody] ColorsAndMeaning újszín)
        {
            FunnyDatabaseContext ctx = new FunnyDatabaseContext();
            ctx.ColorsAndMeanings.Add(újszín);
            ctx.SaveChanges();

        }

        // PUT api/<ColorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ColorsAndMeaning value)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var mod = (from x in context.ColorsAndMeanings
                       where x.ColorId == id
                       select x).FirstOrDefault();
            if (mod == null)
            {
                return NotFound("Nincs ilyen");
            }

            mod.Culture = value.Culture;
            mod.Meaning = value.Meaning;
            mod.Color = value.Color;
            mod.IsPositive = value.IsPositive;

            context.SaveChanges();
            return Ok("Siker");
        }

        // DELETE api/<ColorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var del = (from x in context.ColorsAndMeanings
                         where x.ColorId == id
                         select x).FirstOrDefault();
            if (del == null)
            {
                return NotFound("Nincs ilyen");
            }
            context.Remove(del);
            context.SaveChanges();

            return Ok("Sikeresen törölve");
        }
    }
}
