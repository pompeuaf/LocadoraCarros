using LocadoraBack.Data;
using LocadoraBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace LocadoraBack.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class PedidosController : ControllerBase
    {

        private readonly DataContext db;

        public PedidosController(DataContext db)
        {
            this.db = db;
        }
        // GET: api/<TelefonesController>
        
        
        [HttpGet]
        public List<PedidoModel> Get()
        {
            //return db.PEDIDOS.ToList();
            
            return db.PEDIDOS.Include(a => a.Pessoa).Where(a => a.Id > 0).
                              Include(b => b.Veiculo).Where(b => b.Id > 0).
                              AsNoTracking().ToList();

        }
                
        [HttpGet("{id}")]
        public PedidoModel Get(long id)
        {
            return db.PEDIDOS.Include(a => a.Pessoa).Where(a => a.Id == id).
                              Include(b => b.Veiculo).Where(b => b.Id == id).
                              FirstOrDefault();
        }

        [HttpPost]
        public string post([FromBody] ModelPedido objeto) 
        {
            try
            {
               
                db.PEDIDOS.Add(objeto.ModelParaEntidade());
                db.SaveChanges();
                return "Pedido Cadastrado Com Sucesso !";
            }
            catch (Exception ex)
            {
                return "Erro: " + ex.Message + "  " + ex.InnerException;

            }
        }  
        
    }
}
