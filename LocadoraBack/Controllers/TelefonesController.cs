using LocadoraBack.Data;
using LocadoraBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocadoraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefonesController : ControllerBase
    {
        private readonly DataContext db;
        public TelefonesController(DataContext db)
        {
            this.db = db;
        }
        // GET: api/<TelefonesController>
        [HttpGet]
        public IEnumerable<TelefoneEntidade> Get()
        {
            return db.TELEFONES.ToList();
        }

        // GET api/<TelefonesController>/5
        [HttpGet("{id}")]
        public TelefoneEntidade Get(long id)
        {

            return db.TELEFONES.Include(a => a.Pessoa).Where(a => a.Id == id).FirstOrDefault();
        }

        // POST api/<TelefonesController>
        [HttpPost]
        public void Post([FromBody] TelefoneEntidade value)
        {
            db.TELEFONES.Add(value);
            db.SaveChanges();
        }

        // PUT api/<TelefonesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TelefoneEntidade value)
        {
            db.TELEFONES.Add(value);
            db.SaveChanges();
        }

        // DELETE api/<TelefonesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.TELEFONES.Remove(db.TELEFONES.Find(id));
        }
    }
}
