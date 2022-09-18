using MeuApp.Database.Context;
using MeuApp.Database.Repositories.Interfaces;
using MeuApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuApp.Database.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _appDbContext;

    public LancheRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Lanche> GetLanchesPreferidos => _appDbContext.Lanches
        .Where(lanche => lanche.IsFavorito)
        .Include(lanche => lanche.Categoria) ;

    IEnumerable<Lanche> ILancheRepository.GetLanches => _appDbContext.Lanches;

    public Lanche GetLancheById(int id)
    {
        return _appDbContext.Lanches.FirstOrDefault(lanche => lanche.Id == lanche.Id);
    }

}
