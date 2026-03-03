using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public UsuariosController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            var usuarios = _context.Usuarios.AsNoTracking().ToList();

            if (usuarios is null)
                return NotFound("Nenhum Usuario cadastrado no sistema!");

            return Ok(usuarios);
        }

        [HttpGet("{id:int}", Name = "ObterUsuario")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = _context.Usuarios.AsNoTracking().FirstOrDefault(u => u.Id == id);

            if (usuario is null)
                return NotFound($"Usuario com id {id} não encontrado!");

            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult Post(Usuario usuario)
        {
            if (usuario is null)
                return BadRequest("Usuário inválido!");

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterUsuario", new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest("Usuário inválido");

            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(usuario);

        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario is null)
                return NotFound($"Usuário com id {id} não encontrado!");

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return Ok("Usuário deletado com suscesso!");
        }
    }
}
