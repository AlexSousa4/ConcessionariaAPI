using Concessionaria.Contexts;
using Concessionaria.Interfaces;
using Concessionaria.Models;

namespace Concessionaria.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {

        private readonly ConcessionariaContext _context;

        public MarcaRepository(ConcessionariaContext context)
        {
            _context = context;
        }
        public Marca? BuscarMarcaPorId(int id)
        {
            return _context.Marca.Find(id);
        }

        public void CadastrarMarcas(Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();
        }

        public List<Marca> ListarTodasMarcas()
        {
            return _context.Marca.ToList();
        }
    }
}
