using LarningCenter.API.Learning.Domain.Repositories;
using LarningCenter.API.Shared.Persistence.Contexts;

namespace LarningCenter.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;


    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}