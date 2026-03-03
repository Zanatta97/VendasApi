using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public FuncionariosController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Funcionario>> Get()
        {
            var funcionarios = _context.Funcionarios.AsNoTracking().ToList();

            if (funcionarios is null)
                return NotFound("Nenhum Funcionario cadastrado no sistema!");

            return Ok(funcionarios);
        }

        [HttpGet("{id:int}", Name = "ObterFuncionario")]
        public ActionResult<Funcionario> Get(int id)
        {
            var funcionario = _context.Funcionarios.AsNoTracking().FirstOrDefault(f => f.Id == id);

            if (funcionario is null)
                return NotFound($"Funcionario com id {id} não encontrado!");

            return Ok(funcionario);
        }

        [HttpPost]
        public ActionResult Post(Funcionario funcionario)
        {
            if (funcionario is null)
                return BadRequest("Funcionario inválido");

            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterFuncionario", new { id = funcionario.Id }, funcionario);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
                return BadRequest("Funcionario inválido");

            _context.Entry(funcionario).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(funcionario);
        }
         [HttpDelete("{id:int}")]
         public ActionResult Delete(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario is null)
                return NotFound($"Funcionario com id {id} não encontrado!");

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return Ok("Funcionario excluído com sucesso!");
        }
    }
}
