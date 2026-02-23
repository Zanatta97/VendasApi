using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasJuridicasController : ClientesController
    {
        private readonly VendasAPIContext _context;
        public PessoasJuridicasController(VendasAPIContext context) : base(context)
        {
            _context = context;
        }
    }
}
