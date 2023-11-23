using LocadoraBack.Data;
using LocadoraBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocadoraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext db;
        public UsersController(DataContext db)
        {
            this.db = db;
        }
        // GET: api/<TelefonesController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return db.USUARIOS.ToList();
        }

        // GET api/<TelefonesController>/5
        [HttpGet("{id}")]
        public UserModel Get(long id)
        {

            return db.USUARIOS.Find(id);
                           
        }

        // POST api/<TelefonesController>
        [HttpPost]
        public string post([FromBody] UserModel value)
        {
            db.USUARIOS.Add(value);
            db.SaveChanges();
            return "Usuário cadastrado com sucesso";
        }

        // PUT api/<TelefonesController>/5
        [HttpPut]
        public string put([FromBody] UserModel value)
        {
            db.USUARIOS.Update(value);
            db.SaveChanges();
            return "Usuário alterado com sucesso";
        }

        // DELETE api/<TelefonesController>/5
        [HttpDelete("{id}")]
        public string Delete(long id)
        {
            db.USUARIOS.Remove(db.USUARIOS.Find(id));
            return "Usuário excluido com sucesso";
        }
    }
}
