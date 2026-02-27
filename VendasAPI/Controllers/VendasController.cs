using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            var vendas = _context.Vendas.ToList();

            if (vendas is null)
                return NotFound("Nenhuma Venda cadastrada no sistema!");

            return Ok(vendas);
        }

        [HttpGet("{id:int}", Name = "ObterVenda")]
        public ActionResult<Venda> Get(int id)
        {
            var venda = _context.Vendas.FirstOrDefault(v => v.Id == id);

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
