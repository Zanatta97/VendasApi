using Microsoft.AspNetCore.Http;
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
            return _context.Cupons.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Cupom> GetCupom(int id)
        {
            var cupom = _context.Cupons.Find(id);
            if (cupom == null)
            {
                return NotFound();
            }
            return cupom;
        }
    }
}
