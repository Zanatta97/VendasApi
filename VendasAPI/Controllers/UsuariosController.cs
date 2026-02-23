using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

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
    }
}
