using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormasEntregaController : ControllerBase
    {
        private readonly VendasAPIContext _context;

        public FormasEntregaController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FormaEntrega>> Get()
        {
            var formasEntrega = _context.FormasEntrega.AsNoTracking().ToList();

            if (formasEntrega is null)
                return NotFound("Nenhuma Forma de Entrega cadastrada no sistema!");

            return Ok(formasEntrega);
        }

        [HttpGet("{id:int}", Name = "ObterFormaEntrega")]
        public ActionResult<FormaEntrega> Get(int id)
        {
            var formaEntrega = _context.FormasEntrega.AsNoTracking().FirstOrDefault(f => f.Id == id);

            if (formaEntrega is null)
                return NotFound($"Forma de Entrega com id {id} não encontrada!");

            return Ok(formaEntrega);
        }

        [HttpPost]
        public ActionResult Post(FormaEntrega formaEntrega)
        {
            if (formaEntrega is null)
                return BadRequest("Forma de Entrega inválida");

            _context.FormasEntrega.Add(formaEntrega);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterFormaEntrega", new { id = formaEntrega.Id }, formaEntrega);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, FormaEntrega formaEntrega)
        {
            if (id != formaEntrega.Id)
                return BadRequest("Forma de Entrega inválida");

            _context.Entry(formaEntrega).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(formaEntrega);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var formaEntrega = _context.FormasEntrega.FirstOrDefault(f => f.Id == id);

            if (formaEntrega is null)
                return NotFound($"Forma de Entrega com id {id} não encontrada!");

            _context.FormasEntrega.Remove(formaEntrega);
            _context.SaveChanges();

            return Ok("Forma de Entrega excluída com sucesso");
        }
    }
}
