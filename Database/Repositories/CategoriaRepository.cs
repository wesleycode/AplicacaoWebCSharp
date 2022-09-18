using MeuApp.Database.Context;
using MeuApp.Database.Repositories.Interfaces;
using MeuApp.Models;

namespace MeuApp.Database.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _appDbContext;

    public CategoriaRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    IEnumerable<Categoria> ICategoriaRepository.GetCategorias => _appDbContext.Categorias;

    public Categoria GetCategoriaById(int id)
    {
        return _appDbContext.Categorias.FirstOrDefault(categoria => categoria.Id == categoria.Id);
    }

}
