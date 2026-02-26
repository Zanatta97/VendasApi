using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasJuridicasController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public PessoasJuridicasController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PessoaJuridica>> Get()
        {
            var pessoasJuridicas = _context.PessoasJuridicas.ToList();

            if (pessoasJuridicas is null)
                return NotFound("Nenhuma Pessoa Jurídica cadastrada no sistema!");

            return Ok(pessoasJuridicas);
        }

        [HttpGet("{id:int}", Name = "ObterPessoaJuridica")]
        public ActionResult<PessoaJuridica> Get(int id)
        {
            var pessoaJuridica = _context.PessoasJuridicas.FirstOrDefault(p => p.Id == id);

            if (pessoaJuridica is null)
                return NotFound($"Pessoa Jurídica com id {id} não encontrada!");

            return Ok(pessoaJuridica);
        }

        [HttpPost]
        public ActionResult Post(PessoaJuridica pessoaJuridica)
        {
            if (pessoaJuridica is null)
                return BadRequest("Cliente inválido");

            _context.PessoasJuridicas.Add(pessoaJuridica);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPessoaJuridica", new { id = pessoaJuridica.Id }, pessoaJuridica);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, PessoaJuridica pessoaJuridica)
        {
            if (id != pessoaJuridica.Id)
                return BadRequest("Pessoa Jurídica inválida");

            _context.Entry(pessoaJuridica).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok("Cliente alterado com sucesso!");
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var pessoaJuridica = _context.PessoasJuridicas.FirstOrDefault(p => p.Id == id);

            if (pessoaJuridica is null)
                return NotFound($"Cliente PJ com id {id} não encontrada!");

            _context.PessoasJuridicas.Remove(pessoaJuridica);
            _context.SaveChanges();

            return Ok("Cliente excluído com sucesso!");
        }
    }
}
