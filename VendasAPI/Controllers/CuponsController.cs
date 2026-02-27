using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CuponsController : ControllerBase
    {
        private readonly VendasAPIContext _context;

        public CuponsController(VendasAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cupom>> GetCupons()
        {
            var cupons = _context.Cupons.ToList();
            if (cupons is null)
                return NotFound("Nenhum Cupom cadastrado no sistema");

            return cupons;
        }

        [HttpGet("{id:int}", Name = "ObterCupom")]
        public ActionResult<Cupom> GetCupom(int id)
        {
            var cupom = _context.Cupons.Find(id);
            if (cupom == null)
            {
                return NotFound($"Cupom com id {id} não encontrado");
            }
            return cupom;
        }

        [HttpPost]
        public ActionResult<Cupom> CreateCupom(Cupom cupom)
        {
            if (cupom is null)
                return BadRequest("Cupom inválido");

            _context.Cupons.Add(cupom);
            _context.SaveChanges();
            
            return new CreatedAtRouteResult("ObterCupom", new { id = cupom.Id }, cupom);
        }

        [HttpPut("{id:int}")]
        public ActionResult UpdateCupom(int id, Cupom cupom)
        {
            if (id != cupom.Id)
                return BadRequest($"Cupom inválido");

            _context.Entry(cupom).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            
            return Ok(cupom);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteCupom(int id)
        {
            var cupom = _context.Cupons.FirstOrDefault(c => c.Id == id);

            if (cupom == null)
            {
                return NotFound($"Cupom com id {id} não encontrado");
            }
            
            _context.Cupons.Remove(cupom);
            _context.SaveChanges();
            
            return Ok($"Cupom excluído com sucesso");
        }
    }
}
