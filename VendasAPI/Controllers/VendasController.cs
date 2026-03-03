using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public VendasController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Venda>> Get()
        {
            try
            {
                var vendas = _context.Vendas.AsNoTracking().ToList();

                if (vendas is null)
                    return NotFound("Nenhuma Venda cadastrada no sistema!");

                return Ok(vendas);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    $"Ocorreu um erro ao processar a solicitação. {e.Message}");
            }

            
        }

        //Usado apenas para propósitos de entendimento de como funciona o serialization do C#
        [HttpGet("cliente")]
        public ActionResult<IEnumerable<Venda>> GetVendasClientes()
        {
            return _context.Vendas.Include(c => c.Cliente).AsNoTracking().ToList();
        }

        [HttpGet("{id:int}", Name = "ObterVenda")]
        public ActionResult<Venda> Get(int id)
        {
            var venda = _context.Vendas.AsNoTracking().FirstOrDefault(v => v.Id == id);

            if (venda is null)
                return NotFound($"Venda com id {id} não encontrada!");

            return Ok(venda);
        }

        [HttpPost]
        public ActionResult Post(Venda venda)
        {
            if (venda is null)
                return BadRequest("Venda inválida");

            _context.Vendas.Add(venda);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterVenda", new { id = venda.Id }, venda);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Venda venda)
        {
            if (id != venda.Id)
                return BadRequest("Venda inválida");

            _context.Entry(venda).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(venda);
        }
        
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var venda = _context.Vendas.FirstOrDefault(v => v.Id == id);

            if (venda is null)
                return NotFound($"Venda com id {id} não encontrada!");

            _context.Vendas.Remove(venda);
            _context.SaveChanges();

            return Ok("Venda excluída com sucesso!");
        }
    }
}
