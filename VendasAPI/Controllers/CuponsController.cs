using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

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
    }
}
