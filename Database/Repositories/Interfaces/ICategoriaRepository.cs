using MeuApp.Models;

namespace MeuApp.Database.Repositories.Interfaces;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> GetCategorias { get; }
    Categoria GetCategoriaById(int id);

}
