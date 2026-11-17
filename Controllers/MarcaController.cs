using Concessionaria.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.Controllers
{

    [Route("api/{marcas}")]   // rota: api/veiculo
    [ApiController]
    public class MarcaController : Controller
    {

        // O garçom guarda o cardápio (o acesso à cozinha).
        private readonly IMarcaRepository _marcaRepository;


        // Injeção de dependência: a API entrega o CursoRepository
        // (por causa do AddScoped do passo 11).
        public MarcaController(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        // GET api/curso
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_marcaRepository.ListarTodasMarcas());   // 200 + lista em JSON
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
