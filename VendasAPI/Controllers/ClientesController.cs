using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly VendasAPIContext _context;

        public ClientesController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var clientes = _context.Clientes.ToList();

            if (clientes is null)
                return NotFound("Nenhum Cliente cadastrado no sistema!");

            return Ok(clientes);
        }

        [HttpGet("{id:int}", Name = "ObterCliente")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            if (cliente is null)
                return NotFound($"Cliente com id {id} não encontrado!");

            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente)
        {
            if (cliente is null)
                return BadRequest("Cliente inválido");

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCliente", new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Cliente cliente)
        {
            if (id != cliente.Id)
                return BadRequest("Cliente inválido");

            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(cliente);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            if (cliente is null)
                return NotFound($"Cliente com id {id} não encontrado!");

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return Ok("Cliente excluído com sucesso!");
        }
    }
}
