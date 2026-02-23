using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

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
    }
}
