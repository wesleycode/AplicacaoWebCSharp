using MeuApp.Models;

namespace MeuApp.Database.Repositories.Interfaces;

public interface ILancheRepository
{
    IEnumerable<Lanche> GetLanches { get; }
    IEnumerable<Lanche> GetLanchesPreferidos { get; }
    Lanche GetLancheById(int id);
}
