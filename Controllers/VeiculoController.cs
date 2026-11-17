using Concessionaria.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.Controllers
{

    [Route("api/{veiculos}")]   // rota: api/marcas
    [ApiController]
    public class VeiculoController : Controller
    {

        // O garçom guarda o cardápio (o acesso à cozinha).
        private readonly IVeiculoRepository _veiculoRepository;


        // Injeção de dependência: a API entrega o CursoRepository
        // (por causa do AddScoped do passo 11).
        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        // GET api/curso
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_veiculoRepository.ListarTodosVeiculos());   // 200 + lista em JSON
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
