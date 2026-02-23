using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormasPagamentoController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public FormasPagamentoController(VendasAPIContext context)
        {
            _context = context;
        }
    }
}
