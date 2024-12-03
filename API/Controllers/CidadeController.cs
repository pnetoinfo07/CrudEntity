using CrudEntity;
using Infraestrutura;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeRepository _repository;
        public CidadeController(ICidadeRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Adicionar(Cidade cidade)
        {
            try
            {
                _repository.Adicionar(cidade);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Cidade>> List()
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
        public  ActionResult<List<Cidade>> Editar(Cidade p)
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
