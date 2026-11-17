using Concessionaria.Contexts;
using Concessionaria.Interfaces;
using Concessionaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Concessionaria.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ConcessionariaContext _context;

        public VeiculoRepository(ConcessionariaContext context)
        {
            _context = context;
        }

        public Veiculo? BuscarVeiculosPorId(int id)
        {
            return _context.Veiculo.Find(id);
        }

        public void CadastrarVeiculos(Veiculo veiculo)
        {
            _context.Veiculo.Add(veiculo);
            _context.SaveChanges();
        }

        public List<Veiculo> ListarTodosVeiculos()
        {
            return _context.Veiculo.ToList();
        }
    }
}
