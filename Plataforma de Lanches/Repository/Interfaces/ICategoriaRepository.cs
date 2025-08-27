using Plataforma_de_Lanches.Models;

namespace Plataforma_de_Lanches.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }


    }
}
