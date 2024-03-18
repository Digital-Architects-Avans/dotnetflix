using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Supplement;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Supplements;

public class SupplementRepository : ISupplementRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public SupplementRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<IEnumerable<Supplement>> GetSupplements()
    {
        var supplements = await _dotNetFlixDbContext.Supplements.ToListAsync();
        return supplements;
    }

    public async Task<Supplement?> GetSupplement(int id)
    {
        var supplement = await _dotNetFlixDbContext.Supplements.SingleOrDefaultAsync(s => s.Id == id);
        return supplement;
    }

    public async Task<Supplement> AddSupplement(AddSupplementDto addSupplementDto)
    {
        var supplement = new Supplement
        {
            Name = addSupplementDto.Name,
            Price = addSupplementDto.Price
        };
        
        var result = await _dotNetFlixDbContext.Supplements.AddAsync(supplement);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Supplement?> UpdateSupplement(int id, UpdateSupplementDto updateSupplementDto)
    {
        var supplement = await _dotNetFlixDbContext.Supplements.FindAsync(id);

        if (supplement != null)
        {
            supplement.Name = updateSupplementDto.Name;
            supplement.Price = updateSupplementDto.Price;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return supplement;
        }

        return null;
    }

    public async Task<bool> DeleteSupplement(int id)
    {
        var supplement = await _dotNetFlixDbContext.Supplements.FindAsync(id);

        if (supplement != null)
        {
            _dotNetFlixDbContext.Supplements.Remove(supplement);
            await _dotNetFlixDbContext.SaveChangesAsync();
            return true;
        }

        return false;
    }

}