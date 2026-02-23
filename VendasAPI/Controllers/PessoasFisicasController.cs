using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasFisicasController : ClientesController
    {
        private readonly VendasAPIContext _context;

        public PessoasFisicasController(VendasAPIContext context) : base(context)
        {
            _context = context;
        }
    }
}
