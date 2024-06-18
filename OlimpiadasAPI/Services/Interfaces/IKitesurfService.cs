using OlimpiadasApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OlimpiadasApi.IServices;
public interface IKitesurfService
{
    Task<IEnumerable<Kitesurf>> GetAllKitesurfsAsync();
    Task<Kitesurf> GetKitesurfByIdAsync(int id);
    Task<Kitesurf> CreateKitesurfAsync(Kitesurf kitesurf);
    Task<Kitesurf> UpdateKitesurfAsync(int id, Kitesurf kitesurf);
    Task<bool> DeleteKitesurfAsync(int id);
}