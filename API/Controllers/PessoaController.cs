using CrudEntity;
using Infraestrutura;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _repository;
        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Adicionar(Pessoa pessoa)
        {
            try
            {
                _repository.Adicionar(pessoa);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Pessoa>> List()
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
    }
}
