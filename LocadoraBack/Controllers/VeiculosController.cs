using LocadoraBack.Data;
using LocadoraBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraBack.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly DataContext db;

        public VeiculosController(DataContext _db)

        {
            db = _db;
        }

        [HttpGet]
        public List<VeiculoModel> get()
        {
            return db.VEICULOS.ToList();
        }

        [HttpGet("{id}")]
        public VeiculoModel get(long id)
        {
            return db.VEICULOS.Find(id);
        }


        [HttpPost]
        public string post([FromBody] VeiculoModel objeto)
        {
            string mensagem;

            try
            {
                    db.VEICULOS.Add(objeto);
                    mensagem = "Veiculo cadastrado com sucesso";

                
                db.SaveChanges();
                return mensagem;
            }
            catch (Exception ex)
            {

                return "ERRO: " + ex.Message + "  " + ex.InnerException;
            }
        }

        [HttpPut]
        public string putt([FromBody] VeiculoModel objeto)
        {
            string mensagem;

            try
            {
                
                    db.VEICULOS.Update(objeto);
                    mensagem = "Veiculo Alterado com sucesso";

                db.SaveChanges();
                return mensagem;
            }
            catch (Exception ex)
            {

                return "ERRO: " + ex.Message + "  " + ex.InnerException;
            }
        }

        [HttpDelete("{id}")]
        public string delete(long id)
        {
            db.VEICULOS.Remove(db.VEICULOS.Find(id));
            db.SaveChanges();
            return "Veiculo excluido com sucesso!";
        }

    }
}
