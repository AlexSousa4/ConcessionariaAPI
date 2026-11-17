
using Concessionaria.Contexts;
using Concessionaria.Models;

namespace Concessionaria.Interfaces

{
    public interface IMarcaRepository
    {
        List<Marca> ListarTodasMarcas();

        Marca? BuscarMarcaPorId(int id);

        void CadastrarMarcas(Marca marca);
    }
}
