using LocadoraBack.Data;
using LocadoraBack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocadoraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly DataContext db;
        public PessoasController(DataContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public List<PessoaModel> get()
        {
            //PessoaModel model = new PessoaModel();
            //model.Id = 10;
            //model.email = "Fernando@fernadno.com";
            //model.pessoa = "Fernando Graciano";

            //PessoaModel p2 = new PessoaModel();
            //p2.Id = 10;
            //p2.email = "Renato@fernadno.com";
            //p2.pessoa = "Renato 123";

            //List<PessoaModel> lista = new List<PessoaModel>();
            //lista.Add(model);
            //lista.Add(p2);

            return db.PESSOAS.ToList();
        }

        [HttpGet("{id}")]
        public PessoaModel get(long id)
        {
            return db.PESSOAS.Find(id);
        }


        [HttpGet]
        [Route("/localizar/{id}")]
        public List<PessoaModel> localizar(long id)
        {
            return db.PESSOAS.Where(a => a.Id == id).AsNoTracking().ToList();
        }

        [HttpPost]
        public string post([FromBody] PessoaModel objeto)
        {
            try
            {

                if(objeto.Id == 0)
                {
                    db.PESSOAS.Add(objeto);
                }
                else
                {
                    db.PESSOAS.Update(objeto);
                }
                //db.PESSOAS.Update(objeto);
                db.SaveChanges();
                return "Cadastrado com sucesso";
            }
            catch (Exception ex)
            {

                return "ERRO: "+ex.Message + "  " + ex.InnerException;
            }
        }

        [HttpDelete("{id}")]
        public void delete(long id)
        {
            db.PESSOAS.Remove(db.PESSOAS.Find(id));
            db.SaveChanges();
        }
    }
}
