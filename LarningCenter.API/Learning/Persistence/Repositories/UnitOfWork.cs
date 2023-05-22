using LarningCenter.API.Learning.Domain.Repositories;
using LarningCenter.API.Learning.Persistence.Contexts;

namespace LarningCenter.API.Learning.Persistence.Repositories;

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