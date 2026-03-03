using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormasPagamentoController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public FormasPagamentoController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FormaPagamento>> Get()
        {
            var formasPagamento = _context.FormasPagamento.AsNoTracking().ToList();

            if (formasPagamento is null)
                return NotFound("Nenhuma Forma de Pagamento cadastrada no sistema!");

            return Ok(formasPagamento);
        }

        [HttpGet("{id:int}", Name = "ObterFormaPagamento")]
        public ActionResult<FormaPagamento> Get(int id)
        {
            var formaPagamento = _context.FormasPagamento.AsNoTracking().FirstOrDefault(f => f.Id == id);

            if (formaPagamento is null)
                return NotFound($"Forma de Pagamento com id {id} não encontrada!");

            return Ok(formaPagamento);
        }

        [HttpPost]
        public ActionResult Post(FormaPagamento formaPagamento)
        {
            if (formaPagamento is null)
                return BadRequest("Forma de Pagamento inválida");

            _context.FormasPagamento.Add(formaPagamento);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterFormaPagamento", new { id = formaPagamento.Id }, formaPagamento);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, FormaPagamento formaPagamento)
        {
            if (id != formaPagamento.Id)
                return BadRequest("Forma de Pagamento inválida");

            _context.Entry(formaPagamento).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(formaPagamento);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var formaPagamento = _context.FormasPagamento.FirstOrDefault(f => f.Id == id);

            if (formaPagamento is null)
                return NotFound($"Forma de Pagamento com id {id} não encontrada!");

            _context.FormasPagamento.Remove(formaPagamento);
            _context.SaveChanges();

            return Ok("Forma de Pagamento excluída com sucesso!");
        }
    }
}
