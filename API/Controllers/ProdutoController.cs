using CrudEntity;
using Infraestrutura;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Adicionar(Produto produto)
        {
            try
            {
                _repository.Adicionar(produto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Produto>> List()
        {
            try
            {
                return Ok(_repository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public  ActionResult<List<Produto>> Editar(Produto p)
        {
            try
            {
                _repository.Editar(p);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            try
            {
                _repository.Remover(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
