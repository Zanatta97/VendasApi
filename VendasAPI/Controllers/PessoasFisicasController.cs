using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasFisicasController : ControllerBase
    {
        private readonly VendasAPIContext _context;

        public PessoasFisicasController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PessoaFisica>> Get()
        {
            var pessoasFisicas = _context.PessoasFisicas.ToList();

            if (pessoasFisicas is null)
                return NotFound("Nenhuma Pessoa Física cadastrada no sistema!");

            return Ok(pessoasFisicas);
        }

        [HttpGet("{id:int}", Name = "ObterPessoaFisica")]
        public ActionResult<PessoaFisica> Get(int id)
        {
            var pessoaFisica = _context.PessoasFisicas.FirstOrDefault(p => p.Id == id);

            if (pessoaFisica is null)
                return NotFound($"Pessoa Física com id {id} não encontrada!");

            return Ok(pessoaFisica);
        }

        [HttpPost]
        public ActionResult Post(PessoaFisica pessoaFisica)
        {
            if (pessoaFisica is null)
                return BadRequest("Pessoa Física inválida");

            _context.PessoasFisicas.Add(pessoaFisica);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPessoaFisica", new { id = pessoaFisica.Id }, pessoaFisica);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, PessoaFisica pessoaFisica)
        {
            if (id != pessoaFisica.Id)
                return BadRequest("Pessoa Física inválida");

            _context.Entry(pessoaFisica).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok("Pessoa Física alterada com sucesso!");
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var pessoaFisica = _context.PessoasFisicas.FirstOrDefault(p => p.Id == id);

            if (pessoaFisica is null)
                return NotFound($"Pessoa Física com id {id} não encontrada!");

            _context.PessoasFisicas.Remove(pessoaFisica);
            _context.SaveChanges();

            return Ok("Pessoa Física excluída com sucesso!");
        }
    }
}
