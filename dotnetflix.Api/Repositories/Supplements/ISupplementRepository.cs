using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Supplement;

namespace dotnetflix.Api.Repositories.Supplements;

public interface ISupplementRepository
{
    Task<IEnumerable<Supplement>> GetSupplements();
    Task<Supplement?> GetSupplement(int id);
    Task<Supplement> AddSupplement(AddSupplementDto addSupplementDto);
    Task<Supplement?> UpdateSupplement(int id, UpdateSupplementDto updateSupplementDto);
    Task<bool> DeleteSupplement(int id);
}