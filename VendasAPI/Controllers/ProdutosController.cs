using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id:int}", Name="ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            if (produto is null)
                return NotFound($"Produto com id {id} não encontrado!");
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest("Produto Inválido");

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.Id }, produto);

        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id)
                return BadRequest("Produto Inválido");

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto is null)
                return NotFound($"Produto com id {id} não encontrado!");

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok($"Produto com id {id} excluído com sucesso!");
        }
    }
}
