using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FuncionariosController : UsuariosController
    {
        private readonly VendasAPIContext _context;
        public FuncionariosController(VendasAPIContext context) : base(context)
        {
            _context = context;
        }
    }
}
