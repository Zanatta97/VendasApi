using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasAPI.Context;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly VendasAPIContext _context;
        public ProdutosController(VendasAPIContext context)
        {
            _context = context;
        }

        //Utilizado o IEnurable pois é somente para leitura,
        //é mais leve,
        //e é executado somente quando necessário, não desperdiça recursos.
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos is null)
                return NotFound("Nenhum Produto cadastrado no sistema!");
            return produtos;
        }

    }
}
