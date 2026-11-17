using Concessionaria.Models;

namespace Concessionaria.Interfaces
{
    public interface IVeiculoRepository
    {
        List<Veiculo> ListarTodosVeiculos();

        Veiculo? BuscarVeiculosPorId(int id);

        void CadastrarVeiculos(Veiculo veiculo);
    }
}
